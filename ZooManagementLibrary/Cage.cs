namespace Metacube.Net.ZooManagement;

public class Cage<T> where T : Animal
{
    public static readonly string LIMIT_EXCEED_MESSAGE = "No more limit in the cage!";
    public static readonly string INVALID_ANIMAL_MESSAGE = "Invalid Animal!";
    public static readonly string INVALID_LIMIT_MESSAGE = "Invalid Cage Limit!";

    private string id;
    private List<T> animals;
    private uint limit;
    private readonly Type animalType;

    public Cage(uint limit, Type animalType)
    {
        this.limit = limit;
        this.animals = new List<T>();
        string temp = Guid.NewGuid().ToString();
        this.id = temp.Split('-')[4];
        this.animalType = animalType;
    }

    public string ID
    {
        get
        {
            return id;
        }
    }

    public List<T> Animals
    {
        get
        {
            return animals;
        }
    }

    public uint Limit
    {
        set
        {
            if (value < animals.Count || value <= 0)
            {
                throw new ArithmeticException(INVALID_LIMIT_MESSAGE);
            }
            limit = value;
        }
        get
        {
            return limit;
        }
    }

    public Type getAnimalType()
    {
        return this.animalType;
    }

    public string? addAnimal(T animal)
    {
        if (animal == null)
        {
            throw new ArgumentException(INVALID_ANIMAL_MESSAGE);
        }
        if (this.isFull())
        {
            return null;
        }
        animals.Add(animal);
        Console.WriteLine("\n cage71:" + animals[0].Name);
        limit++;

        return this.id;
    }

    public bool isFull()
    {
        Console.WriteLine("\ncage79: " + limit + " " + animals.Count);
        return ! (limit < animals.Count);
    }

    public bool removeAnimal(string animalId)
    {
        List<T> newAnimalList = this.animals.FindAll(animal => animal.ID != animalId);
        if (newAnimalList.Count == animals.Count)
        {
            //consider throwing an exception maybe!
            return false;
        }
        this.animals = newAnimalList;
        return true;
    }
}