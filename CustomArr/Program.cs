using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomArr
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            MyArrayList<Person> people = new MyArrayList<Person>(getPeople());

            Console.WriteLine("In ra list person");
            people.println();


            Console.WriteLine("Xoá phần tử thứ 2: ");
            people.remove(2);
            people.println();

            Console.WriteLine("Thêm một phần tử: ");
            people.add(new Person("Hello World", 78, Gender.MALE));
            people.println();
            int index = findMaxInArr(people);
            Console.WriteLine($"Người có tuổi lớn nhât: {people.get(index)}");


            Console.WriteLine("Test mảng 2 chiều: ");
            int[] arr1 = new int[] { 1, 2, 3};
            int[] arr2 = new int[] { 4, 5, 6};
            int[] arr3 = new int[] { 7, 8, 9};

            MyArrayList<MyArrayList<int>> number = new MyArrayList<MyArrayList<int>>();
            number.add(new MyArrayList<int>(arr1));
            number.add(new MyArrayList<int>(arr2));
            number.add(new MyArrayList<int>(arr3));

/*            foreach(MyArrayList<int> myArr in number.getList())
            {
                foreach(int i in myArr.getList())
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }*/

            for(int i = 0; i < number.size(); i++)
            {
                for(int j = 0; j < number.get(i).size(); j++)
                {
                    int value = number.get(i).get(j);
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }
        }
        static int findMaxInArr(MyArrayList<Person> people)
        {
            int max = people.get(0).Age;
            int index = 0;
            for (int i = 0; i < people.size(); i++)
            {
                Person p = people.get(i);
                if (p.Age >= max)
                {
                    max = p.Age;
                    index = i;
                }
            }
            return index;
        }
        static Person[] getPeople()
        {
            return new Person[]
            {
                new Person("Antonio", 20, Gender.MALE),
                new Person("Alina Smith", 33, Gender.FEMALE),
                new Person("Helen White", 57, Gender.FEMALE),
                new Person("Alex Boz", 14, Gender.MALE),
                new Person("Jamie Goa", 99, Gender.MALE),
                new Person("Anna Cook", 200, Gender.FEMALE),
                new Person("Zelda Brown", 120, Gender.FEMALE)
            };
        }


    }
}
