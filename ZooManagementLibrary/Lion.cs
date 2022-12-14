namespace Metacube.Net.ZooManagement;

public class Lion : Mammal
{
    private static readonly string SOUND = "Roar!";
    private static readonly string NULL_REFRENCE_MESSAGE = "null value not allowed!";
    private string id;
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
        if(health == null || furColor == null) {
            throw new ArgumentNullException(NULL_REFRENCE_MESSAGE);
        }
        this.id = Guid.NewGuid().ToString();
        this.name = name;
        this.age = age;
        this.health = health;
        this.furColor = furColor;
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
            if (value <= 0)
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

    public string FurColor
    {
        get
        {
            return furColor;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(Mammal.INVALID_FUR_MESSAGE);
            }
            furColor = value;
        }
    }

    public string sound()
    {
        return Lion.SOUND;
    }

}