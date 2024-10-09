namespace DB_ACT1_046_Pattaguan
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
            txtKeyword = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            dtgResults = new DataGridView();
            cboBrand = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgResults).BeginInit();
            SuspendLayout();
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(59, 56);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(183, 23);
            txtKeyword.TabIndex = 0;
            txtKeyword.TextChanged += txtKeyword_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(59, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 31);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(162, 105);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(80, 31);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dtgResults
            // 
            dtgResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgResults.Location = new Point(59, 159);
            dtgResults.MultiSelect = false;
            dtgResults.Name = "dtgResults";
            dtgResults.ReadOnly = true;
            dtgResults.RowHeadersVisible = false;
            dtgResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgResults.Size = new Size(536, 279);
            dtgResults.TabIndex = 3;
            // 
            // cboBrand
            // 
            cboBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBrand.FormattingEnabled = true;
            cboBrand.Items.AddRange(new object[] { "Acura", "Aston Martin", "Audi", "Bentley", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Eagle", "Ford", "Geo", "GMC", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jeep", "Kia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "Mercedes-Benz", "Mercury", "Mitsubishi", "Nissan", "Oldsmobile", "Plymouth", "Pontiac", "Porsche", "Ram", "Saab", "Saturn", "Scion", "Shelby", "Spyker", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo" });
            cboBrand.Location = new Point(284, 56);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(121, 23);
            cboBrand.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboBrand);
            Controls.Add(dtgResults);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(txtKeyword);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKeyword;
        private Button btnSearch;
        private Button btnReset;
        private DataGridView dtgResults;
        private ComboBox cboBrand;
    }
}
