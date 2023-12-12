using MediatR;
using WhiteElephant.Domain.Person;

namespace WhiteElephant.Application.Persons.AddPerson;

public record AddPersonCommand(string Name) : IRequest;

public class AddPersonCommandHandler : IRequestHandler<AddPersonCommand>
{
    private readonly IPersonRepository _personRepository;

    public AddPersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public Task Handle(AddPersonCommand request, CancellationToken cancellationToken)
    {
        var person = Person.Create(request.Name);
        
        return _personRepository.AddAsync(person);
    }
}