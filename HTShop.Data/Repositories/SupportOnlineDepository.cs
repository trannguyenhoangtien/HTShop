using HTShop.Data.Infrastructure;
using HTShop.Model.Models;

namespace HTShop.Data.Repositories
{
    public interface ISupportOnlineDepository
    {
    }

    public class SupportOnlineDepository : RepositoryBase<SupportOnline>, ISupportOnlineDepository
    {
        public SupportOnlineDepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}