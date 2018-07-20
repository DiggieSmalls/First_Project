namespace PasswordSafe
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordSafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.password_safeDataSet = new PasswordSafe.Password_safeDataSet();
            this.passwordSafeTableAdapter = new PasswordSafe.Password_safeDataSetTableAdapters.PasswordSafeTableAdapter();
            this.NewEntrybutton = new System.Windows.Forms.Button();
            this.CloseSafebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordSafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_safeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.passwordSafeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordSafeBindingSource
            // 
            this.passwordSafeBindingSource.DataMember = "PasswordSafe";
            this.passwordSafeBindingSource.DataSource = this.password_safeDataSet;
            // 
            // password_safeDataSet
            // 
            this.password_safeDataSet.DataSetName = "Password_safeDataSet";
            this.password_safeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordSafeTableAdapter
            // 
            this.passwordSafeTableAdapter.ClearBeforeFill = true;
            // 
            // NewEntrybutton
            // 
            this.NewEntrybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEntrybutton.Location = new System.Drawing.Point(365, 239);
            this.NewEntrybutton.Name = "NewEntrybutton";
            this.NewEntrybutton.Size = new System.Drawing.Size(116, 52);
            this.NewEntrybutton.TabIndex = 1;
            this.NewEntrybutton.Text = "Add Entry";
            this.NewEntrybutton.UseVisualStyleBackColor = true;
            this.NewEntrybutton.Click += new System.EventHandler(this.NewEntrybutton_Click);
            // 
            // CloseSafebutton
            // 
            this.CloseSafebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSafebutton.Location = new System.Drawing.Point(365, 297);
            this.CloseSafebutton.Name = "CloseSafebutton";
            this.CloseSafebutton.Size = new System.Drawing.Size(116, 52);
            this.CloseSafebutton.TabIndex = 1;
            this.CloseSafebutton.Text = "Exit";
            this.CloseSafebutton.UseVisualStyleBackColor = true;
            this.CloseSafebutton.Click += new System.EventHandler(this.CloseSafebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "PasswordSafe";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseSafebutton);
            this.Controls.Add(this.NewEntrybutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "PasswordSafe";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordSafeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_safeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Password_safeDataSet password_safeDataSet;
        private System.Windows.Forms.BindingSource passwordSafeBindingSource;
        private Password_safeDataSetTableAdapters.PasswordSafeTableAdapter passwordSafeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button NewEntrybutton;
        private System.Windows.Forms.Button CloseSafebutton;
        private System.Windows.Forms.Label label1;
    }
}