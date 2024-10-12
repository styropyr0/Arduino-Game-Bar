namespace Game_Bar
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.gpuLabel = new System.Windows.Forms.Label();
            this.cpuCounter = new System.Diagnostics.PerformanceCounter();
            this.ramCounter = new System.Diagnostics.PerformanceCounter();
            this.gpuCounter = new System.Diagnostics.PerformanceCounter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.batLabel = new System.Windows.Forms.Label();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ports = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dispBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpuCounter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuLabel.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuLabel.Location = new System.Drawing.Point(11, 9);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(54, 22);
            this.cpuLabel.TabIndex = 0;
            this.cpuLabel.Text = "CPU :";
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.BackColor = System.Drawing.Color.Transparent;
            this.ramLabel.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ramLabel.Location = new System.Drawing.Point(111, 9);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(59, 22);
            this.ramLabel.TabIndex = 2;
            this.ramLabel.Text = "RAM :";
            // 
            // gpuLabel
            // 
            this.gpuLabel.AutoSize = true;
            this.gpuLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpuLabel.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpuLabel.Location = new System.Drawing.Point(214, 9);
            this.gpuLabel.Name = "gpuLabel";
            this.gpuLabel.Size = new System.Drawing.Size(55, 22);
            this.gpuLabel.TabIndex = 3;
            this.gpuLabel.Text = "GPU :";
            // 
            // cpuCounter
            // 
            this.cpuCounter.CategoryName = "Processor";
            this.cpuCounter.CounterName = "% Processor Time";
            this.cpuCounter.InstanceName = "_Total";
            // 
            // ramCounter
            // 
            this.ramCounter.CategoryName = "Memory";
            this.ramCounter.CounterName = "% Committed Bytes In Use";
            // 
            // gpuCounter
            // 
            this.gpuCounter.CategoryName = "Processor Information";
            this.gpuCounter.CounterName = "% Interrupt TIme";
            this.gpuCounter.InstanceName = "_Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(265, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(360, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "--";
            // 
            // batLabel
            // 
            this.batLabel.AutoSize = true;
            this.batLabel.BackColor = System.Drawing.Color.Transparent;
            this.batLabel.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batLabel.Location = new System.Drawing.Point(312, 9);
            this.batLabel.Name = "batLabel";
            this.batLabel.Size = new System.Drawing.Size(52, 22);
            this.batLabel.TabIndex = 7;
            this.batLabel.Text = "BAT :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.baudrate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ports);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 219);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " SET PARAMETERS ";
            // 
            // ports
            // 
            this.ports.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ports.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ports.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(227, 46);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(145, 30);
            this.ports.TabIndex = 11;
            this.ports.Text = "None";
            this.ports.DropDown += new System.EventHandler(this.ports_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port :";
            // 
            // baudrate
            // 
            this.baudrate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baudrate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "Use default",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200"});
            this.baudrate.Location = new System.Drawing.Point(227, 94);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(145, 30);
            this.baudrate.TabIndex = 13;
            this.baudrate.Text = "Use default";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(28, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Baud rate :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(103, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dispBox
            // 
            this.dispBox.AutoSize = true;
            this.dispBox.BackColor = System.Drawing.Color.Transparent;
            this.dispBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispBox.ForeColor = System.Drawing.Color.White;
            this.dispBox.Location = new System.Drawing.Point(12, 285);
            this.dispBox.Name = "dispBox";
            this.dispBox.Size = new System.Drawing.Size(201, 17);
            this.dispBox.TabIndex = 10;
            this.dispBox.Text = "Choose a port and click connect.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(425, 310);
            this.Controls.Add(this.dispBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.batLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpuLabel);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.cpuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GAME BAR FOR ARDUINO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpuCounter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label gpuLabel;
        private System.Diagnostics.PerformanceCounter cpuCounter;
        private System.Diagnostics.PerformanceCounter ramCounter;
        private System.Diagnostics.PerformanceCounter gpuCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label batLabel;
        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dispBox;
    }
}

