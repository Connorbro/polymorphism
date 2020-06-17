using System;

namespace polymorphism
{
    class UserInput
    {
        public void ShowMeUserInput(int userData)
        {
            Console.WriteLine($"The user inputted an integer: {userData}");
        }
        public void ShowMeUserInput(string userData)
        {
            Console.WriteLine($"The user inputted a string: {userData}");
        }
        public void ShowMeUserInput(double userData, double anotherNumber)
        {
            Console.WriteLine($"The user inputted 2 doubles: {userData} & {anotherNumber} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserInput newUser = new UserInput();
            newUser.ShowMeUserInput(123);
            newUser.ShowMeUserInput("Connor");
            newUser.ShowMeUserInput("Connor");
            newUser.ShowMeUserInput(123.456, 22.3);
        }
    }
}
