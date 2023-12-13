using WhiteElephant.Domain.Common;

namespace WhiteElephant.Domain.Person;

public class Person : Entity<Guid>
{
    public string Name { get; set; } = string.Empty;
    
    private Person(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    private Person(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public static Person Create(string name)
    {
        return new Person(name);
    }
    
    public static Person Create(Guid id, string name)
    {
        return new Person(id, name);
    }
}