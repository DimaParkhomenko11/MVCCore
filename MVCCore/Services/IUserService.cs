using System.Threading.Tasks;

namespace MVCCore.Services
{
    public interface IUserService
    {
        public Task<int> AddUser(string name);
        public Task UpdateUser(int userId, string name);
    }
}