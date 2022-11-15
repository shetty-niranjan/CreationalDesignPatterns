namespace CreationalDesignPattern.Prototype
{
    internal class Person : ICloneable
    {
        public Person(string name, string surname, Department department, int salary, int premium)
        {
            Name = name;
            Surname = surname;
            Department = department;
            Salary = salary;
            Premium = premium;
            Console.WriteLine("Person object created.");
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public Department Department { get; set; }
        public int Salary { get; set; }
        public int Premium { get; set; }

        public void ToString()
        {
            Console.WriteLine($"Person with name {Name} has salary of {Salary}");
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }

    enum Department
    {
        A, B, C
    }
}
