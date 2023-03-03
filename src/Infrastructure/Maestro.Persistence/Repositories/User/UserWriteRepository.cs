using Maestro.Application.Repository.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro.Domain.Entities;
using Maestro.Persistence.Context;

namespace Maestro.Persistence.Repositories.User
{
    public class UserWriteRepository : WriteRepository<SH_User>, IUserWriteRepository
    {
        public UserWriteRepository(MaestroContext context) : base(context)
        {
        }
    }
}
