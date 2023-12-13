using MediatR;
using WhiteElephant.Application.Persons.DTOs;
using WhiteElephant.Domain.Person;

namespace WhiteElephant.Application.Persons.AddPerson;

public record AddPersonCommand(PersonDto person) : IRequest;

public class AddPersonCommandHandler : IRequestHandler<AddPersonCommand>
{
    private readonly IPersonRepository _personRepository;

    public AddPersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public Task Handle(AddPersonCommand request, CancellationToken cancellationToken)
    {
        var person = Person.Create(request.person.Id, request.person.Name);
        return _personRepository.AddAsync(person);
    }
}