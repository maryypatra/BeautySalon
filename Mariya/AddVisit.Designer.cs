namespace Mariya
{
    partial class AddVisit
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
            components = new System.ComponentModel.Container();
            textBoxMasterId = new TextBox();
            label2 = new Label();
            textBoxServiceId = new TextBox();
            label3 = new Label();
            textBoxClientId = new TextBox();
            label4 = new Label();
            label1 = new Label();
            textBoxStatus = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            button2 = new Button();
            comboBoxMaster = new ComboBox();
            masterBindingSource = new BindingSource(components);
            masterBindingSource1 = new BindingSource(components);
            comboBoxClient = new ComboBox();
            clientBindingSource = new BindingSource(components);
            comboBoxService = new ComboBox();
            serviceBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            masterIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitBindingSource = new BindingSource(components);
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxMasterId
            // 
            textBoxMasterId.BackColor = Color.LavenderBlush;
            textBoxMasterId.ForeColor = SystemColors.Info;
            textBoxMasterId.Location = new Point(177, 216);
            textBoxMasterId.Margin = new Padding(3, 2, 3, 2);
            textBoxMasterId.Name = "textBoxMasterId";
            textBoxMasterId.Size = new Size(10, 23);
            textBoxMasterId.TabIndex = 3;
            textBoxMasterId.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Фамилия мастера";
            label2.Click += label2_Click;
            // 
            // textBoxServiceId
            // 
            textBoxServiceId.BackColor = Color.LavenderBlush;
            textBoxServiceId.ForeColor = SystemColors.Info;
            textBoxServiceId.Location = new Point(219, 179);
            textBoxServiceId.Margin = new Padding(3, 2, 3, 2);
            textBoxServiceId.Name = "textBoxServiceId";
            textBoxServiceId.Size = new Size(10, 23);
            textBoxServiceId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 141);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Название услуги";
            // 
            // textBoxClientId
            // 
            textBoxClientId.BackColor = Color.LavenderBlush;
            textBoxClientId.ForeColor = SystemColors.Info;
            textBoxClientId.Location = new Point(235, 179);
            textBoxClientId.Margin = new Padding(3, 2, 3, 2);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(10, 23);
            textBoxClientId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 98);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 4;
            label4.Text = "Фамилия клиента";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 182);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 8;
            label1.Text = "Статус услуги";
            label1.Click += label1_Click;
            // 
            // textBoxStatus
            // 
            textBoxStatus.BackColor = Color.White;
            textBoxStatus.ForeColor = SystemColors.ControlText;
            textBoxStatus.Location = new Point(124, 179);
            textBoxStatus.Margin = new Padding(3, 2, 3, 2);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(152, 23);
            textBoxStatus.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(178, 276);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 28);
            button1.TabIndex = 12;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.LightCoral;
            dateTimePicker1.CalendarMonthBackground = Color.LightCoral;
            dateTimePicker1.Location = new Point(124, 216);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "Дата";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(13, 276);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(94, 28);
            button2.TabIndex = 14;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBoxMaster
            // 
            comboBoxMaster.Cursor = Cursors.No;
            comboBoxMaster.DataSource = masterBindingSource;
            comboBoxMaster.DisplayMember = "Surname";
            comboBoxMaster.FormattingEnabled = true;
            comboBoxMaster.Location = new Point(124, 56);
            comboBoxMaster.Name = "comboBoxMaster";
            comboBoxMaster.Size = new Size(152, 23);
            comboBoxMaster.TabIndex = 15;
            comboBoxMaster.ValueMember = "Id";
            comboBoxMaster.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // masterBindingSource
            // 
            masterBindingSource.DataSource = typeof(Data.Master);
            // 
            // masterBindingSource1
            // 
            masterBindingSource1.DataSource = typeof(Data.Master);
            // 
            // comboBoxClient
            // 
            comboBoxClient.DataSource = clientBindingSource;
            comboBoxClient.DisplayMember = "Surname";
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(124, 95);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(152, 23);
            comboBoxClient.TabIndex = 16;
            comboBoxClient.ValueMember = "Id";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Data.Client);
            // 
            // comboBoxService
            // 
            comboBoxService.DataSource = serviceBindingSource;
            comboBoxService.DisplayMember = "Name";
            comboBoxService.FormattingEnabled = true;
            comboBoxService.Location = new Point(124, 138);
            comboBoxService.Name = "comboBoxService";
            comboBoxService.Size = new Size(152, 23);
            comboBoxService.TabIndex = 17;
            comboBoxService.ValueMember = "Id";
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Data.Service);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, masterIdDataGridViewTextBoxColumn, clientIdDataGridViewTextBoxColumn, serviceIdDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = visitBindingSource;
            dataGridView1.Location = new Point(219, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(10, 10);
            dataGridView1.TabIndex = 18;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // masterIdDataGridViewTextBoxColumn
            // 
            masterIdDataGridViewTextBoxColumn.DataPropertyName = "MasterId";
            masterIdDataGridViewTextBoxColumn.HeaderText = "MasterId";
            masterIdDataGridViewTextBoxColumn.Name = "masterIdDataGridViewTextBoxColumn";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // visitBindingSource
            // 
            visitBindingSource.DataSource = typeof(Data.Visit);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 19);
            label6.Name = "label6";
            label6.Size = new Size(278, 25);
            label6.TabIndex = 19;
            label6.Text = "Добавление новго посещения";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 244);
            label7.Name = "label7";
            label7.Size = new Size(205, 60);
            label7.TabIndex = 20;
            label7.Text = "Для добавления с новым\r\nмастером/клиентом/услугой\r\nнеобходимо сначала внести \r\nданные в соответсвующую таблицу";
            // 
            // AddVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 315);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxService);
            Controls.Add(comboBoxClient);
            Controls.Add(comboBoxMaster);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBoxStatus);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBoxServiceId);
            Controls.Add(textBoxClientId);
            Controls.Add(textBoxMasterId);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddVisit";
            Text = "AddVisit";
            Load += AddVisit_Load;
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxMasterId;
        private Label label2;
        private TextBox textBoxServiceId;
        private Label label3;
        private TextBox textBoxClientId;
        private Label label4;
        private Label label1;
        private TextBox textBoxStatus;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button2;
        private ComboBox comboBoxMaster;
        private BindingSource masterBindingSource;
        private BindingSource masterBindingSource1;
        private ComboBox comboBoxClient;
        private ComboBox comboBoxService;
        private BindingSource clientBindingSource;
        private BindingSource serviceBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masterIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource visitBindingSource;
        private Label label6;
        private Label label7;
    }
}