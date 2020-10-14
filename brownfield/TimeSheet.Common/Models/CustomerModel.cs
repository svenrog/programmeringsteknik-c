using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Common.Models
{
    public class CustomerModel
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
