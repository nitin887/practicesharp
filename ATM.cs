using System;
using System.Text.Json;               // Needed for JsonSerializer and JsonSerializerOptions
using System.Text.Json.Serialization; // Needed for the Source Generator

public enum CardStatus
{
    Available,
    Blocked
}

// 1. User Class (Replaces 'Details' and 'Signup' inheritance)
public class User
{
    public string UserName { get; private set; }
    public string HashedPassword { get; private set; } // Passwords should be strings/hashes, not ints

    public User(string userName, string hashedPassword)
    {
        UserName = userName;
        HashedPassword = hashedPassword;
    }
}

// 2. Card Class
public class Card
{
    public int CardNo { get; private set; }
    public DateOnly ExpiryDate { get; private set; }
    public CardStatus Status { get; private set; }
    public int LinkedAccountNo { get; private set; } // Just link the ID, not the whole Account object

    public Card(int cardNo, DateOnly expiryDate, int linkedAccountNo)
    {
        CardNo = cardNo;
        ExpiryDate = expiryDate;
        Status = CardStatus.Available;
        LinkedAccountNo = linkedAccountNo;
    }

    // Business rule: Check if expired
    public bool IsExpired(DateOnly currentDate)
    {
        return currentDate >= ExpiryDate;
    }

    public void BlockCard()
    {
        Status = CardStatus.Blocked;
    }
}

// 3. Account Class
public class Account
{
    // --- Properties ---
    public int AccountNo { get; private set; }
    public double Balance { get; private set; }
    public string HashedPin { get; private set; }

    // Security Properties
    public bool IsLocked { get; private set; }
    public int FailedPinAttempts { get; private set; }

    // Configuration
    private const int MaxFailedAttempts = 3;

    // --- Constructor ---
    [JsonConstructor]
    public Account(int accountNo, double initialBalance, string hashedPin)
    {
        AccountNo = accountNo;
        Balance = initialBalance;
        HashedPin = hashedPin;
        IsLocked = false;
        FailedPinAttempts = 0;
    }

    // --- Security Methods ---

    // Handles login attempts and account locking
    public bool TryLogin(string inputPin)
    {
        if (IsLocked)
            throw new UnauthorizedAccessException("Account is blocked due to too many failed attempts.");

        // In a real application, you would hash 'inputPin' before comparing
        if (HashedPin == inputPin)
        {
            FailedPinAttempts = 0; // Reset counter on successful login
            return true;
        }

        // If we get here, the PIN was wrong
        FailedPinAttempts++;
        if (FailedPinAttempts >= MaxFailedAttempts)
        {
            IsLocked = true;
        }
        return false;
    }

    // Handles updating the PIN safely
    public void ChangePin(string oldPin, string newPin)
    {
        if (IsLocked)
            throw new UnauthorizedAccessException("Cannot change PIN. Account is blocked.");

        if (HashedPin != oldPin)
            throw new ArgumentException("Old PIN is incorrect.");

        // Enforce basic PIN rules
        if (string.IsNullOrWhiteSpace(newPin) || newPin.Length < 4)
            throw new ArgumentException("New PIN must be at least 4 digits long.");

        HashedPin = newPin; // Remember to hash this in a production environment
    }

    // --- Financial Methods ---

    // Safely removes money
    public void Debit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be greater than zero.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient balance.");

        Balance -= amount;
    }

    // Safely adds money
    public void Credit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be greater than zero.");

        Balance += amount;
    }
}
// 1. Cash Inventory: Manages the physical money inside the machine
public class CashInventory
{
    public double TotalBalance { get; private set; }
    private int _hundredNotes;
    private int _fiveHundredNotes;

    public CashInventory(int initialHundredNotes, int initialFiveHundredNotes)
    {
        _hundredNotes = initialHundredNotes;
        _fiveHundredNotes = initialFiveHundredNotes;
        CalculateTotal();
    }

    private void CalculateTotal()
    {
        TotalBalance = (_hundredNotes * 100) + (_fiveHundredNotes * 500);
    }

    public bool HasSufficientCash(double amount)
    {
        return TotalBalance >= amount;
    }

    // Business rule: ATM gives out cash
    public void DispenseCash(double amount)
    {
        if (!HasSufficientCash(amount))
            throw new InvalidOperationException("ATM hardware does not have enough cash.");

        // Note: In a real system, you'd calculate exact note deduction here. 
        // For simplicity, we just reduce the total balance.
        TotalBalance -= amount;
    }

    // Business rule: ATM accepts physical cash
    public void AcceptCash(double amount)
    {
        TotalBalance += amount;
    }
}

// 2. Transaction Record: A pure data model to store history
public class TransactionRecord
{
    public string TransactionId { get; private set; }
    public DateTime Timestamp { get; private set; }
    public string Type { get; private set; }
    public double Amount { get; private set; }

