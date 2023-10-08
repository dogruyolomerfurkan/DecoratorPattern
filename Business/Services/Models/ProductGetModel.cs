namespace Business;

public record ProductGetModel
{
    public int Id { get; init; }
    public required string Name { get; init; }
}
