//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Threading.Tasks;

//namespace RiyadhVoice.Model
//{
//    public class CategoryDB
//    {
//        [Column("CategoryID")]
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        [Required]
//        public int CategoryID { get; set; }

//        [Column("CategoryName")]
//        [Required]
//        [StringLength(50)]
//        public string CategoryName { get; set; }

//        [Column("Description")]
//        [Required]
//        [StringLength(50)]
//        public string Description { get; set; }

//        public virtual Events Events { get; set; }


//    }
//}
