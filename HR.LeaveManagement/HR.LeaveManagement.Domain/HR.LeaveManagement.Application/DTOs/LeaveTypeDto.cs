using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTOs.Common;


namespace HR.LeaveManagement.Application.DTOs
{
    public abstract class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
