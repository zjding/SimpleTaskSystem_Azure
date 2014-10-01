using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Application.Services.Dto;
using SimpleTaskSystem.People.Dtos;

namespace SimpleTaskSystem.People
{
    public class GetAllPeopleOutput :IOutputDto
    {
        public List<PersonDto> People { get; set; } 
    }
}
