using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM.Web.Models.ViewModels
{
    public class UserDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public List<PostVM> Posts { get; set; }
    }
}