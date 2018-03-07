using FedexApp.MealAndGreeting;
using NUnit.Framework;

namespace FedexAppTests.MealAndGreeting
{
    public class MealTests
    {
        [TestCase("morning","Breakfast")]
        public void GetMeal_should_return_the_right_meal_based_on_time(string time, string expectedMeal)
        {
            // Arrange
            var classUnderTest = new Meal();

            // Act
            var actualMeal = classUnderTest.GetMeal(time);

            // Assert
            Assert.AreEqual(actualMeal, expectedMeal);
        }
    }
}