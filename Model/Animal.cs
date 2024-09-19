public class Animal
{
    public int AnimalId { get; set; }
    public string? AnimalType { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal MilkGiven { get; set; }

    public virtual string MakeSound()
    {
        return "Generic animal sound";
    }

    public virtual int GiveBirth()
    {
        Random rnd = new Random();
        return rnd.Next(1, 4);
    }

    public virtual decimal ProduceMilk()
    {
        return 0;
    }
}

public class Cow : Animal
{
    public Cow()
    {
        AnimalType = "Cow";
    }
    public override string MakeSound()
    {
        return "Moo";
    }
    public override decimal ProduceMilk()
    {
        Random rnd = new Random();
        return rnd.Next(0, 21);
    }
}

public class Sheep : Animal
{
    public Sheep()
    {
        AnimalType = "Sheep";
    }

    public override string MakeSound()
    {
        return "Baa";
    }

    public override decimal ProduceMilk()
    {
        Random rnd = new Random();
        return rnd.Next(0, 6);
    }
}

public class Goat : Animal
{
    public Goat()
    {
        AnimalType = "Goat";
    }

    public override string MakeSound()
    {
        return "Maa";
    }

    public override decimal ProduceMilk()
    {
        Random rnd = new Random();
        return rnd.Next(0, 11);
    }
}