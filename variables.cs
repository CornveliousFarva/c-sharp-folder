// Basic concept: variables are stored in C# in specific ways
// Strings are stored as "string"
// Whole numbers are stored as "int"
// Decimal numbers are stored as "doubles"

using system;

namespace form
{
    class program
    {
        static void Main(string[]args)
        {
            // Created variables
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            // The bool variable is for things that are true or false
            bool spayed = true;

            // Print the variables
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);     
        }
    }
}