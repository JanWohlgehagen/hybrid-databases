using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowModels.Models
{
    public class DamageReport
    {
        public required int Id { get; set; }
        public string Description { get; set; } = "";
        public required Customer Customer { get; set; }
        public DateTime ReportedAt { get; set; }
        public required string ReportedBy { get; set; }
        public required decimal RepairCost { get; set; }
        public required decimal HourlyLaborRate { get; set; }
        public required int WorkHoursRequired { get; set; }
        public decimal TotalCost
        {
            get
            {
                return RepairCost + (HourlyLaborRate * WorkHoursRequired);
            }
        }
    }
}
