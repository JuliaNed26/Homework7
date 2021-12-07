using System;

namespace Liskov_Substitution_Principle
{
    interface IFigure
    {
        int GetArea();
    }
    class Rectangle:IFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }
    //квадрат наслідується від прямокутника!!!
    class Square : IFigure
    {
        public int Side { get; set; }

        public int GetArea()
        {
            return Side * Side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Rectangle();
            figure.Width = 5;
            figure.Height = 10;
            Console.WriteLine("rectangle = " + figure.GetRectangleArea());
            figure = new Square();
            figure.Side = 5;
            Console.WriteLine("square = " + figure.GetRectangleArea());
            Console.ReadKey();
        }
    }
    
}
