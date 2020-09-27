using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Models
{
    public class UsersResponse
    {
        [JsonProperty("User")]
        public List<User> Users { get; set; }
    }
}
