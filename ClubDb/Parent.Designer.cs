
namespace ClubDb
{
    partial class Parent
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ClubDb.DataSet1();
            this.parentTableAdapter = new ClubDb.DataSet1TableAdapters.ParentTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(249, 370);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 22);
            this.textBox4.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Parent Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Parent Phone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 79);
            this.button1.TabIndex = 26;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(249, 330);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 22);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 22);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Parent Lname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Parent Fname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Parent ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parentIDDataGridViewTextBoxColumn,
            this.parentFnameDataGridViewTextBoxColumn,
            this.parentLnameDataGridViewTextBoxColumn,
            this.parentPhoneDataGridViewTextBoxColumn,
            this.parentAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 195);
            this.dataGridView1.TabIndex = 19;
            // 
            // parentIDDataGridViewTextBoxColumn
            // 
            this.parentIDDataGridViewTextBoxColumn.DataPropertyName = "Parent_ID";
            this.parentIDDataGridViewTextBoxColumn.HeaderText = "Parent_ID";
            this.parentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentIDDataGridViewTextBoxColumn.Name = "parentIDDataGridViewTextBoxColumn";
            this.parentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentFnameDataGridViewTextBoxColumn
            // 
            this.parentFnameDataGridViewTextBoxColumn.DataPropertyName = "Parent_Fname";
            this.parentFnameDataGridViewTextBoxColumn.HeaderText = "Parent_Fname";
            this.parentFnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentFnameDataGridViewTextBoxColumn.Name = "parentFnameDataGridViewTextBoxColumn";
            this.parentFnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentLnameDataGridViewTextBoxColumn
            // 
            this.parentLnameDataGridViewTextBoxColumn.DataPropertyName = "Parent_Lname";
            this.parentLnameDataGridViewTextBoxColumn.HeaderText = "Parent_Lname";
            this.parentLnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentLnameDataGridViewTextBoxColumn.Name = "parentLnameDataGridViewTextBoxColumn";
            this.parentLnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentPhoneDataGridViewTextBoxColumn
            // 
            this.parentPhoneDataGridViewTextBoxColumn.DataPropertyName = "Parent_Phone";
            this.parentPhoneDataGridViewTextBoxColumn.HeaderText = "Parent_Phone";
            this.parentPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentPhoneDataGridViewTextBoxColumn.Name = "parentPhoneDataGridViewTextBoxColumn";
            this.parentPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentAddressDataGridViewTextBoxColumn
            // 
            this.parentAddressDataGridViewTextBoxColumn.DataPropertyName = "Parent_Address";
            this.parentAddressDataGridViewTextBoxColumn.HeaderText = "Parent_Address";
            this.parentAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentAddressDataGridViewTextBoxColumn.Name = "parentAddressDataGridViewTextBoxColumn";
            this.parentAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentBindingSource
            // 
            this.parentBindingSource.DataMember = "Parent";
            this.parentBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parentTableAdapter
            // 
            this.parentTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(249, 408);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 22);
            this.textBox5.TabIndex = 30;
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Parent";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource parentBindingSource;
        private DataSet1TableAdapters.ParentTableAdapter parentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox5;
    }
}