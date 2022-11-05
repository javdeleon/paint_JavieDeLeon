using System;

namespace paint_JavieDeLeon
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var IPensilTool = new PencilTool();
            IPensilTool.MouseUp();
            IPensilTool.MouseOver();
            var Erase = new Square();
            Erase.MouseOver();
            Console.ReadLine();
        }
    }

    public interface IPaintTool
    {
        void MouseUp();
        void MouseOver();
    }

    public class PencilTool : IPaintTool
    {
        public void MouseOver()
        {
            Console.WriteLine("Show pencil icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line.");
        }
    }

    public class Square : IPaintTool
    {
        public void MouseOver()
        {
            Console.WriteLine("Show square icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a square.");
        }
    }

    public class Eraser : IPaintTool
    {
        public void MouseOver()
        {
            Console.WriteLine("Show an eraser icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase the selected object.");
        }
    }

}
