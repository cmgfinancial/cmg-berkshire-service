using CMG.Database.CMGPortal;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Data.Entity;
using CMG.Database.CMGPortal.Models;

namespace CMG.WebService
{
    /// <summary>
    /// Summary description for lo_info
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class lo_info : System.Web.Services.WebService
    {
        private static readonly ILog _logger = LogManager.GetLogger("RollingLogFileAppender");
     
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetLOInformationForOfficeID(string userName, string password, string brand, string officeID)
        {
            try
            {
                string uName = ConfigurationManager.AppSettings["UName"].ToString();
                string uPass = ConfigurationManager.AppSettings["UPass"].ToString();

                if (userName.ToLower().Equals(uName) && password.ToLower().Equals(uPass))
                {
                    _logger.Debug("Inside");
                    List<LocatorConsultant> agents = new List<LocatorConsultant>();
                    try
                    {
                        // Grab all retail agents from the database and crunch their info into an agent list.
                        using (CMGPortalDbContext repo = new CMGPortalDbContext())
                        {
                            _logger.Debug("Inside " + brand);
                            if (brand.ToLower().Equals("whf"))
                            {
                                _logger.Debug("Inside " + brand);
                                bool match = false;
                                if (!string.IsNullOrEmpty(officeID))
                                {
                                    var company = repo.Companies.FirstOrDefault(c => c.BrandCode == "WHF");
                                    var Channel = repo.Channels.FirstOrDefault(ch => ch.CompanyID == company.ID && ch.Name == "Retail");
                                    var users = repo.Users.Where(m => m.CompanyID == company.ID && m.ChannelID == Channel.ID).ToList();
                                  
                                    foreach (User agentSite in users)
                                    {
                                        var mem = repo.Members.FirstOrDefault(m => m.UserId == agentSite.ID);
                                        // Build licensed states list
                                        if (mem != null)
                                        {
                                            List<string> states = new List<string>();
                                            if (!string.IsNullOrEmpty(mem.StatesLicensed))
                                            {
                                                foreach (string token in mem.StatesLicensed.Split(','))
                                                {
                                                    // ONLY accept two-letter state codes. Anything else is invalid and should be rejected.
                                                    if (!string.IsNullOrEmpty(token))
                                                    {
                                                        string code = token.Trim();
                                                        if (code.Length == 2)
                                                            states.Add(token);
                                                    }
                                                }
                                            }
                                            // Check for custom fields first and set some defaults where needed.
                                            string loName = string.IsNullOrEmpty(agentSite.CustomFullName) ? agentSite.DisplayName : agentSite.CustomFullName;
                                            string loPhone = string.IsNullOrEmpty(agentSite.CustomOfficePhone) ? agentSite.Phone : agentSite.CustomOfficePhone;
                                            if (string.IsNullOrEmpty(loPhone))
                                                loPhone = "(925) 426-8383";
                                            string Street = string.IsNullOrEmpty(agentSite.CustomStreetAddress) ? agentSite.StreetAddress : agentSite.CustomStreetAddress;
                                            string City = string.IsNullOrEmpty(agentSite.CustomCity) ? agentSite.City : agentSite.CustomCity;
                                            string State = string.IsNullOrEmpty(agentSite.CustomState) ? agentSite.State : agentSite.CustomState;
                                            string Zip = string.IsNullOrEmpty(agentSite.CustomZipCode) ? agentSite.ZipCode : agentSite.CustomZipCode;
                                            var branch = repo.Branches.FirstOrDefault(b => b.ByteOrganizationID == mem.PrimaryBranchID);
                                            var sub = repo.MemberSubscriptions.FirstOrDefault(su => su.MemberID == mem.ID);
                                            var mysite = repo.MySites.FirstOrDefault(s => s.MemberID == mem.ID);
                                            if (mem.BerkshireID != null)
                                            {
                                                _logger.Debug("Inside berkshire");

                                                string[] oIDs = mem.BerkshireID.Split(',');
                                                foreach (string id in oIDs)
                                                {
                                                    if (id.Equals(officeID))
                                                    {
                                                        agents.Add(new LocatorConsultant()
                                                        {
                                                            Name = loName,
                                                            FullURL = "www.welcomehomefunding.com/mysite/" + loName.Replace(" ", "-"),
                                                            User = mysite.Subdomain,
                                                            Phone = loPhone,
                                                            NMLS = mem.NMLS.ToString().TrimEnd(),
                                                            Address = $"{Street} {City}, {State} {Zip}",
                                                            Approved = states,
                                                            BerkshireOfficeID = mem.BerkshireID,
                                                            Email = string.IsNullOrEmpty(agentSite.CustomEmail) ? agentSite.CorporateEmail : agentSite.CustomEmail,
                                                            Title = string.IsNullOrEmpty(agentSite.CustomTitle) ? agentSite.Title : agentSite.CustomTitle,
                                                            Channel = Channel.Name + " Lending",
                                                            BranchNMLS = branch.NMLS,
                                                            LOImageURL = "https://res.cloudinary.com/dvbdysuf5/a_exif,f_auto,g_faces,c_thumb,w_250,h_250,z_0.5,r_max/JV_Web_Resources/WHF/LO_Images/" + agentSite.PortraitURL,
                                                            TestimonialWidgedEnabled = sub.TestimonialTreeReviewsEnabled ?? false,
                                                            TestimonialWidgetID = mysite.TestimonialTreeWidgetID,
                                                            ApplyOnlineURL = mem.ApplyOnlineURL

                                                        });
                                                        match = true;
                                                    }
                                                }



                                            }
                                        }
                                    }
                                }
                                if (!match)
                                {
                                    var company = repo.Companies.FirstOrDefault(c => c.BrandCode == "WHF");
                                    var Channel = repo.Channels.FirstOrDefault(ch => ch.CompanyID == company.ID && ch.Name == "Retail");
                                    var agentSite = repo.Users.FirstOrDefault(m => m.CompanyID == company.ID && m.ChannelID == Channel.ID && m.EmployeeID == "CQD000052");
                                    var mem = repo.Members.FirstOrDefault(e => e.UserId == agentSite.ID);
                                    // Build licensed states list
                                    List<string> states = new List<string>();
                                    if (!string.IsNullOrEmpty(mem.StatesLicensed))
                                    {
                                        foreach (string token in mem.StatesLicensed.Split(','))
                                        {
                                            // ONLY accept two-letter state codes. Anything else is invalid and should be rejected.
                                            if (!string.IsNullOrEmpty(token))
                                            {
                                                string code = token.Trim();
                                                if (code.Length == 2)
                                                    states.Add(token);
                                            }
                                        }
                                    }
                                    // Check for custom fields first and set some defaults where needed.
                                    string loName = string.IsNullOrEmpty(agentSite.CustomFullName) ? agentSite.DisplayName : agentSite.CustomFullName;
                                    string loPhone = string.IsNullOrEmpty(agentSite.CustomOfficePhone) ? agentSite.Phone : agentSite.CustomOfficePhone;
                                    if (string.IsNullOrEmpty(loPhone))
                                        loPhone = "(925) 426-8383";
                                    string Street = string.IsNullOrEmpty(agentSite.CustomStreetAddress) ? agentSite.StreetAddress : agentSite.CustomStreetAddress;
                                    string City = string.IsNullOrEmpty(agentSite.CustomCity) ? agentSite.City : agentSite.CustomCity;
                                    string State = string.IsNullOrEmpty(agentSite.CustomState) ? agentSite.State : agentSite.CustomState;
                                    string Zip = string.IsNullOrEmpty(agentSite.CustomZipCode) ? agentSite.ZipCode : agentSite.CustomZipCode;
                                    var branch = repo.Branches.FirstOrDefault(b => b.ByteOrganizationID == mem.PrimaryBranchID);
                                    var sub = repo.MemberSubscriptions.FirstOrDefault(su => su.MemberID == mem.ID);
                                    var mysite = repo.MySites.FirstOrDefault(s => s.MemberID == mem.ID);
                                    if (mem.BerkshireID != null)
                                    {
                                        _logger.Debug("Inside berkshire");

                                       
                                                agents.Add(new LocatorConsultant()
                                                {
                                                    Name = loName,
                                                    FullURL = "www.welcomehomefunding.com/mysite/" + loName.Replace(" ", "-"),
                                                    User = mysite.Subdomain,
                                                    Phone = loPhone,
                                                    NMLS = mem.NMLS.ToString().TrimEnd(),
                                                    Address = $"{Street} {City}, {State} {Zip}",
                                                    Approved = states,
                                                    BerkshireOfficeID = mem.BerkshireID,
                                                    Email = string.IsNullOrEmpty(agentSite.CustomEmail) ? agentSite.CorporateEmail : agentSite.CustomEmail,
                                                    Title = string.IsNullOrEmpty(agentSite.CustomTitle) ? agentSite.Title : agentSite.CustomTitle,
                                                    Channel = Channel.Name + " Lending",
                                                    BranchNMLS = branch.NMLS,
                                                    LOImageURL = "https://res.cloudinary.com/dvbdysuf5/a_exif,f_auto,g_faces,c_thumb,w_250,h_250,z_0.5,r_max/JV_Web_Resources/WHF/LO_Images/" + agentSite.PortraitURL,
                                                    TestimonialWidgedEnabled = sub.TestimonialTreeReviewsEnabled ?? false,
                                                    TestimonialWidgetID = mysite.TestimonialTreeWidgetID,
                                                    ApplyOnlineURL = mem.ApplyOnlineURL

                                                });
                                                match = true;
                                            
                                    }

                                   
                                }
                            }
                           
                        }

                        string json = JsonConvert.SerializeObject(new { results = agents });
                        HttpContext.Current.Response.ContentType = "text/HTML";
                        HttpContext.Current.Response.Write(json);

                    }
                    
                    catch (Exception ex)
                    {
                        _logger.Debug(" > CMG webservice::GetLOInformation() exception: ", ex);

                    }
                }

            }
            catch (Exception ex)
               {
                    _logger.Debug(" > CMG webservice::GetLOInformationForOfficeID() exception: ", ex);

                    }
            }
        }
}
