namespace Game_Bar
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cpuLabel = new System.Windows.Forms.Label();
            this.ports = new System.Windows.Forms.ComboBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuLabel.Location = new System.Drawing.Point(14, 10);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(46, 22);
            this.cpuLabel.TabIndex = 1;
            this.cpuLabel.Text = "Port:";
            this.cpuLabel.Click += new System.EventHandler(this.cpuLabel_Click);
            // 
            // ports
            // 
            this.ports.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ports.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(66, 7);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(99, 30);
            this.ports.TabIndex = 2;
            this.ports.DropDown += new System.EventHandler(this.ports_DropDown);
            this.ports.SelectedIndexChanged += new System.EventHandler(this.ports_SelectedIndexChanged);
            // 
            // baudrate
            // 
            this.baudrate.BackColor = System.Drawing.Color.White;
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
            this.baudrate.Location = new System.Drawing.Point(267, 7);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(99, 30);
            this.baudrate.TabIndex = 4;
            this.baudrate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(171, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Baud rate: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.connect.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.connect.Location = new System.Drawing.Point(372, 7);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(50, 29);
            this.connect.TabIndex = 5;
            this.connect.Text = "GO";
            this.connect.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.connect);
            this.Controls.Add(this.baudrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ports);
            this.Controls.Add(this.cpuLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(425, 40);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.ComboBox ports;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect;
    }
}
