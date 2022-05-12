using System;
using System.Collections.Generic;
using System.Text;

namespace CustomArr
{
    class MyArrayList<T>
    {
        private T[] list;

        public MyArrayList(T[] list)
        {
            this.list = list;
        }
        public MyArrayList()
        {
        }

        public int size()
        {
            return list.Length;
        }

       
        public T get(int index)
        {
           for(int i = 0; i < list.Length; i++)
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
                T[] newList = new T[list.Length + 1];
                for (int i = 0; i < list.Length; i++)
                {
                    newList[i] = list[i];
                }
                newList[list.Length] = value;
                list = newList;
            }
        }
        public void remove(int index)
        {
            T[] newList = new T[list.Length - 1];
            if (index < 0 && index > list.Length - 1) 
            {
                Console.WriteLine("Can not index");
                return;
            }   
            if(isEmpty())
            {
                Console.WriteLine("List empty");
                return;
            }    
            for (int i = 0; i < list.Length - 1; i++)
            {
                if(i >= index)
                {
                    list[i] = list[i + 1];
                }
                newList[i] = list[i];
            }
            list = newList;
        }

        

        public T[] getList()
        {
            return list;
        }

        public void setList(T[] newList)
        {
            list = newList;
        }

        public Boolean isEmpty()
        {
            if (list == null)
                return true;
            if (list.Length == 0)
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

        private CustomColection<T> customCollection;
        
        public void setCustomCollection(CustomColection<T> customCollection)
        {
            this.customCollection = customCollection;
        }

        public MyArrayList<T> findAll(CustomColection<T> customColection)
        {
            setCustomCollection(customColection);
            MyArrayList<T> newList = new MyArrayList<T>();
            foreach(T item in list)
            {
                bool check = this.customCollection.findAllColection(item);
                if(check == true)
                {
                    newList.add(item);
                }
            }
            return newList;
        }

    }
}