    public TransactionRecord(string type, double amount)
    {
        TransactionId = Guid.NewGuid().ToString(); // Automatically generates a unique ID
        Timestamp = DateTime.Now;
        Type = type;
        Amount = amount;
    }
}

// 3. The Main Transaction Service: Coordinates everything
public class TransactionService
{
    private readonly CashInventory _atmInventory;
    public List<TransactionRecord> TransactionHistory { get; private set; }

    // We inject the physical ATM inventory when we boot up the system
    public TransactionService(CashInventory atmInventory)
    {
        _atmInventory = atmInventory;
        TransactionHistory = new List<TransactionRecord>();
    }

    public void ProcessWithdrawal(Account currentAccount, double amount)
    {
        // 1. Check ATM cash limit
        if (!_atmInventory.HasSufficientCash(amount))
            throw new InvalidOperationException("ATM out of order or insufficient machine funds.");

        // 2. Attempt to debit the user's account (will throw error if user is broke)
        currentAccount.Debit(amount);

        // 3. Dispense physical cash
        _atmInventory.DispenseCash(amount);

        // 4. Record it
        TransactionHistory.Add(new TransactionRecord("Withdrawal", amount));
    }

    public void ProcessDeposit(Account currentAccount, double amount)
    {
        // 1. Add money to the user's account
        currentAccount.Credit(amount);

        // 2. Add physical money to the ATM
        _atmInventory.AcceptCash(amount);

        // 3. Record it
        TransactionHistory.Add(new TransactionRecord("Deposit", amount));
    }

    public void ProcessTransfer(Account sourceAccount, Account destinationAccount, double amount)
    {
        // 1. Take money from the sender
        sourceAccount.Debit(amount);

        // 2. Give money to the receiver
        destinationAccount.Credit(amount);

        // 3. Record it
        TransactionHistory.Add(new TransactionRecord($"Transfer to {destinationAccount.AccountNo}", amount));
    }
}
public class ATMConsoleUI
{
    private readonly TransactionService _transactionService;
    private Account? _currentAccount;

    // The UI needs the backend service to function
    public ATMConsoleUI(TransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    public void StartSession(List<Account> bankDatabase)
    {
        Console.WriteLine("==== WELCOME TO SARASWATI BANKING ====");
        Console.WriteLine("Please enter your Account Number:");

        if (!int.TryParse(Console.ReadLine(), out int accountNo)) return;

        Console.WriteLine("Enter your PIN:");
        string pin = Console.ReadLine() ?? "";

        _currentAccount = bankDatabase.Find(a => a.AccountNo == accountNo);

        if (_currentAccount == null)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        try
        {
            // Using our new security-aware login method
            if (!_currentAccount.TryLogin(pin))
            {
                int attemptsLeft = 3 - _currentAccount.FailedPinAttempts;
                Console.WriteLine($"Incorrect PIN. You have {attemptsLeft} attempts remaining.");
                return;
            }

            Console.WriteLine($"\nLogin Successful. Welcome!");
            ShowMainMenu();
        }
        catch (Exception ex)
        {
            // This will catch the "Account is blocked" error perfectly
            Console.WriteLine($"\n[SECURITY ALERT] {ex.Message}");
        }
    }

    // ... Inside the ShowMainMenu() switch statement, add case "6":

    private void HandlePinChange()
    {
        Console.Write("Enter your OLD PIN: ");
        string oldPin = Console.ReadLine() ?? "";

        Console.Write("Enter your NEW PIN: ");
        string newPin = Console.ReadLine() ?? "";

        try
        {
            _currentAccount!.ChangePin(oldPin, newPin);
            Console.WriteLine("Success! Your PIN has been updated.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[ERROR] {ex.Message}");
        }
    }

    private void ShowMainMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Withdraw Cash");
            Console.WriteLine("2. Deposit Cash");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Mini Statement");
            Console.WriteLine("5. Change PIN");
            Console.WriteLine("6. End Session");
            Console.Write("Select an option (You have 30 seconds): ");

            try
            {
                // Use our new Secure Console instead of normal ReadLine
                // If the user does nothing for 30 seconds, it throws an error
                string choice = SecureConsole.ReadLineWithTimeout(30);

                switch (choice)
                {
                    case "1": HandleWithdrawal(); break;
                    case "2": HandleDeposit(); break;
                    case "3": Console.WriteLine($"Your current balance is: {_currentAccount!.Balance}"); break;
                    case "4": ShowHistory(); break;
                    case "5": HandlePinChange(); break;
                    case "6":
                        Console.WriteLine("Thank you for using Saraswati Banking. Session ended.");
                        _currentAccount = null;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (TimeoutException) // Catch the specific timeout error!
            {
                Console.WriteLine("\n\n[SECURITY ALERT] Session expired due to inactivity. Logging out automatically...");
                _currentAccount = null; // Clear the user's session data
                return; // Exit back to the login screen
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERROR] {ex.Message}");
            }
        }
    }

