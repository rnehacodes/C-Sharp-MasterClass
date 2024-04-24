namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cube cube1 = new Cube(4, "Little cube");
            Console.WriteLine(cube1.Volume());
            cube1.GetInfo();

            Console.WriteLine();

            Sphere sphere1 = new Sphere("spehere1", 5);
            Console.WriteLine(sphere1.Volume());
            sphere1.GetInfo();

            Console.WriteLine();
            Console.WriteLine("Shape array:");

            Shape[] shapes = new Shape[] { cube1, sphere1};
            foreach(Shape shape in shapes)
            {
                Console.WriteLine();
                shape.GetInfo();

                Cube testcube = shape as Cube;
                if(testcube != null)
                {
                    Console.WriteLine("This shape is a cube");
                }
                else
                {
                    Console.WriteLine("This shape is not a cube.");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("Yes, this shape is a cube.");
                }
                Console.WriteLine();
            }

            object cube3 = new Cube(4, "cube3");
            Cube cube4 = (Cube)cube3;
            cube4.GetInfo();

            Console.WriteLine();

            //object cube5 = new Sphere("sphere5", 5);
            //Cube cube6 = (Cube)cube5;
            //cube6.GetInfo();
        }
    }
}
