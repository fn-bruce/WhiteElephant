using WhiteElephant.Domain.Common;

namespace WhiteElephant.Domain.Person;

public class Person : Entity<Guid>
{
    public string Name { get; set; } = string.Empty;
    
    private Person(string name)
    {
        Name = name;
    }

    public static Person Create(string name)
    {
        return new Person(name);
    }
}