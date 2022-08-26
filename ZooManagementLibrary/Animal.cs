namespace Metacube.Net.ZooManagement;

public interface Animal
{
    public static readonly string INVALID_AGE_MESSAGE = "Age is invalid";
    public static readonly string INVALID_WEIGHT_MESSAGE = "Weight is invalid";
    public static readonly string INVALID_NAME_MESSAGE = "Name is invalid";
    public static readonly string INVALID_HEALTH_MESSAGE = "Health is invalid";
    public string ID { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public float Weight { get; set; }
    public string Health { get; set; }

    public string sound();

}