namespace PartII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a new rect
            var rect = new Rectangle(2, 3);

            //Set Rect Location
            rect.SetLocation(1, 2);
            rect.SetLocation(2, 3);

            //output location of rect
            Console.WriteLine(rect.ToString());
            
            //print rect area and perimeter
            Console.WriteLine(rect.Area());
            Console.WriteLine(rect.Perimeter());

            //create a new circle
            var circ = new Circle(4);

            //set circle location
            circ.SetLocation(10, 20);
            circ.SetLocation(20, 30);

            //print circle location
            Console.WriteLine(circ.ToString());

            //print cirle area and perimeter
            Console.WriteLine(circ.Area());
            Console.WriteLine(circ.Perimeter());

        }
    }
}
