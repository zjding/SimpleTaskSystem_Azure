using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SimpleTaskSystem.People;
using SimpleTaskSystem.People.Dtos;
using SimpleTaskSystem.Tasks.Dtos;

namespace SimpleTaskSystem
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            Mapper.CreateMap<Task, TaskDto>();
            Mapper.CreateMap<Person, PersonDto>();
        }
    }
}
