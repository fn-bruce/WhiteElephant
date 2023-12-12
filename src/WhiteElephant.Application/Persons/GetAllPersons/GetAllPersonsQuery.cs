using MediatR;
using WhiteElephant.Application.Persons.DTOs;
using WhiteElephant.Domain.Person;

namespace WhiteElephant.Application.Persons.GetAllPersons;

public record GetAllPersonsQuery : IRequest<IEnumerable<PersonDto>>;

public class GetAllPersonsQueryHandler : IRequestHandler<GetAllPersonsQuery, IEnumerable<PersonDto>>
{
    private readonly IPersonRepository _personRepository;

    public GetAllPersonsQueryHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<IEnumerable<PersonDto>> Handle(GetAllPersonsQuery request, CancellationToken cancellationToken)
    {
        var people = await _personRepository.GetAllAsync();
        var dtos = people.Select(x => new PersonDto(x.Id, x.Name));
        
        return dtos;
    }
}