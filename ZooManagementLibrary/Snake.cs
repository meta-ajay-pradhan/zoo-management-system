namespace Metacube.Net.ZooManagement;

public class Snake : Reptile
{
    private static readonly string SOUND = "Hiss!";
    private static int lastID = 0;
    private int id;
    private string name;
    private int age;
    private float weight;
    private string health;
    private string scaleColor;

    public Snake(string name, int age, float weight, string health, string scaleColor)
    {
        // Add some validators and exception handling!
        if (age <= 0)
        {
            throw new ArithmeticException(Animal.INVALID_AGE_MESSAGE);
        }
        this.id = ++lastID;
        this.name = name;
        this.age = age;
        this.scaleColor = scaleColor;
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

    public string ScaleColor
    {
        get
        {
            return scaleColor;
        }

        set
        {
            scaleColor = value;
        }
    }

    public string sound() {
        return Snake.SOUND;
    }

}