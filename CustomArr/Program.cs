using System;


namespace CustomArr
{
  
    class Program
    {
        class Colection1 : CustomColection<Person>
        {
            public bool findAllColection(Person item)
            {
                if (item.Age >= 30)
                    return true;
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            MyArrayList<Person> people = new MyArrayList<Person>(getPeople());
            MyArrayList<Person> findPeople = people.findAll(new Colection1());
            Console.WriteLine("Mảng sau khi tim kiếm: ");
            foreach(Person person in findPeople.getList())
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("Test mảng 2 chiều: ");
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 4, 5, 6 };
            int[] arr3 = new int[] { 7, 8, 9 };

            MyArrayList<MyArrayList<int>> number = new MyArrayList<MyArrayList<int>>();
            number.add(new MyArrayList<int>(arr1));
            number.add(new MyArrayList<int>(arr2));
            number.add(new MyArrayList<int>(arr3));

            for (int i = 0; i < number.size(); i++)
            {
                for (int j = 0; j < number.get(i).size(); j++)
                {
                    int value = number.get(i).get(j);
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }
        }
       
        static Person[] getPeople()
        {
            return new Person[]
            {
                new Person("Antonio", 20, Gender.MALE),
                new Person("Alina Smith", 33, Gender.FEMALE),
                new Person("Helen White", 20, Gender.FEMALE),
                new Person("Alex Boz", 14, Gender.MALE),
                new Person("Jamie Goa", 99, Gender.MALE),
                new Person("Anna Cook", 200, Gender.FEMALE),
                new Person("Zelda Brown", 120, Gender.FEMALE)
            };
        }


    }
}
