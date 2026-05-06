using System;

namespace OperatorsAssignment
{
    // This class represents an Employee
    public class Employee
    {
        // Property for Employee ID
        public int Id { get; set; }

        // Property for First Name
        public string FirstName { get; set; }

        // Property for Last Name
        public string LastName { get; set; }

        // Overload the == operator to compare Employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are the same reference, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, return false
            if (emp1 is null || emp2 is null)
                return false;

            // Compare Id values
            return emp1.Id == emp2.Id;
        }

        // Overload != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals method
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
            {
                return this.Id == emp.Id;
            }
            return false;
        }

        // Override GetHashCode method
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
