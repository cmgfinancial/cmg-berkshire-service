using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMG.Database.CMGPortal.Models
{
    [Table("MemberTeams")]
    public partial class MemberTeam
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int TeamId { get; set; }

       // public virtual Member Member { get; set; }
        //public virtual Team Team { get; set; }


    }
}
