namespace WebApp1.Core.Model;

public class NamedEntity : BaseEntity
{
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Id})";
    }
}