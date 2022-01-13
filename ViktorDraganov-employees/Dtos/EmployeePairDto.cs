using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViktorDraganov_employees.Dtos
{
    public class EmployeePairDto
    {
        public int EmployeeId1 { get; set; }

        public int EmployeeId2 { get; set; }

        public int ProjectId { get; set; }

        public int DaysWorked { get; set; }
    }
}
