using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RiyadhVoice.Model
{
    public class Events

    {
        [Key]
        public int Eventid { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageURL { get; set; }
        public string ImageThumbnailURL { get; set; }

        public bool IsEventOfTheWeek { get; set; }
        public int CategoryID { get; set; }

        public Category Category { get; set; }





    }
}
