using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMG.Database.CMGPortal.Models
{
    [Table("Channels")]
    public class Channel
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public int ChannelManagerID { get; set; }

        //[ForeignKey("CompanyID")]
        //public Company Company { get; set; }
    }
}
