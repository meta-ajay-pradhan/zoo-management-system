namespace Metacube.Net.ZooManagement;
public class Zoo
{
    public readonly string NULL_VALUE_MESSAGE = "Null args not allowed!";
    private string name;
    private List<Zone<Mammal>> mammalZones;
    private List<Zone<Reptile>> reptileZones;
    private List<Zone<Bird>> birdZones;

    public Zoo(string name)
    {
        this.name = name;
        mammalZones = new List<Zone<Mammal>>();
        reptileZones = new List<Zone<Reptile>>();
        birdZones = new List<Zone<Bird>>();
    }

    public Tuple<string, string>? addMammal(Mammal animal)
    {
        if (mammalZones.Count == 0)
        {
            return null;
        }
        foreach (Zone<Mammal> zone in mammalZones)
        {
            Tuple<string, string>? loc = zone.addAnimal(animal);
            if (loc != null)
            {
                return loc;
            }
        }
        return null;
    }
    public Tuple<string, string>? addReptile(Reptile animal)
    {
        if (reptileZones.Count == 0)
        {
            return null;
        }
        foreach (Zone<Reptile> zone in reptileZones)
        {
            Tuple<string, string>? loc = zone.addAnimal(animal);
            if (loc != null)
            {
                return loc;
            }
        }
        return null;
    }

    public Tuple<string, string>? addBird(Bird animal)
    {
        if (birdZones.Count == 0)
        {
            return null;
        }
        foreach (Zone<Bird> zone in birdZones)
        {
            Tuple<string, string>? loc = zone.addAnimal(animal);
            if (loc != null)
            {
                return loc;
            }
        }
        return null;
    }

    public void addMammalZone(Zone<Mammal> mammalZone)
    {
        if (mammalZone == null)
        {
            throw new ArgumentNullException(NULL_VALUE_MESSAGE);
        }
        this.mammalZones.Add(mammalZone);
    }

    public void addReptileZone(Zone<Reptile> reptileZone)
    {
        if (reptileZone == null)
        {
            throw new ArgumentNullException(NULL_VALUE_MESSAGE);
        }
        this.reptileZones.Add(reptileZone);
    }

    public void addBirdZone(Zone<Bird> birdZone)
    {
        if (birdZone == null)
        {
            throw new ArgumentNullException(NULL_VALUE_MESSAGE);
        }
        this.birdZones.Add(birdZone);
    }

}
