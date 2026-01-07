using application_performance_optimization.Entities;

namespace application_performance_optimization.Services
{
    public interface IUserService
    {
        Task<List<UserEntity>> GetAllUsersAsync();
        Task DeleteUser(int id, CancellationToken cancellationToken);
        Task<UserEntity> GetUserByIdAsync(int? id, CancellationToken cancellationToken);
        void InsertUser(UserEntity user);
    }
}
