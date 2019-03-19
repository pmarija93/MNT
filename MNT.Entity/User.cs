using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNT.Models
{
    public partial class User
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }
        
        [Required(ErrorMessage = "niste unijeli ime")]
        public string Username { get; set; }
        public string Password { get; set; }

        public int? UserGroupId { get; set; }
       
    }
}
