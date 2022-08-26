namespace Metacube.Net.ZooManagement;

public interface Reptile : Animal
{
    public static readonly string INVALID_SCALE_MESSAGE = "Invalid scale color!";
    public string ScaleColor { get; set; }
}