
namespace WindowsFormsApp1
{
    partial class CustomerRecords
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
            this.custviewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tHISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHIS = new WindowsFormsApp1.THIS();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.custviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.custviewTableAdapter1 = new WindowsFormsApp1.THISTableAdapters.custviewTableAdapter();
            this.custviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet = new WindowsFormsApp1.client_scheduleDataSet();
            this.custviewTableAdapter = new WindowsFormsApp1.client_scheduleDataSetTableAdapters.custviewTableAdapter();
            this.custviewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tHISBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custviewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custviewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHISBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 343);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // custviewBindingSource3
            // 
            this.custviewBindingSource3.DataMember = "custview";
            this.custviewBindingSource3.DataSource = this.tHISBindingSource;
            // 
            // tHISBindingSource
            // 
            this.tHISBindingSource.DataSource = this.tHIS;
            this.tHISBindingSource.Position = 0;
            // 
            // tHIS
            // 
            this.tHIS.DataSetName = "THIS";
            this.tHIS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Location = new System.Drawing.Point(71, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Selected";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Location = new System.Drawing.Point(213, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Selected";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Location = new System.Drawing.Point(357, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add New";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Location = new System.Drawing.Point(646, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "Go Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // custviewBindingSource1
            // 
            this.custviewBindingSource1.DataMember = "custview";
            this.custviewBindingSource1.DataSource = this.tHIS;
            // 
            // custviewTableAdapter1
            // 
            this.custviewTableAdapter1.ClearBeforeFill = true;
            // 
            // custviewBindingSource
            // 
            this.custviewBindingSource.DataMember = "custview";
            this.custviewBindingSource.DataSource = this.client_scheduleDataSet;
            // 
            // client_scheduleDataSet
            // 
            this.client_scheduleDataSet.DataSetName = "client_scheduleDataSet";
            this.client_scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custviewTableAdapter
            // 
            this.custviewTableAdapter.ClearBeforeFill = true;
            // 
            // custviewBindingSource2
            // 
            this.custviewBindingSource2.DataMember = "custview";
            this.custviewBindingSource2.DataSource = this.tHISBindingSource;
            // 
            // tHISBindingSource1
            // 
            this.tHISBindingSource1.DataSource = this.tHIS;
            this.tHISBindingSource1.Position = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCyan;
            this.button5.Location = new System.Drawing.Point(495, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete Selected";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CustomerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerRecords";
            this.Text = "Customer Records";
            this.Load += new System.EventHandler(this.CustomerRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custviewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custviewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHISBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private client_scheduleDataSet client_scheduleDataSet;
        private System.Windows.Forms.BindingSource custviewBindingSource;
        private client_scheduleDataSetTableAdapters.custviewTableAdapter custviewTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private THIS tHIS;
        private System.Windows.Forms.BindingSource custviewBindingSource1;
        private THISTableAdapters.custviewTableAdapter custviewTableAdapter1;
        private System.Windows.Forms.BindingSource tHISBindingSource;
        private System.Windows.Forms.BindingSource custviewBindingSource2;
        private System.Windows.Forms.BindingSource custviewBindingSource3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tHISBindingSource1;
        private System.Windows.Forms.Button button5;
    }
}