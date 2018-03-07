using System;

namespace FedexApp.MealAndGreeting
{
    public class Greeter
    {
        public string Greet()
        {
            if (DateTime.Now.Hour < 12)
            {
                return "Good Morning!";
            }
            else
            {
                return "Good Afternoon!";
            }
        }
    }
}