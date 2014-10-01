using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;

namespace SimpleTaskSystem.People.Dtos
{
    public class PersonDto : EntityDto
    {
        public string Name { get; set; }
    }
}
