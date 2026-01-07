using application_performance_optimization.Domain;
using application_performance_optimization.Entities;
using Microsoft.Identity.Client;

namespace application_performance_optimization.Services
{
    public class UserService(IUserDomain userDomain) : IUserService
    {
        private readonly IUserDomain _userDomain = userDomain;

        public async Task DeleteUser(int id, CancellationToken cancellationToken)
        {
            try
            {
                var userResult = await _userDomain.GetUserByIdAsync(id, cancellationToken);

                if (userResult is null)
                    throw new Exception("User is null");

                _userDomain.DeleteUser(userResult);
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public async Task<List<UserEntity>> GetAllUsersAsync()
        {
            try
            {
                var usersResult = await _userDomain.GetAllUsersAsync();

                if (usersResult is null) 
                    throw new Exception("List users is empty");
                
                return usersResult;
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public Task<UserEntity> GetUserByIdAsync(int? id, CancellationToken cancellationToken)
        {
            try
            {
                if (id is null) 
                    throw new Exception($"Id is null");
                
                var userResult = _userDomain.GetUserByIdAsync(id.Value, cancellationToken);

                if(userResult is null)
                    throw new Exception("User not exist");

                return userResult;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void InsertUser(UserEntity user)
        {
            try
            {
                _userDomain.InsertUser(user);
            }
            catch (Exception ex) 
            {
                throw;
            }
        }
    }
}
