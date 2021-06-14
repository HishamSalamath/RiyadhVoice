using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public interface IArtistRepository
    {
        IEnumerable<ArtistManagement> AllArtists { get; }

        ArtistManagement GetArtist(int ArtisID);
    }
}
 