namespace Metacube.Net.ZooManagement;

public interface Animal
{

    public static readonly string INVALID_AGE_MESSAGE = "Age is invalid";
    public int ID { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public float Weight { get; set; }
    public string Health { get; set; }

    public string sound();

}