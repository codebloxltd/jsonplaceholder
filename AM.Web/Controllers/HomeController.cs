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
    public class HomeController : Controller
    {
        private readonly IRestService _restService;
        private readonly IMapper _mapper;

        public HomeController(IRestService restService, IMapper mapper)
        {
            _restService = restService;
            _mapper = mapper;
        }

        public async Task<ActionResult> Index()
        {
            var users = await _restService.GetUsers();
            var posts = await _restService.GetPosts();

            var vm = _mapper.Map<List<UserPostsVM>>(users).ToList();
            foreach (var item in vm)
            {
                item.PostCount = posts.Where(p => p.UserId == item.Id).Count();
            }

            return View(vm);
        }
    }
}