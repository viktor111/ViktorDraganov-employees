namespace ViktorDraganov_employees
{
    using ViktorDraganov_employees.Dtos;
    using ViktorDraganov_employees.Services;


    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ImportFileButton_Click(object sender, EventArgs e)
        {            
            var fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var fileToOpen = fd.FileName;

                var file = new FileInfo(fd.FileName);

                FileNameLabel.Text = file.Name;

                var reader = new StreamReader(fileToOpen);

                var txtReaderService = new TxtFileReaderService(file.FullName);
                var pairCalculatorService = new PairCalculatorService();

                var lines = txtReaderService.GetLines();

                var pairs = pairCalculatorService.GetPairs(lines);

                for (int i = 0; i < pairs.Count; i++)
                {
                    var pair = pairs[i];

                    var row = new string[] 
                    {
                        pair.EmployeeId1.ToString(),
                        pair.EmployeeId2.ToString(),
                        pair.ProjectId.ToString(),
                        pair.DaysWorked.ToString()
                    };

                    var listViewItem = new ListViewItem(row);

                    EmployeesListView.Items.Add(listViewItem);
                }
            }
        }

        private void ClearDataButton_Click(object sender, EventArgs e)
        {
            EmployeesListView.Items.Clear();
        }
    }
}
