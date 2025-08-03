class Program{

    static void Main(){

        Shape circ = new Circle(5.0);
        Console.WriteLine("Circle's area : " + circ.GetArea());

        Shape rect = new Rectangle(5.0,5.0);
        Console.WriteLine("Rectangle's area : " + rect.GetArea());

    }
}