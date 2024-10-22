public class DonkeyKong : Character
{
    public List<string> Species { get; set; } = [];

    public override string Display()
    {
        return $"Id{Id}\nSpecies: {string.Join(", ", Species)}Name: {Name}\nDescription: {Description}\n";
    }
}