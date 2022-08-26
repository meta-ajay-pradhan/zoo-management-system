namespace Metacube.Net.ZooManagement;

public interface Mammal : Animal
{
    public static readonly string INVALID_FUR_MESSAGE = "Fur color invalid";
    public string FurColor { get; set; }
}