namespace Metacube.Net.ZooManagement;

public class Zone<T> where T : Animal
{
    private static readonly string INVALID_CAGE_LIMIT_MESSAGE = "Cage limit invalid!";
    private string id;
    private List<Cage<T>> cages;
    private uint limit;

    public string ID
    {
        get
        {
            return this.id;
        }
    }

    public List<Cage<T>> Cages
    {
        get
        {
            return this.cages;
        }
    }

    public uint Limit
    {
        get
        {
            return this.limit;
        }
        set
        {
            if (value < this.cages.Count || value <= 0)
            {
                throw new ArithmeticException(INVALID_CAGE_LIMIT_MESSAGE);
            }
            this.limit = value;
        }
    }

    public Zone(uint limit)
    {
        this.id = Guid.NewGuid().ToString();
        this.limit = limit;
        this.cages = new List<Cage<T>>();
    }

    public void addCage(Cage<T> cage)
    {
        
    }

}