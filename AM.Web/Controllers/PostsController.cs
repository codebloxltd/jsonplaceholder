using AM.Infrastructure.Services;
using AM.Web.Models.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class PostsController : Controller
    {
        private readonly IRestService _restService;
        private readonly IMapper _mapper;

        public PostsController(IRestService restService, IMapper mapper)
        {
            _restService = restService;
            _mapper = mapper;
        }

        public async Task<ActionResult> Index(int userId)
        {
            var users = await _restService.GetUsers();
            var vm = _mapper.Map<UserDetailsVM>(users.Where(u => u.Id == userId).FirstOrDefault());

            var posts = await _restService.GetPosts();
            var postsByUserId = posts.Where(p => p.UserId == userId);

            vm.Posts = _mapper.Map<List<PostVM>>(postsByUserId).ToList();

            return View(vm);
        }
    }
}