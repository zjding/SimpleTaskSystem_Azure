using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SimpleTaskSystem.People.Dtos;

namespace SimpleTaskSystem.People
{
    public class PersonAppService : IPersonAppService
    {
        private readonly IPersonRepository _personRepository;

        public PersonAppService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public GetAllPeopleOutput GetAllPeople()
        {
            return new GetAllPeopleOutput
            {
                People = Mapper.Map<List<PersonDto>>(_personRepository.GetAllList())
            };
        }
    }
}
