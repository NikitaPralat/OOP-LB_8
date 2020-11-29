using System;
using System.Collections.Generic;
using System.Text;

namespace _3_task.Classes
{
    class ArrayWork
    {
        private int[] array;
        public int ArraySize { get; set; }
        public ArrayWork(int size)
        {
            ArraySize = size;
            array = new int[size];
        }
        public int this[int index]
        {
            get
            {
                if (index < ArraySize)
                {
                    return array[index];
                }
                return 0;
            }
            set
            {
                if (index < ArraySize)
                    array[index] = value;
            }
        }
    }
}
