namespace Alarm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.notifyIconAlarm = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlarmDur = new System.Windows.Forms.Button();
            this.btnAlrmKur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dTpTarih = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(30, 93);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(135, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // notifyIconAlarm
            // 
            this.notifyIconAlarm.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconAlarm.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconAlarm.Icon")));
            this.notifyIconAlarm.Text = "Alarm";
            this.notifyIconAlarm.DoubleClick += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // btnAlarmDur
            // 
            this.btnAlarmDur.BackgroundImage = global::Alarm.Properties.Resources.alarmOff;
            this.btnAlarmDur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlarmDur.Location = new System.Drawing.Point(599, 199);
            this.btnAlarmDur.Name = "btnAlarmDur";
            this.btnAlarmDur.Size = new System.Drawing.Size(75, 53);
            this.btnAlarmDur.TabIndex = 3;
            this.btnAlarmDur.UseVisualStyleBackColor = true;
            this.btnAlarmDur.Click += new System.EventHandler(this.btnAlarmDur_Click);
            // 
            // btnAlrmKur
            // 
            this.btnAlrmKur.BackgroundImage = global::Alarm.Properties.Resources.alarmOn;
            this.btnAlrmKur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlrmKur.Location = new System.Drawing.Point(515, 199);
            this.btnAlrmKur.Name = "btnAlrmKur";
            this.btnAlrmKur.Size = new System.Drawing.Size(75, 53);
            this.btnAlrmKur.TabIndex = 2;
            this.btnAlrmKur.UseVisualStyleBackColor = true;
            this.btnAlrmKur.Click += new System.EventHandler(this.btnAlrmKur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alarm.Properties.Resources.gong;
            this.pictureBox1.Location = new System.Drawing.Point(515, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dTpTarih
            // 
            this.dTpTarih.Location = new System.Drawing.Point(30, 30);
            this.dTpTarih.Name = "dTpTarih";
            this.dTpTarih.Size = new System.Drawing.Size(200, 20);
            this.dTpTarih.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 313);
            this.Controls.Add(this.dTpTarih);
            this.Controls.Add(this.btnAlarmDur);
            this.Controls.Add(this.btnAlrmKur);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Button btnAlrmKur;
        private System.Windows.Forms.Button btnAlarmDur;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.NotifyIcon notifyIconAlarm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dTpTarih;
    }
}

