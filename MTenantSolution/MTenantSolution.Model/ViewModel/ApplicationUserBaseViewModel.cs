using MTenantSolution.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTenantSolution.Model.ViewModel
{
    public class ApplicationUserBaseViewModel
    {
        public string? Id { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? ImageName { get; set; }
        public bool? IsActive { get; set; }
        public string? ProfileDescription { get; set; }
    }

}
