namespace Metacube.Net.ZooManagement;

public interface Bird: Animal
{

    public static readonly string INVALID_FEATHER_MESSAGE = "Invalid feather color!";
    public string FeatherColor { get; set; }
}