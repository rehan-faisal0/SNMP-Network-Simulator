namespace OOP_Project
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Response = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.snmp = new OOP_Project.SNMPManager();
            this.Response.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snmp)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Router",
            "Thermometer",
            "Computer",
            "Cctv"});
            this.comboBox1.Location = new System.Drawing.Point(710, 650);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Router";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(353, 486);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Response
            // 
            this.Response.Controls.Add(this.Clear);
            this.Response.Controls.Add(this.richTextBox1);
            this.Response.Location = new System.Drawing.Point(1, 25);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(409, 615);
            this.Response.TabIndex = 7;
            this.Response.TabStop = false;
            this.Response.Text = "Response";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(272, 533);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(105, 34);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // snmp
            // 
            this.snmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snmp.DeviceName = "Snmp Manager";
            this.snmp.DeviceStatus = "ON";
            this.snmp.Image = ((System.Drawing.Image)(resources.GetObject("snmp.Image")));
            this.snmp.IPAddress = "192.168.0.100";
            this.snmp.Location = new System.Drawing.Point(761, 225);
            this.snmp.Name = "snmp";
            this.snmp.Size = new System.Drawing.Size(102, 90);
            this.snmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snmp.TabIndex = 8;
            this.snmp.TabStop = false;
            this.snmp.Click += new System.EventHandler(this.snmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 811);
            this.Controls.Add(this.snmp);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Response.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox Response;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Clear;
        private SNMPManager snmp;
    }
}

