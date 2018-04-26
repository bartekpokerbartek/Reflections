namespace Reflections
{
    class Person
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public Person()
        {
            Name = "John Doe";
            Salary = 0;
        }

        public Person(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public int IncreaseSalary(int amount)
        {
            return Salary + amount;
        }

        public bool IsEmployed()
        {
            if (Salary == 0)
                return false;

            return true;
        }
    }
}
