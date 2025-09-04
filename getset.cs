using System;

class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (age >= 0 && age <= 100)
                age = value;
            else
                Console.WriteLine("age is invalid");
        }
    }
}

class vaanar
{
    static void Main()
    {
        Person p = new Person();

        p.Age = 25;
        Console.WriteLine("Age: " + p.Age);

        p.Age = -5;
        Console.WriteLine("Age: " + p.Age);
    }
}