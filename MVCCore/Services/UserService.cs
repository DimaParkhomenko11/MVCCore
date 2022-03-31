using System;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Internal;
using Microsoft.EntityFrameworkCore;
using MVCCore.Infrastructure.Data;
using MVCCore.Infrastructure.Repository;

namespace MVCCore.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;

        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> AddUser(string name)
        {
            if (name.IsNullOrEmpty())
                throw new ArgumentNullException();

            var newUser = await _repository.AddAsync(new User
            {
                Name = name
            });

            return newUser.Id;
        }

        public async Task UpdateUser(int userId, string name)
        {
            var user = await _repository.GetAll<User>()
                .FirstOrDefaultAsync(u => u.Id == userId);
            
            user.Name = name;
            
            await _repository.UpdateAsync(user);
        }
    }
}