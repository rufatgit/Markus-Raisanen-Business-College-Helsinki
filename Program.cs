/*
EXERCISE 5-4: Constructor Overload
The exercise template has a Product class, which represents a product in a shop. Every product has a name, location and weight.

Add the following three constructors to the Product class.

public Product(string name) creates a product with the given name. Its location is set to “shelf” and its weight is set to 1.
public Product(string name, string location) creates a product with the given name and the given location. Its weight is set to 1.
public Product(string name, int weight) creates a product with the given name and the given weight. Its location is set to “warehouse”.
You can test your program with the following code.
*/



namespace ex_4_Constructor_overload
{
    public class Product
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Weight { get; set; }


         
        public Product(string name) 
        {
            Name = name;
            Location = "shelf";
            Weight = 1;
            //Console.WriteLine($"{name} (1 kg) can be found from the shelf.");
        }

        public Product(string name, int weight)
        {
            Name = name;
            Location = "warehouse";
            Weight = weight;

            //Console.WriteLine($"{name} ({Weight} kg) can be found from the warehouse.");

        }

        public Product(string name, string location)
        {
            Name = name;
            Location = location;
            Weight = 1;
            //Console.WriteLine($"{Name} (1 kg) can be found from the {location}.");
        }


        public override string ToString()
        {
            return $"{Name} ({Weight} kg) can be found from the {Location}";
        }



    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Product tape = new Product("Tape measure");
            Product plaster = new Product("Plaster", "Home imprevement section");
            Product tyre = new Product("Tyre", 5);

            Console.WriteLine(tape);
            Console.WriteLine(plaster);
            Console.WriteLine(tyre);


        }
    }
}





