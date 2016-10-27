namespace Exemplo_serial_port
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
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.comboBox_baude_rate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Items.AddRange(new object[] {
            "COM1 ",
            "COM2 ",
            "COM3 ",
            "COM4 ",
            "COM5 ",
            "COM6 ",
            "COM7 ",
            "COM8 ",
            "COM9 ",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28",
            "COM29",
            "COM30",
            "COM31",
            "COM32",
            "COM33",
            "COM34",
            "COM35",
            "COM36",
            "COM37",
            "COM38",
            "COM39",
            "COM40",
            "COM41",
            "COM42",
            "COM43",
            "COM44",
            "COM45",
            "COM46",
            "COM47",
            "COM48",
            "COM49",
            "COM50"});
            this.comboBox_port.Location = new System.Drawing.Point(85, 73);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_port.TabIndex = 0;
            // 
            // comboBox_baude_rate
            // 
            this.comboBox_baude_rate.FormattingEnabled = true;
            this.comboBox_baude_rate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baude_rate.Location = new System.Drawing.Point(85, 100);
            this.comboBox_baude_rate.Name = "comboBox_baude_rate";
            this.comboBox_baude_rate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_baude_rate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baude Rate:";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(275, 74);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(292, 20);
            this.textBox_input.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(85, 141);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(563, 295);
            this.textBox_output.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 463);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_baude_rate);
            this.Controls.Add(this.comboBox_port);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.ComboBox comboBox_baude_rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_output;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

