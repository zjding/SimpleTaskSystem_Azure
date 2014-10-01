using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTaskSystem.People;

namespace SimpleTaskSystem.EntityFramework.Repositories
{
    public class PersonRepository : SimpleTaskSystemRepositoryBase<Person>, IPersonRepository
    {
    }
}
