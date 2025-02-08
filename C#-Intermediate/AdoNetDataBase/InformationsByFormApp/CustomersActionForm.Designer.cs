namespace CreateWiewScreeanOfAdoNet
{
    partial class CustomersActionForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtAgeUpdate = new System.Windows.Forms.TextBox();
            this.lblAgeUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtSalaryUpdate = new System.Windows.Forms.TextBox();
            this.lblSalaryUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(920, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Adı";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(15, 108);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(41, 15);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Maaşı:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 26);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(122, 103);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(110, 23);
            this.txtSalary.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(191, 134);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 22);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.txtAge);
            this.gbxAdd.Controls.Add(this.lblAge);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.txtName);
            this.gbxAdd.Controls.Add(this.txtSalary);
            this.gbxAdd.Controls.Add(this.lblSalary);
            this.gbxAdd.Location = new System.Drawing.Point(10, 201);
            this.gbxAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAdd.Size = new System.Drawing.Size(293, 160);
            this.gbxAdd.TabIndex = 8;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Müşteri Ekle";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(122, 66);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(110, 23);
            this.txtAge.TabIndex = 9;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 66);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(27, 15);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Yaşı";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.txtAgeUpdate);
            this.gbxUpdate.Controls.Add(this.lblAgeUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.Update);
            this.gbxUpdate.Controls.Add(this.txtNameUpdate);
            this.gbxUpdate.Controls.Add(this.txtSalaryUpdate);
            this.gbxUpdate.Controls.Add(this.lblSalaryUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(324, 201);
            this.gbxUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxUpdate.Size = new System.Drawing.Size(293, 160);
            this.gbxUpdate.TabIndex = 9;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Müşteri Güncelle";
          
            // 
            // txtAgeUpdate
            // 
            this.txtAgeUpdate.Location = new System.Drawing.Point(122, 66);
            this.txtAgeUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgeUpdate.Name = "txtAgeUpdate";
            this.txtAgeUpdate.Size = new System.Drawing.Size(110, 23);
            this.txtAgeUpdate.TabIndex = 9;
            // 
            // lblAgeUpdate
            // 
            this.lblAgeUpdate.AutoSize = true;
            this.lblAgeUpdate.Location = new System.Drawing.Point(15, 66);
            this.lblAgeUpdate.Name = "lblAgeUpdate";
            this.lblAgeUpdate.Size = new System.Drawing.Size(27, 15);
            this.lblAgeUpdate.TabIndex = 8;
            this.lblAgeUpdate.Text = "Yaşı";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(15, 26);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(25, 15);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Adı";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(191, 134);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(82, 22);
            this.Update.TabIndex = 7;
            this.Update.Text = "Güncelle";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(122, 26);
            this.txtNameUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(110, 23);
            this.txtNameUpdate.TabIndex = 4;
            // 
            // txtSalaryUpdate
            // 
            this.txtSalaryUpdate.Location = new System.Drawing.Point(122, 103);
            this.txtSalaryUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalaryUpdate.Name = "txtSalaryUpdate";
            this.txtSalaryUpdate.Size = new System.Drawing.Size(110, 23);
            this.txtSalaryUpdate.TabIndex = 6;
            // 
            // lblSalaryUpdate
            // 
            this.lblSalaryUpdate.AutoSize = true;
            this.lblSalaryUpdate.Location = new System.Drawing.Point(15, 108);
            this.lblSalaryUpdate.Name = "lblSalaryUpdate";
            this.lblSalaryUpdate.Size = new System.Drawing.Size(41, 15);
            this.lblSalaryUpdate.TabIndex = 3;
            this.lblSalaryUpdate.Text = "Maaşı:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(748, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 53);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CustomersActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 390);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomersActionForm";
            this.Text = "CustomersActionForm";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblName;
        private Label lblSalary;
        private TextBox txtName;
        private TextBox txtSalary;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAdd;
        private GroupBox gbxAdd;
        private TextBox txtAge;
        private Label lblAge;
        private GroupBox gbxUpdate;
        private TextBox txtAgeUpdate;
        private Label lblAgeUpdate;
        private Label lblNameUpdate;
        private Button Update;
        private TextBox txtNameUpdate;
        private TextBox txtSalaryUpdate;
        private Label lblSalaryUpdate;
        private Button btnDelete;
    }
}