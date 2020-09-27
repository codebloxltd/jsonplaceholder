using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Models
{
    public class PostsResponse
    {
        [JsonProperty("Post")]
        public List<Post> Posts { get; set; }
    }
}
