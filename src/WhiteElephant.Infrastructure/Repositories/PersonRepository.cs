using WhiteElephant.Domain.Person;

namespace WhiteElephant.Infrastructure.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly List<Person> _people = new();
    
    public Task<List<Person>> GetAllAsync()
    {
        return Task.FromResult(_people);
    }

    public Task AddAsync(Person person)
    {
        _people.Add(person);
        
        return Task.CompletedTask;
    }

    public Task RemoveAsync(Person person)
    {
        _people.Remove(person);
        
        return Task.CompletedTask;
    }
}