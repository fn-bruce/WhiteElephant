using MediatR;
using WhiteElephant.Domain.Person;

namespace WhiteElephant.Application.Persons.RemovePerson;

public record RemovePersonCommand(Guid Id) : IRequest;

public class RemovePersonCommandHandler : IRequestHandler<RemovePersonCommand>
{
    private readonly IPersonRepository _personRepository;

    public RemovePersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    
    public Task Handle(RemovePersonCommand request, CancellationToken cancellationToken)
    {
        var personToRemove = _personRepository.GetByIdAsync(request.Id);
        
        if (personToRemove is null)
        {
            throw new Exception($"Person with id {request.Id} not found");
        }
        
        return _personRepository.RemoveAsync(request.Id);
    }
}