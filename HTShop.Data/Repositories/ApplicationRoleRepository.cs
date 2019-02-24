using HTShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTShop.Data.Repositories
{
    public interface IApplicationtionRoleRepository : IRepository<ApplicationRoleRepository>
    {

    }
    public class ApplicationRoleRepository : RepositoryBase<ApplicationRoleRepository>, IApplicationtionRoleRepository
    {
        public ApplicationRoleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
