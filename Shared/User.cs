using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorSyncfusionGrid.Shared
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field {0} is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public string Body { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public int? UserId { get; set; }
    }
}
