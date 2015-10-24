using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CshorpStudy
{
    class 构造函数
    {
        MyNumber myNumber = new MyNumber(2);
    }
    public class MyNumber
    {
        private int number;
        public MyNumber(int number) // another over△ oad
        {
            this.number = number;
        }
    }
}
