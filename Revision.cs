/*
Here are some good beginner-to-intermediate **C# coding questions without Data Structures & Algorithms focus** — more about logic, OOP, strings, files, classes, and real-world coding.




---

## OOP-Based Questions

21. Create a `Student` class with properties and methods.
22. Create a `BankAccount` class with deposit and withdraw methods.
23. Demonstrate inheritance using `Vehicle → Car`.
24. Demonstrate method overloading.
25. Demonstrate method overriding.
26. Create abstract class example.
27. Create interface example with multiple implementations.
28. Build simple employee salary calculator using classes.
29. Create constructor chaining example.
30. Implement encapsulation with private fields.

---

## Array Questions (simple, not DSA-heavy)

31. Find maximum element in array.
32. Calculate average of array elements.
33. Count even and odd numbers in array.
34. Copy one array into another.
35. Sort array using built-in methods.
36. Merge two arrays.
37. Remove duplicates from array.
38. Search element in array.
39. Find second largest number.
40. Print array in reverse order.

---

## File Handling Questions

41. Read data from a text file.
42. Write user input into a file.
43. Count lines in a file.
44. Copy contents from one file to another.
45. Append text into existing file.

---

## Exception Handling

46. Handle divide-by-zero exception.
47. Create custom exception.
48. Use `try-catch-finally`.
49. Validate age using exception handling.
50. Handle file-not-found exception.

---

## Console Mini Projects

51. Simple calculator.
52. ATM simulation.
53. Student grade management system.
54. Library management console app.
55. Login/signup system.
56. Quiz application.
57. Currency converter.
58. Billing system.
59. To-do list manager.
60. Movie ticket booking console app.

---

## Intermediate Real-World Questions

61. Validate email format.
62. Password strength checker.
63. Generate random OTP.
64. Create stopwatch using `DateTime`.
65. Find age from DOB.
66. Simple inventory management.
67. Serialize object to JSON.
68. Deserialize JSON data.
69. Consume simple REST API using `HttpClient`.
70. Create LINQ queries for filtering data.

---

## LINQ Practice

71. Find employees with salary > 50k.
72. Group students by grade.
73. Sort list by name.
74. Find duplicate numbers using LINQ.
75. Count occurrences using LINQ.

If you want, I can also give:

* **Interview-level C# questions**
* **C# programs with answers**
* **C# mini projects**
* **C# OOP-only questions**
* **Entity Framework questions**
* **ASP.NET questions**
* **MCQs for practice**
* **Company-style coding rounds**
Here are some **company-style C# coding round questions** commonly asked in fresher and junior developer interviews at companies like Infosys, TCS, Wipro, Accenture, and product startups.

These focus more on:

* clean coding
* logic building
* OOP
* strings
* arrays
* real-world scenarios
  and less on advanced DSA.

---

# Round 1 — Easy Company Questions

### 1. Employee Bonus Calculator

Input employee salary and years of experience.

Rules:

* > 5 years → 20% bonus
* 3–5 years → 10%
* <3 years → 5%

Print final salary.

---

### 2. Password Validator

Check whether password:

* has uppercase
* lowercase
* number
* special character
* minimum 8 chars

Return “Strong” or “Weak”.

---

### 3. Billing System

Input:

* product price
* quantity
* GST %

Generate final bill.

---

### 4. ATM Machine Simulation

Options:

* Withdraw
* Deposit
* Check Balance
* Exit

Use loop + switch case.

---

### 5. Student Grade System

Input marks of 5 subjects.
Calculate:

* total
* percentage
* grade

---

# Round 2 — Moderate Coding Questions

### 6. Remove Duplicate Words

Input:

```text
"hello hi hello world hi"
```

Output:

```text
hello hi world
```

---

### 7. Most Frequent Character

Input:

```text
success
```

Output:

```text
s = 3
```

---

### 8. Login System

Store username/password in variables.

Allow only 3 login attempts.

---

### 9. Online Shopping Cart

Create:

* Product class
* Cart class

Features:

* Add item
* Remove item
* Total price

---

### 10. Movie Ticket Booking

Features:

* select seats
* calculate ticket amount
* age discount
* booking confirmation

---

# Round 3 — OOP-Focused Company Questions

### 11. Banking Application

Create:

* Account class
* SavingsAccount
* CurrentAccount

Use:

* inheritance
* overriding
* encapsulation

---

### 12. Employee Management System

Operations:

* Add employee
* Display employees
* Search employee by ID
* Update salary

Use List<Employee>.

---

### 13. Shape Area Calculator

Use abstract class/interface.

Shapes:

* Circle
* Rectangle
* Triangle

Calculate area dynamically.

---

### 14. Cab Fare Calculator

Different vehicle types:

* Mini
* Sedan
* SUV

Different fare logic using polymorphism.

---

### 15. Hospital Management

Classes:

* Doctor
* Patient
* Appointment

Basic CRUD operations.

---

# Round 4 — Real Interview Pattern

## Question Pattern Example

### Problem:

A company stores employee names in a string array.
Find:

* duplicate names
* count frequency
* sort alphabetically

### Skills Tested:

* loops
* arrays
* LINQ
* clean coding

---

# Frequently Asked Coding Concepts

Companies often test:

* loops
* conditions
* switch case
* functions
* classes & objects
* inheritance
* exception handling
* file handling
* LINQ basics
* string manipulation
* collections (`List`, `Dictionary`)

---

# Very Common Interview Programs

These are repeated a lot:

| Question            | Difficulty |
| ------------------- | ---------- |
| Palindrome          | Easy       |
| Armstrong number    | Easy       |
| Anagram             | Medium     |
| Reverse string      | Easy       |
| Employee CRUD       | Medium     |
| ATM simulation      | Medium     |
| Login validation    | Easy       |
| File read/write     | Medium     |
| LINQ filtering      | Medium     |
| OOP design question | Medium     |

---

# Pro Tip for Company Rounds

Practice writing:

* proper methods
* meaningful variable names
* exception handling
* modular code

Interviewers often care more about:

* readability
* logic
* confidence
  than ultra-advanced algorithms for entry-level C# roles.

If you want, I can also give:

* **actual company coding questions with solutions**
* **timed mock coding round**
* **TCS/Infosys/Wipro-specific patterns**
* **C# interview questions with answers**
* **30-minute coding test set**
* **advanced product-company questions**

*/
using System.Security.AccessControl;

class Revision
{
  /*
  ## String-Based Questions

13. Check if two strings are anagrams.
14. Remove duplicate characters from a string.
15. Find frequency of each character in a string.
16. Convert first letter of every word to uppercase.
17. Check whether a string is palindrome.
18. Count words in a sentence.
19. Replace spaces with special character (`-` or `_`).
20. Find longest word in a sentence.


  */
  static void Main()
  {
    // string s1 = "nitin";
    // string s2 = "nniit";
    // //
    // char[] ch1 = s1.ToCharArray();
    // char[] ch2 = s2.ToCharArray();
    // if (s1.Length != s2.Length)
    // {
    //   Console.WriteLine("not a anagram");
    // }
    // Array.Sort(ch1);
    // Array.Sort(ch2);

    // if (new string(ch1) == new string(ch2))
    // {
    //   Console.WriteLine("Both are Anagrams");
    // }
    string name = nitkn;
    for (int i = 0; i < name.Length; i++)
    {
      char[] ch = name.ToCharArray();


    }

  }







}








