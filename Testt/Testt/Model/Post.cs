using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Testt.Controllers.Model;
using Testt.Properties.Repositories;

namespace Testt.Model
{
    public class Post: IBaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Title { get; set; }
        public String Body { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [InverseProperty("Posts")]
        public User User { get; set; }

        //[ForeignKey("Rusers")]
        //public int RUserId { get; set; }
        //[InverseProperty("Rposts")]
        //public User Rusers { get; set; }


    }
}
