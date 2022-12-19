namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDelName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnDelName = new System.Windows.Forms.Button();
            this.btnDelID = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDelLabel = new System.Windows.Forms.Button();
            this.btnAddLabel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameprocess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koldata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDelName
            // 
            this.textBoxDelName.Location = new System.Drawing.Point(441, 12);
            this.textBoxDelName.Multiline = true;
            this.textBoxDelName.Name = "textBoxDelName";
            this.textBoxDelName.Size = new System.Drawing.Size(202, 20);
            this.textBoxDelName.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(441, 389);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Click += new System.EventHandler(this.textBoxName_Click);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(580, 389);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(209, 20);
            this.textBoxPath.TabIndex = 3;
            this.textBoxPath.Click += new System.EventHandler(this.textBoxID_Click);
            this.textBoxPath.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // btnDelName
            // 
            this.btnDelName.Location = new System.Drawing.Point(649, 12);
            this.btnDelName.Name = "btnDelName";
            this.btnDelName.Size = new System.Drawing.Size(139, 20);
            this.btnDelName.TabIndex = 4;
            this.btnDelName.Text = "Удалить по имени";
            this.btnDelName.UseVisualStyleBackColor = true;
            this.btnDelName.Click += new System.EventHandler(this.btnDelName_Click);
            // 
            // btnDelID
            // 
            this.btnDelID.Location = new System.Drawing.Point(441, 38);
            this.btnDelID.Name = "btnDelID";
            this.btnDelID.Size = new System.Drawing.Size(347, 23);
            this.btnDelID.TabIndex = 5;
            this.btnDelID.Text = "Удалить выделенный процесс";
            this.btnDelID.UseVisualStyleBackColor = true;
            this.btnDelID.Click += new System.EventHandler(this.btnDelID_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(441, 360);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(170, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Запустить";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnDelLabel
            // 
            this.btnDelLabel.Location = new System.Drawing.Point(617, 360);
            this.btnDelLabel.Name = "btnDelLabel";
            this.btnDelLabel.Size = new System.Drawing.Size(172, 23);
            this.btnDelLabel.TabIndex = 7;
            this.btnDelLabel.Text = "Удалить ярлык";
            this.btnDelLabel.UseVisualStyleBackColor = true;
            this.btnDelLabel.Click += new System.EventHandler(this.btnDelLabel_Click);
            // 
            // btnAddLabel
            // 
            this.btnAddLabel.Location = new System.Drawing.Point(442, 415);
            this.btnAddLabel.Name = "btnAddLabel";
            this.btnAddLabel.Size = new System.Drawing.Size(347, 23);
            this.btnAddLabel.TabIndex = 8;
            this.btnAddLabel.Text = "Добавить ярлык";
            this.btnAddLabel.UseVisualStyleBackColor = true;
            this.btnAddLabel.Click += new System.EventHandler(this.btnAddLabel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(441, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 264);
            this.listBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nameprocess,
            this.koldata});
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 427);
            this.dataGridView1.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nameprocess
            // 
            this.nameprocess.HeaderText = "Имя процесса";
            this.nameprocess.Name = "nameprocess";
            this.nameprocess.ReadOnly = true;
            // 
            // koldata
            // 
            this.koldata.HeaderText = "Количество занимаемой памяти";
            this.koldata.Name = "koldata";
            this.koldata.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(442, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(346, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddLabel);
            this.Controls.Add(this.btnDelLabel);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnDelID);
            this.Controls.Add(this.btnDelName);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxDelName);
            this.Name = "Form1";
            this.Text = "Диспетчер задач";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnDelName;
        private System.Windows.Forms.Button btnDelID;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnDelLabel;
        private System.Windows.Forms.Button btnAddLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameprocess;
        private System.Windows.Forms.DataGridViewTextBoxColumn koldata;
        private System.Windows.Forms.Button btnUpdate;
    }
}

