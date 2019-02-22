using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA2Project.Models.ViewModels
{
    public class CreateCaseViewModel
    {
        public int Id { get; set; }
        public Cases TheCases { get; set; }

        public Users TheUsers { get; set; }
    }
}
