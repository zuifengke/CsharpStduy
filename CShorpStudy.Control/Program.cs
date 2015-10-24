using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CShorpStudy.Control
{
    class Program
    {
        static void Main(string[] args)
        {
             Rectangle[] Rectangles = new Rectangle[3]
            {
                new Rectangle { Heigh=2, Width=5},
                new Rectangle { Heigh=2, Width=5},
                new Rectangle { Heigh=2, Width=5}
            };
            //Class1.Example();
            //Console.WriteLine("User-Perferences:BackColor is:" + UserPreferences.BackColor.ToString() + "");
            //Console.ReadLine();
            IDisplay<Shape> shapeDisplay = new ShapeDisplay();
            IDisplay<Rectangle> rectangleDisplay = shapeDisplay;
            rectangleDisplay.Show(Rectangles[0]);

        }
    }
}
