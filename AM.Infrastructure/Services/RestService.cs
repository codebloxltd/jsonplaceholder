using AM.Infrastructure.Models;
using AM.Infrastructure.Services;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AM.Infrastructure.Services
{
    public class RestService : IRestService
    {
        public RestService()
        {
        }

        public async Task<List<Post>> GetPosts()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com/posts");

            var response = await client.ExecuteAsync<List<Post>>(new RestRequest());

            return response.Data;
        }

        public async Task<List<User>> GetUsers()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com/users");

            var response = await client.ExecuteAsync<List<User>>(new RestRequest());

            return response.Data;
        }
    }
}
