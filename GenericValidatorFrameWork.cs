/*
1️⃣3️⃣ Generic Validator Framework

Create a generic interface IValidator<T>.

Requirements:

Method bool Validate(T value)
Implement:
Email validator
Password validator
*/
interface IValidator<T>
{
    bool Validate(T value);


}
class Email<T> : IValidator<T>
{
    private bool IsTrue = false;
    public bool Validate(T value)
    {
        IsTrue = true;
        Console.WriteLine("validating email:" + value);
        return IsTrue;

    }
}
class Password<T> : IValidator<T>
{
    private bool IsTrue = false;
    public bool Validate(T value)
    {
        IsTrue = true;
        Console.WriteLine("validating email :" + value);
        return IsTrue;
    }

}
class GenericValidatorFrameWork
{

    static void Main()
    {
        Email<string> email = new Email<string>();
        email.Validate("nitinrao9213@gmail.com");
        Password<int> password = new Password<int>();
        password.Validate(1213);
    }
}