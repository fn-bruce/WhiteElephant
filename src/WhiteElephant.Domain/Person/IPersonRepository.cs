namespace WhiteElephant.Domain.Person;

public interface IPersonRepository
{
    public Task<List<Person>> GetAllAsync();
    
    public Task<Person?> GetByIdAsync(Guid id);
    
    public Task AddAsync(Person person);
    
    public Task RemoveAsync(Guid id);
}