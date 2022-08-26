namespace Metacube.Net.ZooManagement;

public class Peacock : Bird
{
    private static readonly string SOUND = "Squawk, squawk!";
    private string id;
    private string name;
    private int age;
    private float weight;
    private string health;
    private string featherColor;

    public Peacock(string name, int age, float weight, string health, string featherColor)
    {
        // Add some validators and exception handling!
        if (age <= 0)
        {
            throw new ArithmeticException(Animal.INVALID_AGE_MESSAGE);
        }
        this.id = Guid.NewGuid().ToString();
        this.name = name;
        this.age = age;
        this.featherColor = featherColor;
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

    public string FeatherColor
    {
        get
        {
            return featherColor;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(Bird.INVALID_FEATHER_MESSAGE);
            }
            featherColor = value;
        }
    }

    public string sound()
    {
        return Peacock.SOUND;
    }

}