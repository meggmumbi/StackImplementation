using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackImplementation
{
    class CStack
    {

        private int p_index;
        private ArrayList list;

        public CStack()
        {
            list = new ArrayList();
            p_index = -1;
        }

        public void Push(object item)
        {
            list.Add(item);
            p_index++;
        }
        public object Pop()
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;

        }
        public object Peek()
        {
            //object obj = list[p_index];
            //return obj;
            return list[p_index];

        }
        public void Clear()
        {
            list.Clear();
            p_index = -1;
        }
        public int Count
        {
            get
            {

                return list.Count;
            }

        }
    }
}
