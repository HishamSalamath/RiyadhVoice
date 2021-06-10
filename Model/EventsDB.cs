//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;


//namespace RiyadhVoice.Model
//{
//    public class EventsDB
//    {
//        [Column("EventID")]
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        [Required]
//        public int Eventid { get; set; }

//        [Column("Event Name")]
//        [Required]
//        [StringLength(50)]
//        public string Name { get; set; }

//        [Column("ShortDescription")]
//        [Required]
//        [StringLength(500)]
//        public string ShortDescription { get; set; }

//        [Column("LongDescription")]
//        [Required]
//        [StringLength(500)]
//        public string LongDescription { get; set; }

//        [Column("Category ID")]
//        [Required]
//        [StringLength(500)]
//        public string CategoryID { get; set; }

//        [ForeignKey("CategoryID")]
//        public virtual Category Category { get; set; }



//        [Column("Image URL")]
//        [Required]
//        [StringLength(500)]
//        public string ImageURL { get; set; }







//    }
//}
