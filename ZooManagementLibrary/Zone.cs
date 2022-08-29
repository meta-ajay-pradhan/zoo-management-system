namespace Metacube.Net.ZooManagement;

public class Zone<T> where T : Animal
{
    private static readonly string INVALID_CAGE_LIMIT_MESSAGE = "Cage limit invalid!";
    private static readonly string INVALID_CAGE_MESSAGE = "Cage can't be null!";

    private string id;
    private List<Cage<T>> cages;
    private uint limit;
    public readonly Type zoneType;

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

    public Zone(uint limit, Type zoneType)
    {
        string temp = Guid.NewGuid().ToString();
        this.id = temp.Split('-')[4];
        this.limit = limit;
        this.cages = new List<Cage<T>>();
        this.zoneType = zoneType;
    }

    public bool isFull()
    {
        return this.limit == this.cages.Count;
    }

    public string? addCage(Cage<T> cage)
    {
        if (cage == null)
        {
            throw new ArgumentException(INVALID_CAGE_MESSAGE);
        }

        if (this.isFull())
        {
            return null;
        }

        this.cages.Add(cage);
        return this.id;
    }

    public Tuple<string,string>? addAnimal(T animal) {
        foreach(Cage<T> cage in cages) {
            // if cage is for animal and there is space then add
            if(!cage.isFull() && (animal.GetType() == cage.getAnimalType() )) {
                Console.Write("Zone 79");
                string? cageID = cage.addAnimal(animal);
                if(cageID == null) {
                    throw new Exception();
                }
                return new Tuple<string, string>(this.id, cageID);
            } 
        }
        // try creating a new cage 
        if(!this.isFull()) {
            Console.Write("All Cages occupied! Creating a new cage with occupancy 5!");
            Cage<T> newCage = new Cage<T>(1, animal.GetType());
           
            newCage.addAnimal(animal);
            Console.WriteLine(newCage.ID);
            this.addCage(newCage);
             Console.WriteLine("\nhere");
            return new Tuple<string,string>(this.id, newCage.ID);
        }
        return null;
    }

    public string? removeAnimal(string animalId) {
        foreach(Cage<T> cage in cages) {
            if(cage.removeAnimal(animalId)) {
                return cage.ID;
            }
        }

        return null;
    }

}