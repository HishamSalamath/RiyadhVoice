using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiyadhVoice.Model;
using RiyadhVoice.ViewModels;

namespace RiyadhVoice.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventsRepository _EventsRepository;
        private readonly ICategoryRepository _CategoryRepository;

        public EventsController (IEventsRepository eventsRepository , ICategoryRepository categoryRepository)
        {
            _EventsRepository = eventsRepository;
            _CategoryRepository = categoryRepository;
        }
        public ViewResult List()
        {
            EventsListViewModel eventsListViewModel = new EventsListViewModel();
            eventsListViewModel.Events = _EventsRepository.AllEvents;

           // eventsListViewModel.CurrentCategory = "Wedding";
            return View(eventsListViewModel);
        }

        public IActionResult Details(int id)
        {
            var events = _EventsRepository.GetEventByID(id);
            if ( events == null)
                return NotFound();

            return View(events);
        }

    }
}
