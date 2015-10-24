using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CshorpStudy
{
    class 属性的访问修饰符
    {
        private string _name = string.Empty;
        public string Name
        {
            protected get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }

    }
}
