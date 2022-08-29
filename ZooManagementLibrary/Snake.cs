namespace Metacube.Net.ZooManagement;

public class Snake : Reptile
{
    private static readonly string SOUND = "Hiss!";
    private string id;
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
        this.id = Guid.NewGuid().ToString();
        this.name = name;
        this.age = age;
        this.health = health;
        this.scaleColor = scaleColor;
    }

    public string ID
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
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(Animal.INVALID_NAME_MESSAGE);
            }
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
            if (value <= 0)
            {
                throw new ArithmeticException(Animal.INVALID_AGE_MESSAGE);
            }
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
            if (value <= 0f)
            {
                throw new ArithmeticException(Animal.INVALID_WEIGHT_MESSAGE);
            }
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
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(Animal.INVALID_HEALTH_MESSAGE);
            }
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
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(Reptile.INVALID_SCALE_MESSAGE);
            }
            scaleColor = value;
        }
    }

    public string sound()
    {
        return Snake.SOUND;
    }

}