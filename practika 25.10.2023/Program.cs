
                Forest forest = new Forest();

                Hedgehog hedgehog1 = new Hedgehog();
                hedgehog1.Name = "Marsel";
                hedgehog1.Age = 18;
                hedgehog1.NumberOfSpines = 200;

                Hedgehog hedgehog2 = new Hedgehog();
                hedgehog2.Name = "Iliza";
                hedgehog2.Age = 17;
                hedgehog2.NumberOfSpines = 300;

                forest.AddHedgehog(hedgehog1);
                forest.AddHedgehog(hedgehog2);

                forest.PrintHedgehogs();

                Console.ReadLine();
 

class Forest
{
    private List<Hedgehog> hedgehogs;

    public Forest()
    {
        hedgehogs = new List<Hedgehog>();
    }

    public void AddHedgehog(Hedgehog hedgehog)
    {
        hedgehogs.Add(hedgehog);
    }

    public void PrintHedgehogs()
    {
        foreach (Hedgehog hedgehog in hedgehogs)
        {
            hedgehog.Info();
        }
    }
}

class Animal
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public virtual void Info()
    {
        Console.WriteLine($"Animal - {Name}, Age: {Age}");
    }
}

class Hedgehog : Animal
{
    private int numberOfSpines;

    public int NumberOfSpines
    {
        get { return numberOfSpines; }
        set { numberOfSpines = value; }
    }

    public override void Info()
    {
        Console.WriteLine($"Hedgehog - {Name}, Age: {Age}, Number of Spines: {NumberOfSpines}");
    }
}