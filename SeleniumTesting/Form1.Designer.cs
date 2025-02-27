namespace SeleniumTesting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ResultTable = new DataGridView();
            Field = new DataGridViewTextBoxColumn();
            Locator = new DataGridViewComboBoxColumn();
            Action = new DataGridViewComboBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Exception = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewButtonColumn();
            Clear = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)ResultTable).BeginInit();
            SuspendLayout();
            // 
            // ResultTable
            // 
            ResultTable.AllowUserToResizeColumns = false;
            ResultTable.AllowUserToResizeRows = false;
            ResultTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ResultTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ResultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultTable.Columns.AddRange(new DataGridViewColumn[] { Field, Locator, Action, ID, Value, Status, Exception, Remove });
            ResultTable.Dock = DockStyle.Top;
            ResultTable.Location = new Point(0, 0);
            ResultTable.Name = "ResultTable";
            ResultTable.RowHeadersVisible = false;
            ResultTable.Size = new Size(784, 439);
            ResultTable.TabIndex = 0;
            ResultTable.CellContentClick += ResultTable_CellContentClick;
            // 
            // Field
            // 
            Field.HeaderText = "Field";
            Field.Name = "Field";
            // 
            // Locator
            // 
            Locator.HeaderText = "Locator";
            Locator.Items.AddRange(new object[] { "ID", "Name", "Xpath", "CSS" });
            Locator.Name = "Locator";
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Items.AddRange(new object[] { "Click", "Type" });
            Action.Name = "Action";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.True;
            // 
            // Exception
            // 
            Exception.HeaderText = "Exception";
            Exception.Name = "Exception";
            Exception.ReadOnly = true;
            // 
            // Remove
            // 
            Remove.HeaderText = "Remove";
            Remove.Name = "Remove";
            Remove.Resizable = DataGridViewTriState.True;
            Remove.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Clear
            // 
            Clear.Dock = DockStyle.Right;
            Clear.Location = new Point(484, 439);
            Clear.Name = "Clear";
            Clear.Size = new Size(300, 122);
            Clear.TabIndex = 2;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(0, 439);
            button2.Name = "button2";
            button2.Size = new Size(300, 122);
            button2.TabIndex = 3;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += StartTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button2);
            Controls.Add(Clear);
            Controls.Add(ResultTable);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ResultTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ResultTable;
        private Button Clear;
        private Button button2;
        private DataGridViewTextBoxColumn Field;
        private DataGridViewComboBoxColumn Locator;
        private DataGridViewComboBoxColumn Action;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn Exception;
        private DataGridViewButtonColumn Remove;
    }
}
