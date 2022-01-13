namespace ViktorDraganov_employees
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesListView = new System.Windows.Forms.ListView();
            this.EmployeeId1Col = new System.Windows.Forms.ColumnHeader();
            this.EmployeeId2Col = new System.Windows.Forms.ColumnHeader();
            this.ProjectIdCol = new System.Windows.Forms.ColumnHeader();
            this.DaysWorkedCol = new System.Windows.Forms.ColumnHeader();
            this.ImportFileButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.ClearDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeesListView
            // 
            this.EmployeesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeId1Col,
            this.EmployeeId2Col,
            this.ProjectIdCol,
            this.DaysWorkedCol});
            this.EmployeesListView.Location = new System.Drawing.Point(12, 144);
            this.EmployeesListView.Name = "EmployeesListView";
            this.EmployeesListView.Size = new System.Drawing.Size(423, 294);
            this.EmployeesListView.TabIndex = 0;
            this.EmployeesListView.UseCompatibleStateImageBehavior = false;
            this.EmployeesListView.View = System.Windows.Forms.View.Details;
            // 
            // EmployeeId1Col
            // 
            this.EmployeeId1Col.Text = "EmployeeId1";
            this.EmployeeId1Col.Width = 100;
            // 
            // EmployeeId2Col
            // 
            this.EmployeeId2Col.Text = "EmployeeId2";
            this.EmployeeId2Col.Width = 100;
            // 
            // ProjectIdCol
            // 
            this.ProjectIdCol.Text = "ProjectId";
            this.ProjectIdCol.Width = 100;
            // 
            // DaysWorkedCol
            // 
            this.DaysWorkedCol.Text = "DaysWorked";
            this.DaysWorkedCol.Width = 100;
            // 
            // ImportFileButton
            // 
            this.ImportFileButton.Location = new System.Drawing.Point(12, 12);
            this.ImportFileButton.Name = "ImportFileButton";
            this.ImportFileButton.Size = new System.Drawing.Size(126, 23);
            this.ImportFileButton.TabIndex = 1;
            this.ImportFileButton.Text = "Import From File";
            this.ImportFileButton.UseVisualStyleBackColor = true;
            this.ImportFileButton.Click += new System.EventHandler(this.ImportFileButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(330, 16);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 15);
            this.FileNameLabel.TabIndex = 2;
            // 
            // ClearDataButton
            // 
            this.ClearDataButton.Location = new System.Drawing.Point(12, 51);
            this.ClearDataButton.Name = "ClearDataButton";
            this.ClearDataButton.Size = new System.Drawing.Size(126, 23);
            this.ClearDataButton.TabIndex = 3;
            this.ClearDataButton.Text = "Clear Data";
            this.ClearDataButton.UseVisualStyleBackColor = true;
            this.ClearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "File:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearDataButton);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.ImportFileButton);
            this.Controls.Add(this.EmployeesListView);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView EmployeesListView;
        private ColumnHeader EmployeeId1Col;
        private ColumnHeader EmployeeId2Col;
        private ColumnHeader ProjectIdCol;
        private ColumnHeader DaysWorkedCol;
        private Button ImportFileButton;
        private Label FileNameLabel;
        private Button ClearDataButton;
        private Label label1;
    }
}