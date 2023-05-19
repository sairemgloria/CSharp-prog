using System;

namespace NO21_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 21 : Inheritance */
            Console.WriteLine("Topic NO 21 : Inheritance");

            /* Person's output */
            Console.WriteLine("Person Information");
            Person person = new Person("Brimstone","Male",30);
            person.introduceSelf(); // this is for person class object method
            Console.WriteLine();

            /* Toddler's output */
            Console.WriteLine("Toddler Information");
            Toddler toddler = new Toddler("Jett","Female",28,"Dash");
            toddler.introduceSelf(); // this is for person class object method
            toddler.toddlerPower(); // this is for toddler class object method
            Console.WriteLine();

            /* Child's output */
            Console.WriteLine("Child Information");
            Child child = new Child("Sage","Female",26,"Heal","Plant Spike");
            child.introduceSelf(); // this is for person class object method
            child.toddlerPower(); // this is for toddler class object method
            child.sageHobby(); // this is for child class object method
        }
    }

    // Person Class
    class Person
    {
        // person attribute(s)
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }

        // person constructor
        public Person(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        // person object methods
        public void introduceSelf()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Sex  : " + sex);
            Console.WriteLine("Age  : " + age);
        }
    }

    // Toddler Class : Interited Person
    class Toddler : Person
    {
        // Toddler encapsulated attribute(s)
        private string power;

        // Toddler getter and setter
        public string Power
        {
            get { return power; }
            set { power = value; }
        }

        // toddler constructor
        public Toddler(string name, string sex, int age, string Power) : base(name, sex, age)
        {
            this.Power = Power;
        }

        // Toddler object methods
        public void toddlerPower()
        {
            Console.WriteLine("Ability : " + power);
        }
    }

    class Child : Toddler
    {
        /* Child Attribute(s) */
        public string hobby { get; set; }

        /* Child Constructor */
        public Child(string name, string sex, int age, string Power, string hobby) : base(name, sex, age, Power)
        {
            this.hobby = hobby;
        }

        /* Child object methods */
        public void sageHobby()
        {
            Console.WriteLine("Hobby : " + hobby);
        }
    }
}