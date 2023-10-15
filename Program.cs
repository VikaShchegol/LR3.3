using System;

class Parent
{
    public string Pole1 { get; set; }
    public int Pole2 { get; set; }

    public Parent()
    {
    }

    public Parent(string name, int birthYear)
    {
        Pole1 = name;
        Pole2 = birthYear;
    }

    public void Print()
    {
        Console.WriteLine($"{Pole1} родился в {Pole2} году");
        Console.WriteLine($"{Pole1}у {Metod1(DateTime.Now.Year)} лет");
    }

    public int Metod1(int currentYear)
    {
        return currentYear - Pole2;
    }
}

class Child : Parent
{
    public int Pole3 { get; set; }

    public Child(string name, int birthYear, int examScore) : base(name, birthYear)
    {
        Pole3 = examScore;
    }

    public new void Print()
    {
        Console.WriteLine($"{Pole1} родился в {Pole2} году");
        Console.WriteLine($"Набрал {Pole3} баллов");
        Console.WriteLine($"{Pole1}у {Metod1(DateTime.Now.Year)} лет");
        Console.WriteLine($"Проходной балл 8. {(Metod2(8) ? "ПОСТУПИЛ" : "НЕ ПОСТУПИЛ")}");
    }

    public bool Metod2(int passScore)
    {
        return Pole3 >= passScore;
    }
}

class Program
{
    static void Main()
    {
        Parent parent = new Parent("Человек", 2003);
        parent.Print();

        Console.WriteLine();

        Child student1 = new Child("Абитуриент", 2004, 10);
        student1.Print();

        Console.WriteLine();

        Child student2 = new Child("Абитуриент", 2002, 6);
        student2.Print();
    }
}

