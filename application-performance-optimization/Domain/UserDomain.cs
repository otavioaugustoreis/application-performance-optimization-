using application_performance_optimization.Context;
using application_performance_optimization.Entities;
using Microsoft.EntityFrameworkCore;

namespace application_performance_optimization.Domain
{
    public class UserDomain(AppDbContext appDbContext) : IUserDomain
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public void DeleteUser(UserEntity user)
        {
            _appDbContext.UserEntity!.Remove(user);
        }

        public async Task<List<UserEntity>?> GetAllUsersAsync()
        {
            return await _appDbContext.UserEntity.ToListAsync();
        }

        public async Task<UserEntity?> GetUserByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _appDbContext.UserEntity.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public void InsertUser(UserEntity user)
        {
            _appDbContext.Add(user);
        }
    }
}
