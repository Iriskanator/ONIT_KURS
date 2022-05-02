
namespace ONIT_2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.nBeginPort = new System.Windows.Forms.NumericUpDown();
            this.nEndPort = new System.Windows.Forms.NumericUpDown();
            this.tIPAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEndPort)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 70);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(782, 334);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 410);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 16);
            this.progressBar1.TabIndex = 1;
            // 
            // nBeginPort
            // 
            this.nBeginPort.Location = new System.Drawing.Point(314, 44);
            this.nBeginPort.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nBeginPort.Name = "nBeginPort";
            this.nBeginPort.Size = new System.Drawing.Size(124, 20);
            this.nBeginPort.TabIndex = 2;
            // 
            // nEndPort
            // 
            this.nEndPort.Location = new System.Drawing.Point(471, 44);
            this.nEndPort.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nEndPort.Name = "nEndPort";
            this.nEndPort.Size = new System.Drawing.Size(124, 20);
            this.nEndPort.TabIndex = 3;
            // 
            // tIPAddress
            // 
            this.tIPAddress.Location = new System.Drawing.Point(49, 44);
            this.tIPAddress.Name = "tIPAddress";
            this.tIPAddress.Size = new System.Drawing.Size(158, 20);
            this.tIPAddress.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сканировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Хост";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Порт от";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Порт";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Открыт";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Закрыт";
            this.columnHeader3.Width = 123;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tIPAddress);
            this.Controls.Add(this.nEndPort);
            this.Controls.Add(this.nBeginPort);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "ONIT_2";
            ((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEndPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown nBeginPort;
        private System.Windows.Forms.NumericUpDown nEndPort;
        private System.Windows.Forms.TextBox tIPAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

