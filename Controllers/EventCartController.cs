using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiyadhVoice.ViewModels;
using RiyadhVoice.Model;



namespace RiyadhVoice.Controllers
{
    public class EventCartController : Controller
    {
        private readonly IEventsRepository _EventsRepository;
        private readonly ICategoryRepository _CategoryRepository;
        private readonly AvailedEvents _availedEvents;

        public EventCartController(IEventsRepository EventsRepository, AvailedEvents availedEvents)
        {
            _availedEvents = availedEvents;

            _EventsRepository = EventsRepository;
        }

        //public ViewResult Index()
        //{
        //    var eventCartViewModel = new EventCartViewModel
        //    {
        //        AvailedEvents = _availedEvents,

        //    }

        //   return  View();
        //}

        public RedirectToActionResult AddToShoppingCart(int EventID)
        {
            var selectedPie = _EventsRepository.AllEvents.FirstOrDefault(p => p.Eventid == EventID);

            if (selectedPie != null)
            {
                _availedEvents.AddToCart(selectedPie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int EventID)
        {
            var selectedPie = _EventsRepository.AllEvents.FirstOrDefault(p => p.Eventid == EventID);

            if (selectedPie != null)
            {
                _availedEvents.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
