using Microsoft.AspNetCore.Mvc;
using RiyadhVoice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiyadhVoice.ViewModels;

namespace RiyadhVoice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventsRepository _EventsRepository;

        public HomeController (IEventsRepository eventsRepository)
        {
            _EventsRepository = eventsRepository;
        }


        public IActionResult Index()
        {

            var homeViewModel = new homeViewModel
            {
                Eventsoftheweek = _EventsRepository.EventOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
