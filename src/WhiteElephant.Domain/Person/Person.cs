using WhiteElephant.Domain.Common;

namespace WhiteElephant.Domain.Person;

public class Person : Entity<Guid>
{
    public string Name { get; set; } = string.Empty;
}