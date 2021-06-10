using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public interface IEventsRepository
    {
        IEnumerable<Events> AllEvents { get; }
        IEnumerable<Events> EventOfTheWeek { get; }

        Events GetEventByID(int EventId);

    }
}