    private void HandleWithdrawal()
    {
        Console.Write("Enter amount to withdraw: ");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            _transactionService.ProcessWithdrawal(_currentAccount, amount);
            Console.WriteLine($"Success! Please collect your cash. New Balance: {_currentAccount!.Balance}");
        }
    }

    private void HandleDeposit()
    {
        Console.Write("Enter amount to deposit: ");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            _transactionService.ProcessDeposit(_currentAccount, amount);
            Console.WriteLine($"Success! Cash deposited. New Balance: {_currentAccount!.Balance}");
        }
    }

    private void ShowHistory()
    {
        Console.WriteLine("\n--- Recent Transactions ---");
        var history = _transactionService.TransactionHistory;
        if (history.Count == 0)
        {
            Console.WriteLine("No recent transactions.");
            return;
        }

        foreach (var record in history)
        {
            Console.WriteLine($"[{record.Timestamp.ToShortTimeString()}] {record.Type}: {record.Amount} (ID: {record.TransactionId})");
        }
    }
}

// 2. The Main Entry Point (Composition Root)
// 1. The Source Generator Context (Must be 'partial')
[JsonSerializable(typeof(List<Account>))]
public partial class AccountJsonContext : JsonSerializerContext
{
}

// 2. The Database Manager
public class FileDatabase
{
    private readonly string _filePath = "bank_data.json";

    public List<Account> LoadAccounts()
    {
        if (!File.Exists(_filePath))
        {
            return new List<Account>
                {
                    new Account(1001, 5000.0, "1234"),
                    new Account(1002, 12000.0, "5678")
                };
        }

        string json = File.ReadAllText(_filePath);

        // BULLETPROOF LOAD: Forcing the direct use of the generated ListAccount property
        return JsonSerializer.Deserialize(json, AccountJsonContext.Default.ListAccount)
               ?? new List<Account>();
    }

    public void SaveAccounts(List<Account> accounts)
    {
        // BULLETPROOF SAVE: Forcing the direct use of the generated ListAccount property
        // (We are removing WriteIndented to use this strict, reflection-free overload)
        string json = JsonSerializer.Serialize(accounts, AccountJsonContext.Default.ListAccount);

        File.WriteAllText(_filePath, json);
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Booting up ATM System...");

        // 1. Initialize the File Database
        FileDatabase database = new FileDatabase();

        // 2. Load the accounts from the hard drive (Creates default data if file is missing)
        List<Account> actualDatabase = database.LoadAccounts();

        // 3. Setup the physical ATM hardware (Starting with 100 notes of 100, 20 notes of 500)
        CashInventory atmHardware = new CashInventory(100, 20);

        // 4. Setup the backend processing service
        TransactionService backendService = new TransactionService(atmHardware);

        // 5. Setup the Console User Interface and pass in the backend service
        ATMConsoleUI atmInterface = new ATMConsoleUI(backendService);

        Console.Clear(); // Clears the booting messages for a clean screen

        // 6. Run the infinite loop so the ATM stays on 24/7
        while (true)
        {
            // Run the login and transaction menus for a user
            atmInterface.StartSession(actualDatabase);

            // IMPORTANT: The moment the user logs out, save the updated balances to the JSON file!
            database.SaveAccounts(actualDatabase);

            Console.WriteLine("\n[System: User data saved successfully to bank_data.json]");
            Console.WriteLine("\n========================================================\n");
        }
    }
}
public static class SecureConsole
{
    // Reads input from the user but aborts if they take too long
    public static string ReadLineWithTimeout(int timeoutSeconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(timeoutSeconds);
        string input = "";

        while (DateTime.Now < endTime)
        {
            // Check if the user pressed a key
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                // If they press Enter, return the final string
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return input;
                }
                // Handle Backspace
                else if (keyInfo.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input = input.Substring(0, input.Length - 1);
                    Console.Write("\b \b"); // Erase character from console visually
                }
                // Handle normal typing
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    input += keyInfo.KeyChar;
                    Console.Write(keyInfo.KeyChar);
                }

                // Reset the timeout clock every time they press a key!
                endTime = DateTime.Now.AddSeconds(timeoutSeconds);
            }

            // Pause for 50 milliseconds to stop the CPU from running at 100%
            Thread.Sleep(50);
        }

        // If the while loop finishes, it means the clock ran out
        throw new TimeoutException("Session timed out due to inactivity.");
    }
}

