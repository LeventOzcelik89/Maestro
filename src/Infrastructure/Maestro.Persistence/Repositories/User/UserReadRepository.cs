using Maestro.Application.Repository.User;
using Maestro.Domain.Entities;
using Maestro.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Persistence.Repositories.User
{
    public class UserReadRepository : ReadRepository<SH_User>, IUserReadRepository
    {
        public UserReadRepository(MaestroContext context) : base(context)
        {
        }
    }
}
