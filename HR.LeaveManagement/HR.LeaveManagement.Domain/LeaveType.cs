using System;
using HR.LeaveManagement.Domain.common;
using System.Collections.Generic;
using System.Text;


namespace HR.LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}