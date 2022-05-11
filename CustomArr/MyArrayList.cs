using System;
using System.Collections.Generic;
using System.Text;

namespace CustomArr
{
    class MyArrayList<T>
    {
        private IList<T> list;

        public MyArrayList(IList<T> list)
        {
            this.list = list;
        }
        public MyArrayList()
        {
        }

        public int size()
        {
            return list.Count;
        }

       
        public T get(int index)
        {
           for(int i = 0; i < list.Count; i++)
           {
                if (i == index)
                    return list[i];
           }
           return list[index];
        }
        public void add(T value)
        {
            if (isEmpty())
            {
                list = new T[1];
                list[0] = value; 
            }
            else
            {
                IList<T> newList = new T[list.Count + 1];
                for (int i = 0; i < list.Count; i++)
                {
                    newList[i] = list[i];
                }
                newList[list.Count] = value;
                list = newList;
            }
        }
        public void remove(int index)
        {
            IList<T> newList = new T[list.Count - 1];
            if (index < 0 && index > list.Count - 1) 
            {
                Console.WriteLine("Can not index");
                return;
            }   
            if(isEmpty())
            {
                Console.WriteLine("List empty");
                return;
            }    
            for (int i = 0; i < list.Count - 1; i++)
            {
                if(i >= index)
                {
                    list[i] = list[i + 1];
                }
                newList[i] = list[i];
            }
            list = newList;
        }

        

        public IList<T> getList()
        {
            return list;
        }

        public void setList(IList<T> newList)
        {
            list = newList;
        }

        public Boolean isEmpty()
        {
            if (list == null)
                return true;
            if (list.Count == 0)
                return true;
            return false;
        }

        public void println()
        {
            if(isEmpty())
            {
                Console.WriteLine("List empty");
                return;
            }
            foreach(T value in list)
            {
                Console.WriteLine(value);
            }
        }
        
    }
}
