using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM.Web.Models.ViewModels
{
    public class UserPostsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int PostCount { get; set; }
    }
}