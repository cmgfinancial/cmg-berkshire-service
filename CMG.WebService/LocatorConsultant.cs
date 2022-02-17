using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMG.WebService
{
    public class LocatorConsultant
    {
        public Guid MySiteId { get; set; }

        [Display(Name = "Full Name")]
        public string Name { get; set; }

        public string FullURL { get; set; }

        public string User { get; set; }

        public string Phone { get; set; }

        public string NMLS { get; set; }

        public string Address { get; set; }

        public List<string> Approved { get; set; }

        [Display(Name = "Widget ID")]
        public string TestimonialWidgetID { get; set; }

        [Display(Name = "Widget Enabled")]
        public bool TestimonialWidgedEnabled { get; set; }

        [Display(Name = "API Enabled")]
        public bool TestimonialAPIEnabled { get; set; }

        public string BerkshireOfficeID { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public string Channel { get; set; }

        public string BranchNMLS { get; set; }

        public string LOImageURL { get; set; }

        public string ApplyOnlineURL { get; set; }
    }
}