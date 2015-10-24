using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CShorpStudy.Control
{
    class 抗变与协变
    {
    }
    public class Shape
    {
        public double Width{get;set;}
        public double Heigh{get;set;}
        public override string ToString()
        {
 	       return string.Format("Width:{0},Heigh:{1}",this.Width.ToString(),this.Heigh.ToString());
        }
    }
    public class Rectangle : Shape
    {
        private int a;
    }
    public interface IDisplay<in T>
    {
        void Show(T Item);
    }
    public class ShapeDisplay : IDisplay<Shape>
    {
        public void Show(Shape s)
        {
            Console.WriteLine("{0} Width:{1},Heigh:{2}", s.GetType().Name, s.Width, s.Heigh);
        }
    }

}
