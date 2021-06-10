using RiyadhVoice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.ViewModels
{
    public class EventsListViewModel

    {
        public string CurrentCategory { get; set; }
        public IEnumerable<Events> Events { get; set; }

    }
}
