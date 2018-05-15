using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DA.Models
{
    public class Request : BaseEntity
    {
        public Request() {
            Approvals = new HashSet<RequestApproval>();
            RequiredApprovals = new HashSet<RequiredApproval>();
            Branches = new HashSet<Branch>();
        }
        public Int32 Id { get; set; }
        public string RequestDescription { get; set; }
        public Int32 Status { get; set; }
        public Guid WorkflowInstanceId { get; set; }
        public string BookMark { get; set; }
        public ICollection<POSRequest> POSRequest { get; set; }
        public Boolean WithRequirements { get; set; }
        public Boolean WithException { get; set; }
        public ICollection<RequiredApproval> RequiredApprovals { get; set; }
        public ICollection<RequestApproval> Approvals { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public int RequestType { get; set; }
        public string eMail { get; set; }
    }

}