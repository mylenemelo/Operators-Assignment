using System; // Import the System namespace to use basic classes like Console

namespace OperatorsAssignment // Define the namespace for this project
{
    class Program // Main class that runs the application
    {
        static void Main(string[] args) // Entry point of the console application
        {
            // Create a new instance (object) of the Employee class for the first employee
            Employee employee1 = new Employee();

            // Assign a unique ID to employee1
            employee1.Id = 1;

            // Assign the first name of employee1
            employee1.FirstName = "Peter";

            // Assign the last name of employee1
            employee1.LastName = "Collins";

            // Create a second instance (object) of the Employee class
            Employee employee2 = new Employee();

            // Assign an ID to employee2 (same ID as employee1 to test equality)
            employee2.Id = 1;

            // Assign the first name of employee2
            employee2.FirstName = "Janet";

            // Assign the last name of employee2
            employee2.LastName = "Spencer";

            // Compare the two Employee objects using the overloaded == operator
            // This will return true if their Id values are the same
            bool resultEqual = employee1 == employee2;

            // Display the result of the equality comparison to the console
            Console.WriteLine("Are employees equal? " + resultEqual);

            // Compare the two Employee objects using the overloaded != operator
            // This will return true if their Id values are different
            bool resultNotEqual = employee1 != employee2;

            // Display the result of the inequality comparison to the console
            Console.WriteLine("Are employees not equal? " + resultNotEqual);

            // Wait for the user to press Enter before closing the program
            // This prevents the console window from closing immediately
            Console.ReadLine();
        }
    }
}