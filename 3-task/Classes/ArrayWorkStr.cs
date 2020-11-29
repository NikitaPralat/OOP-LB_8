using System;
using System.Collections.Generic;
using System.Text;

namespace _3_task.Classes
{
    class ArrayWorkStr : ArrayWork
    {
        private string[] strArray;
        public ArrayWorkStr(int size) : base(size)
        {
            strArray = new string[size];
        }
        public new string this[int index]
        {
            get
            {
                if (index < ArraySize)
                {
                    return strArray[index];
                }
                return "0";
            }
            set
            {
                if (index < ArraySize)
                    strArray[index] = value;
            }
        }
    }
}
