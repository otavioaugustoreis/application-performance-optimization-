using application_performance_optimization.Entities;

namespace application_performance_optimization.Domain
{
    public interface IUserDomain
    {
        Task<List<UserEntity>> GetAllUsersAsync();
        void DeleteUser(UserEntity user);
        Task<UserEntity> GetUserByIdAsync(int id, CancellationToken cancellationToken);
        void InsertUser(UserEntity user);
    }
}
