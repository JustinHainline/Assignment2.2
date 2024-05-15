namespace Assignment2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shapeSquare = new Shape();
            Shape shapeCircle = new Shape();
            Shape shapeRectangle = new Shape();

            string readResult;
            do
            {
                Console.WriteLine("Please enter your choice of formula.");
                Console.WriteLine();
                Console.WriteLine("Enter S for Square.");
                Console.WriteLine("Enter C for Circle.");
                Console.WriteLine("Enter R for Rectangle.");
                Console.WriteLine("Enter X to Exit.");

                readResult = Console.ReadLine();

                switch (readResult)
                {
                    case "S":
                    case "s":
                        Console.WriteLine("You picked a square. Enter length of the side: ");
                        double lengthOfSide = Convert.ToDouble(Console.ReadLine());
                        Square mySquare = new Square();
                        mySquare.CalculateArea(lengthOfSide);
                        Console.WriteLine();
                        break;
                    case "C":
                    case "c":
                        Console.WriteLine("You picked a circle. Enter radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle myCircle = new Circle();
                        myCircle.CalculateArea(radius);
                        Console.WriteLine();
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("Enter width of rectangle");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter height of rectangle");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Rectangle myRectangle = new Rectangle();
                        myRectangle.CalculateArea(width, height);
                        Console.WriteLine();
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("You want to exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            while (readResult != "x" && readResult != "X");
            Console.WriteLine();
        }
        
    }
    

    public enum ColorValues { Red, White, Blue }


    public class Shape
    {
        public string ShapeId { get; set; }
        public string ShapeName { get; set; }
        public string ShapeDescription { get; set; }
        public ColorValues ShapeColor { get; set; }
        public virtual void CalculateArea()
        {
            Console.WriteLine("This shape has an area. ");
        }
    }

    public class Square : Shape
    {
        public double LengthOfSide { get; set; }

        public void CalculateArea(double lengthOfSide)
        {
            Console.WriteLine("The area of the square is : " + Math.Pow(lengthOfSide, 2));
        }

    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public void CalculateArea(double radius)
        {
            Console.WriteLine("The area of the circle is : " + Math.PI * Math.Pow(radius, 2));
        }

    }
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public void CalculateArea(double width, double height) 
        {
            Console.WriteLine("The area of the rectangle is: " + width * height);
        }
    }
    
}


