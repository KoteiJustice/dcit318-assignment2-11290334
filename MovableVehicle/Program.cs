using System;

public class Program
{
    public static void Main(){
        IMovable car = new Car();
        IMovable bike = new Bicycle();

        car.Move();
        bike.Move();
    }
    
}