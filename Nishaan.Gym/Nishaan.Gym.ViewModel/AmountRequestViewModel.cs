using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nishaan.Gym.ViewModel
{
    public class AmountRequestViewModel
    {
        [Required(ErrorMessage = "Plan is Required")]
        public int PlanId { get; set; }
        [Required(ErrorMessage = "Scheme is Required")]
        public int SchemeId { get; set; }
    }
}
