using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public class EventsRepository : IEventsRepository
    {
        private readonly AppDBContext _appDBContext;

        public EventsRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;

        }

        public IEnumerable<Events> AllEvents
        {
            get
            {
                return _appDBContext.Events.Include(c => c.Category);
            }

            
        }

        public IEnumerable<Events> EventOfTheWeek

        {
            get
            {
                return _appDBContext.Events.Include(c => c.Category).Where(e => e.IsEventOfTheWeek);
            }

        }

        public Events GetEventByID (int EventID)
        {
            return _appDBContext.Events.FirstOrDefault(e => e.Eventid == EventID);
        }
    }
}
