namespace FedexApp.MealAndGreeting
{
    public class Meal
    {
        public string GetMeal(string time)
        {
            if (time?.ToLower() == "morning")
            {
                return "Breakfast";
            }
            else if (time?.ToLower() == "noon")
            {
                return "Lunch";
            }
            else if (time?.ToLower() == "evening")
            {
                return "Dinner";
            }
            else
            {
                return "Stay hugry!";
            }
        }
    }
}