using AM.Infrastructure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AM.Infrastructure.Services
{
    public interface IRestService
    {
        Task<List<User>> GetUsers();
        Task<List<Post>> GetPosts();
    }
}
