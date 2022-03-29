namespace Enumerable;

public class Entity
{
    public int Id { get; }
    public int ParentId { get; }
    public string Name { get; }

    public Entity(int id, int parentId, string name)
    {
        Id = id;
        ParentId = parentId;
        Name = name;
    }
    
    public override string ToString() => $"Entity{{Id = {Id}}}";
}