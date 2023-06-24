
namespace WindowsFormsApp1
{
    partial class Appointments
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
            this.appointmentbymonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet3 = new WindowsFormsApp1.client_scheduleDataSet3();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.client_scheduleDataSet2 = new WindowsFormsApp1.client_scheduleDataSet2();
            this.clientscheduleDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentbyweekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentbyweekTableAdapter = new WindowsFormsApp1.client_scheduleDataSet2TableAdapters.appointmentbyweekTableAdapter();
            this.appointmentbymonthTableAdapter = new WindowsFormsApp1.client_scheduleDataSet3TableAdapters.appointmentbymonthTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentbymonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientscheduleDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentbyweekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 277);
            this.dataGridView1.TabIndex = 20;
            // 
            // appointmentbymonthBindingSource
            // 
            this.appointmentbymonthBindingSource.DataMember = "appointmentbymonth";
            this.appointmentbymonthBindingSource.DataSource = this.client_scheduleDataSet3;
            // 
            // client_scheduleDataSet3
            // 
            this.client_scheduleDataSet3.DataSetName = "client_scheduleDataSet3";
            this.client_scheduleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(ClassLibrary3.appointment);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(540, 289);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(428, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(151, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit  selected";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(290, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "View  selected";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCyan;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(290, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 45);
            this.button5.TabIndex = 7;
            this.button5.Text = "Current week";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCyan;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(428, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 45);
            this.button6.TabIndex = 8;
            this.button6.Text = "Current Month";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // client_scheduleDataSet2
            // 
            this.client_scheduleDataSet2.DataSetName = "client_scheduleDataSet2";
            this.client_scheduleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientscheduleDataSet2BindingSource
            // 
            this.clientscheduleDataSet2BindingSource.DataSource = this.client_scheduleDataSet2;
            this.clientscheduleDataSet2BindingSource.Position = 0;
            // 
            // appointmentbyweekBindingSource
            // 
            this.appointmentbyweekBindingSource.DataMember = "appointmentbyweek";
            this.appointmentbyweekBindingSource.DataSource = this.clientscheduleDataSet2BindingSource;
            // 
            // appointmentbyweekTableAdapter
            // 
            this.appointmentbyweekTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentbymonthTableAdapter
            // 
            this.appointmentbymonthTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCyan;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(151, 380);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Show all";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(123, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "All appointments must be between 9AM - 5PM Central Time ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightCyan;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(12, 309);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 45);
            this.button8.TabIndex = 1;
            this.button8.Text = "Delete  selected";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Appointments";
            this.Text = "View Appointments";
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentbymonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientscheduleDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentbyweekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource clientscheduleDataSet2BindingSource;
        private client_scheduleDataSet2 client_scheduleDataSet2;
        private System.Windows.Forms.BindingSource appointmentbyweekBindingSource;
        private client_scheduleDataSet2TableAdapters.appointmentbyweekTableAdapter appointmentbyweekTableAdapter;
        private client_scheduleDataSet3 client_scheduleDataSet3;
        private System.Windows.Forms.BindingSource appointmentbymonthBindingSource;
        private client_scheduleDataSet3TableAdapters.appointmentbymonthTableAdapter appointmentbymonthTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
    }
}