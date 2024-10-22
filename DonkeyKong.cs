public class DonkeyKong : Character
{
    public List<string> Species { get; set; } = [];

    public override string Display()
    {
        return $"Id: {Id}\nName: {Name}\nDescription: {Description}\n Species: {string.Join(", ", Species)}\n";
    }
}