using WhiteElephant.Domain.Person;

namespace WhiteElephant.Infrastructure.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly List<Person> _people = new()
    {
        Person.Create("Billy Bob"),
        Person.Create("Sally Sue"),
        Person.Create("Joe Bob")
    };
    
    public Task<List<Person>> GetAllAsync()
    {
        return Task.FromResult(_people);
    }

    public Task<Person?> GetByIdAsync(Guid id)
    {
        return Task.FromResult(_people.FirstOrDefault(x => x.Id == id));
    }

    public Task AddAsync(Person person)
    {
        _people.Add(person);
        
        return Task.CompletedTask;
    }

    public Task RemoveAsync(Guid id)
    {
        var personToRemove = _people.FirstOrDefault(x => x.Id == id);
        
        if (personToRemove is not null)
        {
            _people.Remove(personToRemove);
        }
        
        return Task.CompletedTask;
    }
}