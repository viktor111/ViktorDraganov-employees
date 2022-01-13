namespace ViktorDraganov_employees.Models.TxtFile
{
    using Exceptions;
    using Common;

    public class Line
    { 
        internal Line(int empId,
            int projectId,
            DateTime dateFrom, 
            DateTime dateTo)
        {
            this.Validate(empId, projectId);

            this.EmpId = empId;
            this.ProjectId = projectId;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
        }

        public int EmpId { get; private set; }

        public int ProjectId { get; private set; }

        public DateTime DateFrom { get; private set; }

        public DateTime DateTo { get; private set; }

        public Line UpdateEmpId(int empId)
        {
            this.ValidateEmpId(empId);
            this.EmpId = empId;
            return this;
        }

        public Line UpdateProjectId(int projectId)
        {
            this.ValidateProjectId(projectId);
            this.ProjectId = projectId;
            return this;
        }

        public Line UpdateDatFrom(DateTime dateFrom)
        {
            this.DateFrom = dateFrom;
            return this;
        }

        public Line UpdateDateTo(DateTime dateTo)
        {
            this.DateFrom = dateTo;
            return this;
        }


        private void Validate(int empId, int projectId)
        {
            this.ValidateEmpId(empId);
            this.ValidateProjectId(projectId);
        }

        private void ValidateEmpId(int empId)
        {
            Guard.AgainstOutOfRange<LineNotValidException>(
                empId,
                1,
                int.MaxValue,nameof(this.EmpId));
        }

        private void ValidateProjectId(int projectId)
        {
            Guard.AgainstOutOfRange<LineNotValidException>(
                projectId,
                1,
                int.MaxValue, nameof(this.ProjectId));
        }
    }
}
