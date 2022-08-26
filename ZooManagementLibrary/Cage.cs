namespace Metacube.Net.ZooManagement;

public class Cage<T> where T : Animal
{
    public static readonly string LIMIT_EXCEED_MESSAGE = "No more limit in the cage!";
    public static readonly string INVALID_ANIMAL_MESSAGE = "Invalid Animal!";
    public static readonly string INVALID_LIMIT_MESSAGE = "Invalid Cage Limit!";

    private string id;
    private List<T> animals;
    private uint limit;

    public Cage(uint limit)
    {
        this.limit = limit;
        this.animals = new List<T>();
        this.id = Guid.NewGuid().ToString();
    }

    public string ID
    {
        get
        {
            return ID;
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



    public void addAnimal(T animal)
    {
        if (animal == null)
        {
            throw new ArgumentException(INVALID_ANIMAL_MESSAGE);
        }
        if (this.isFull())
        {
            throw new ArithmeticException(LIMIT_EXCEED_MESSAGE);
        }
        animals.Add(animal);
        limit++;
    }

    public bool isFull()
    {
        return limit == animals.Count;
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