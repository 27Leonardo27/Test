using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_proj
{
    class Student   // Создание собственного класса
    {

        public Student()
        {
            
        }
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;           
        }

        public Student(Guid id)
        {
            this.id = id;
        }

        public Student(Student student)
        {
            name = student.name;
            age = student.age;
            id = student.id;
        }

        private string name;   // Поля класса
        private int age;
        private Guid id;

        public void Print(string name, int age)   // Метод класса
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(id);
        }

        public void Print(string name, int age, Guid id)
        {
            Console.WriteLine($"{name}, {age}, {id}");
        }

        public void Print()   
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(id);
        }

    }

}

