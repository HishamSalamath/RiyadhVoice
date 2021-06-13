using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public class AvailedEventItems
    {
        [Key]
        public int EventItemID { get; set; }
        public Events Events { get; set; }
        public int Amount { get; set; }
        public string EventAvailedID { get; set; }
    }
}
