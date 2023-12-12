namespace WhiteElephant.Domain.Person;

public interface IPersonRepository
{
    public Task<List<Person>> GetAllAsync();
    
    public Task AddAsync(Person person);
    
    public Task RemoveAsync(Person person);
}