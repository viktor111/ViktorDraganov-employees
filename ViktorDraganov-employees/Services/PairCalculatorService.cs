namespace ViktorDraganov_employees.Services
{
    using Dtos;
    using Models.TxtFile;

    public class PairCalculatorService
    {
        public List<EmployeePairDto> GetPairs(List<Line> lines)
        {
            var pairs = new List<EmployeePairDto>();

            for (int i = 0; i < lines.Count; i++)
            {
                if((i + 1) < lines.Count)
                {
                    var line = lines[i];
                    var nextLine = lines[i + 1];

                    if(line.ProjectId == nextLine.ProjectId)
                    {
                        var pair = new EmployeePairDto();

                        var firstTotalWork = (line.DateTo - line.DateFrom).Days;
                        var secondTotalWork = (nextLine.DateTo - nextLine.DateFrom).Days;

                        var totalWorkedDays = firstTotalWork + secondTotalWork;

                        pair.EmployeeId1 = line.EmpId;
                        pair.EmployeeId2 = nextLine.EmpId;
                        pair.ProjectId = line.ProjectId;
                        pair.DaysWorked = totalWorkedDays; 
                        
                        pairs.Add(pair);
                    }
                }             
            }

            return pairs;
        }
    }
}
