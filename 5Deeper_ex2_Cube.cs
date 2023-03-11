/*
EXERCISE 5-2: Cube
Create a Cube class that represents a cube.

Create a public Cube (int edgeLength) constructor for the class that takes the length of the cube’s edge as its parameter.
Make a public int Volume() method for the cube, which calculates and returns the cube’s volume. The volume of the cube is 
calculated with the formula edgeLength * edgeLength * edgeLength.
Moreover make a public override string ToString() method for the cube, which returns a string representation of it. 
The string representation should take the form “The length of the edge is l and the volume v”. 
Where l is the length and v the volume. Both the length and volume must be represented as integers.

*/



namespace ex_3_Cube
{
    public class Cube
    {
        public double Edge_Length { get; set; }


        public Cube(double edge_length)
        {
            Edge_Length = edge_length;
        }


        public double Volume()
        {
            return Math.Pow(Edge_Length, 3);
        }


        public override string ToString()
        {
            return $"The length of the edge is {Edge_Length} and the Volume {Volume()}";
        }




    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Cube cube = new Cube(9);

            Console.WriteLine("Enter edge of the cube:");
            Console.WriteLine(cube.ToString());

        }
    }
}




