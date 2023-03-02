namespace OOPS
{
    public class Abstraction
    {

    }
    public abstract class UserAbstract
    {
        public abstract string Name { get; set; }
        public string Email { get; set; } = string.Empty;

        public abstract void SetUser(string name, string email);
        public void DisplayUser()
        {
            Console.WriteLine($"Name: {Name}, Email: {Email}");
        }
    }
    public class UserOG : UserAbstract
    {
        public override string Name { get; set; } = string.Empty;
        public override void SetUser(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
