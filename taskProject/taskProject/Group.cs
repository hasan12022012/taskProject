using System;
using System.Collections.Generic;
using System.Text;

namespace taskProject
{
    internal class Group
    {
        string _no;
        public double AvgPoint;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if(value.Length==4 && char.IsUpper(value[0]))
                {
                    _no = value;
                }
            }
        }
    }
}
