namespace Classes_Dodge_Tuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            The_Welcome welcome = new The_Welcome();// Creates the "The_Welcome" Object 
            welcome.Welcome(); // calls the welcome method from The_Welcome odject 

            Console.WriteLine("What is your name User ? ");// Asks the user for there name 
            string userName = Console.ReadLine();// Stores the name in userName 

            welcome.Hello(userName); // Calls the Hello method and adds the user name to the argunment to it 
        }
    }
}
