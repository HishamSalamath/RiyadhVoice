using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiyadhVoice.Model;

namespace RiyadhVoice.ViewModels
{
    public class ArtistListViewModel
    {
        public IEnumerable<ArtistManagement> Artists { get; set; }

    }
}
