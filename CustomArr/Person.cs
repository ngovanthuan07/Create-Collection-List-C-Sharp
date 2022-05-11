using System;
using System.Collections.Generic;
using System.Text;

namespace CustomArr
{
    class Person
    {
        private String name;
        private int age;
        private Gender gender;

        public Person(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal Gender Gender { get => gender; }

        public override string ToString()
        {
            return $"Person: name: {name} , age: {age}  gender: {gender}";
        }
    }
}
