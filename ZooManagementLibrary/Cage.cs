namespace Metacube.Net.ZooManagement;

public class Cage<T> where T : Animal
{
    public static readonly string LIMIT_EXCEED_MESSAGE = "No more limit in the cage!";
    public static readonly string INVALID_ANIMAL_MESSAGE = "Invalid Animal!";
    List<T> animals;
    int limit;

    public Cage(int limit)
    {
        this.limit = limit;
        animals = new List<T>();
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

    public List<T> getAllAnimal()
    {
        return this.animals;
    }

    public bool isFull()
    {
        return limit == animals.Count;
    }
}