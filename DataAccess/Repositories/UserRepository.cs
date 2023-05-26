using Domain.Interfaces;
using DataAccess.Repositories;
using DataAccess;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<CustomUser>, IUserRepository
    {
        public UserRepository(eshop_dbContext repositoryContext)
            : base(repositoryContext) { }
    }
}
