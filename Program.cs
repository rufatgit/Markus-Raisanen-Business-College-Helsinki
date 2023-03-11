

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




