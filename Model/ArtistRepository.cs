using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly AppDBContext _appDBContext;

        public ArtistRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;

        }

        public IEnumerable<ArtistManagement> AllArtists
        {
            get
            {
                return _appDBContext.Artists.Include(c => c.Category);
            }


        }

        public ArtistManagement GetArtist(int ArtistID)
        {
            return _appDBContext.Artists.FirstOrDefault(e => e.ArtistID == ArtistID);
        }
    }
}
