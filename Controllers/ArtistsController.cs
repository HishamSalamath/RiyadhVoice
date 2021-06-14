using Microsoft.AspNetCore.Mvc;
using RiyadhVoice.Model;
using RiyadhVoice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Controllers
{
    public class ArtistsController : Controller
    {
        
            private readonly IArtistRepository _artistRepository;
            private readonly ICategoryRepository _CategoryRepository;

            public ArtistsController(IArtistRepository artistRepository, ICategoryRepository categoryRepository)
            {
                _artistRepository = artistRepository;
                _CategoryRepository = categoryRepository;
            }
            public ViewResult List()
            {
                ArtistListViewModel artistListViewModel = new ArtistListViewModel();
                artistListViewModel.Artists = _artistRepository.AllArtists;

                // eventsListViewModel.CurrentCategory = "Wedding";
                return View(artistListViewModel);
            }

            public IActionResult Details(int id)
            {
                var Artists = _artistRepository.GetArtist(id);
                if (Artists == null)
                    return NotFound();

                return View(Artists);
            }
        }
    }
