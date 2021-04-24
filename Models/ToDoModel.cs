using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Please provide an Email address.")]
        
        public string Email { get; set; }

        [Key]
        [Required(ErrorMessage = "Please provide a title")]
        [MaxLength(50)]
        public string Title { get; set; }


        [MaxLength(250)]
        public string Description { get; set; }

        public DateTime Added_date { get; set; } = DateTime.Now;

        public DateTime Due_date { get; set; }

        public Boolean Done { get; set; }

        public DateTime? Done_date { get; set; } = DateTime.Now;
    }
}
