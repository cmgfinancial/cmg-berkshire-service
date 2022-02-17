using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMG.Database.CMGPortal.Models
{
    [Table("MemberSubscriptions")]
    public class MemberSubscriptions
    {
        public int ID { get; set; }

        //[ForeignKey("Member")]
        public int MemberID { get; set; }

        public bool? TestimonialTreeSurveysEnabled { get; set; }

        public bool? TestimonialTreeReviewsEnabled { get; set; }

        public bool? ZillowReviewsEnabled { get; set; }

        public bool? HomebotSubscribe { get; set; }

        public DateTime? HomebotSubscriptionStartDate { get; set; }

        public DateTime? HomebotSubscriptionEndDate { get; set; }

        public bool? HomebotAccountExist { get; set; }

        public string HomebotAccountNumber { get; set; }

        public bool? HomebotWidgetEnabled { get; set; }

        public string HomebotPlan { get; set; }

        public string HomebotBillTo { get; set; }

        public string HomebotCostCenter { get; set; }

        public string HomebotComment { get; set; }

        public bool? HomeASAPOptIn { get; set; }

        public DateTime? HomeASAPOptInStartDate { get; set; }

        public DateTime? HomeASAPOptInEndDate { get; set; }

        public bool? MobileApp1003PreferenceSet { get; set; }

        public string MobileApp1003Preference { get; set; }

        public DateTime? MobileApp1003StartDate { get; set; }

        public DateTime? MobileApp1003EndDate { get; set; }

        public bool? MarketingLeadsSubscribe { get; set; }

        public DateTime? MrktLeadsSubscriptionStartDate { get; set; }

        public DateTime? MrktLeadsSubscriptionEndDate { get; set; }

        public string PreferredContactNumber { get; set; }

        public bool TTReviewEnabled { get; set; }

        public bool TTServiceEnabled { get; set; }

        public bool ZillowEnabled { get; set; }

        public bool BranchReviewsEnabled { get; set; }

        public string signatureProfile { get; set; }

        public string signatureDNumber { get; set; }

        public string signatureCNumber { get; set; }

        public string signatureEFax { get; set; }

        public string signatureEmail { get; set; }

        public string BackgroundTheme { get; set; }

        public string MLDocuSignStatus { get; set; }

        public DateTime? MLDocuSignCompletedDate { get; set; }

        public bool? MCSubscribe { get; set; }
        public bool? MCReactivate { get; set; }
        public DateTime? MCSubscriptionStartDate { get; set; }

        public DateTime? MCSubscriptionEndDate { get; set; }
        public string MCBillTo { get; set; }
        public string MCCostCenter { get; set; }
        public string MCComment { get; set; }

        public bool? LOASubscribe { get; set; }
        public DateTime? LOASubscriptionStartDate { get; set; }
        public DateTime? LOASubscriptionEndDate { get; set; }
        public string LOACost { get; set; }
        public string LOAEmployeeID { get; set; }

        public bool CenlarEnabled { get; set; } 
        public string CenlarProfile { get; set; }
        public string CenlarAdMessage { get; set; }
        public string RawCenlarAdMessage { get; set; }

        public string CenlarImageURL { get; set; }
        public int? MessageId { get; set; }

        public DateTime? CenlarStartDate { get; set; }
        public DateTime? CenlarEndDate { get; set; }
        public string CustomLogoURL { get; set; }
        public bool VideoTestimonialsEnabled { get; set; }
        public int VideoTestimonialsAmount { get; set; }
        public DateTime VideoTestimonailsStartDate { get; set; }
         

        public bool GoogleEnabled { get; set; }
       

      
        
    }
}
