namespace Metacube.Net.ZooManagement;

public class Lion : Mammal
{
    private static readonly string SOUND = "Roar!";
    private static int lastID = 0;
    private int id;
    private string name;
    private int age;
    private float weight;
    private string health;
    private string furColor;

    public Lion(string name, int age, float weight, string health, string furColor)
    {
        // Add some validators and exception handling!
        if (age <= 0)
        {
            throw new ArithmeticException(Animal.INVALID_AGE_MESSAGE);
        }
        this.id = ++lastID;
        this.name = name;
        this.age = age;
        this.furColor = furColor;
    }

    public int ID
    {
        get
        {
            return id;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }

    public float Weight
    {
        get
        {
            return weight;
        }

        set
        {
            weight = value;
        }
    }

    public string Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public string FurColor
    {
        get
        {
            return furColor;
        }

        set
        {
            furColor = value;
        }
    }

    public string sound() {
        return Lion.SOUND;
    }

}