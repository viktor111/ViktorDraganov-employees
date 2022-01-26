namespace ViktorDraganov_employees.Services
{
    using Models.TxtFile;
    using Common;
    using Services.Exceptions;

    public class TxtFileReaderService
    {
        internal TxtFileReaderService(string filePath)
        {
            this.ValidateFilePath(filePath);

            this.FilePath = filePath;
        }

        public string FilePath { get; private set; }

        public List<Line> GetLines()
        {
            var lines = new List<Line>();

            var linesFromFile = this.getLinesFromFile(this.FilePath);

            if (linesFromFile == null)
            {
                throw new TxtReaderServiceException("Null line discovered in file!");
            }

            for (int i = 0; i < linesFromFile.Length; i++)
            {
                var lineString = linesFromFile[i].Split(",");

                if (string.IsNullOrEmpty(lineString[0]) ||
                    string.IsNullOrEmpty(lineString[1]))
                {
                    throw new TxtReaderServiceException("Null or empty elemnt discoverd in file!");
                }

                var empId = int.Parse(lineString[0]);
                var projectId = int.Parse(lineString[1]);

                var dateFrom = new DateTime();
                var dateTo = new DateTime();

                if (lineString[2].Trim() != "NULL")
                {
                    dateFrom = DateTime.Parse(lineString[2]);
                    
                }
                else
                {
                    dateFrom = DateTime.Now;
                }
                if (lineString[3].Trim() != "NULL")
                {
                    dateTo = DateTime.Parse(lineString[3]);

                }
                else
                {
                    dateTo = DateTime.Now;
                }

                var line = new Line(empId, projectId, dateFrom, dateTo);

                lines.Add(line);
            }

            return lines;
        }

        public TxtFileReaderService UpdatePath(string filePath)
        {
           this.ValidateFilePath(filePath);
            this.FilePath = filePath;
            return this;
        }

        private void ValidateFilePath(string filePath)
        {
            Guard.AgainstEmptyString<TxtReaderServiceException>(filePath);
        }

        private string[] getLinesFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            return lines;
        }
    }
}
