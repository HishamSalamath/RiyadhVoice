using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public class ArtistManagement
    {
        [Key]
        public int ArtistID { get; set; }
        public string A_Name { get; set; }
        public string A_ShortDescription { get; set; }
        public string A_LongDescription { get; set; }
        public string A_ImageURL { get; set; }
        public string A_ImageThumbnailURL { get; set; }

        public bool A_IsEventOfTheWeek { get; set; }
        public int A_CategoryID { get; set; }

        public Category Category { get; set; }





    }
}

    

