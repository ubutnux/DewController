namespace DewController
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbAmbientTemp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDewPoint = new System.Windows.Forms.TextBox();
            this.tbAmbientHum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPower1Plus = new System.Windows.Forms.Button();
            this.btnPower1Min = new System.Windows.Forms.Button();
            this.rbHeater1Auto = new System.Windows.Forms.RadioButton();
            this.rbHeater1OFF = new System.Windows.Forms.RadioButton();
            this.rbHeater1Manual = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPower1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTempSensor1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPower2Plus = new System.Windows.Forms.Button();
            this.btnPower2Min = new System.Windows.Forms.Button();
            this.rbHeater2Auto = new System.Windows.Forms.RadioButton();
            this.rbHeater2OFF = new System.Windows.Forms.RadioButton();
            this.rbHeater2Manual = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPower2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTempSensor2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Connection";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(87, 19);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // tbAmbientTemp
            // 
            this.tbAmbientTemp.Location = new System.Drawing.Point(164, 19);
            this.tbAmbientTemp.Name = "tbAmbientTemp";
            this.tbAmbientTemp.ReadOnly = true;
            this.tbAmbientTemp.Size = new System.Drawing.Size(44, 20);
            this.tbAmbientTemp.TabIndex = 1;
            this.tbAmbientTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDewPoint);
            this.groupBox2.Controls.Add(this.tbAmbientHum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbAmbientTemp);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ambient Sensor";
            // 
            // tbDewPoint
            // 
            this.tbDewPoint.Location = new System.Drawing.Point(164, 69);
            this.tbDewPoint.Name = "tbDewPoint";
            this.tbDewPoint.ReadOnly = true;
            this.tbDewPoint.Size = new System.Drawing.Size(44, 20);
            this.tbDewPoint.TabIndex = 6;
            this.tbDewPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAmbientHum
            // 
            this.tbAmbientHum.Location = new System.Drawing.Point(164, 43);
            this.tbAmbientHum.Name = "tbAmbientHum";
            this.tbAmbientHum.ReadOnly = true;
            this.tbAmbientHum.Size = new System.Drawing.Size(44, 20);
            this.tbAmbientHum.TabIndex = 5;
            this.tbAmbientHum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dew Point Temp (C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Humidity (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature (C)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPower1Plus);
            this.groupBox3.Controls.Add(this.btnPower1Min);
            this.groupBox3.Controls.Add(this.rbHeater1Auto);
            this.groupBox3.Controls.Add(this.rbHeater1OFF);
            this.groupBox3.Controls.Add(this.rbHeater1Manual);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbPower1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbTempSensor1);
            this.groupBox3.Location = new System.Drawing.Point(238, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 83);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Heater 1";
            // 
            // btnPower1Plus
            // 
            this.btnPower1Plus.Location = new System.Drawing.Point(326, 49);
            this.btnPower1Plus.Name = "btnPower1Plus";
            this.btnPower1Plus.Size = new System.Drawing.Size(35, 23);
            this.btnPower1Plus.TabIndex = 12;
            this.btnPower1Plus.Text = "+";
            this.btnPower1Plus.UseVisualStyleBackColor = true;
            this.btnPower1Plus.Click += new System.EventHandler(this.BtnPower1Plus_Click);
            // 
            // btnPower1Min
            // 
            this.btnPower1Min.Location = new System.Drawing.Point(290, 49);
            this.btnPower1Min.Name = "btnPower1Min";
            this.btnPower1Min.Size = new System.Drawing.Size(35, 23);
            this.btnPower1Min.TabIndex = 11;
            this.btnPower1Min.Text = "-";
            this.btnPower1Min.UseVisualStyleBackColor = true;
            this.btnPower1Min.Click += new System.EventHandler(this.BtnPower1Min_Click);
            // 
            // rbHeater1Auto
            // 
            this.rbHeater1Auto.AutoSize = true;
            this.rbHeater1Auto.Location = new System.Drawing.Point(117, 19);
            this.rbHeater1Auto.Name = "rbHeater1Auto";
            this.rbHeater1Auto.Size = new System.Drawing.Size(101, 17);
            this.rbHeater1Auto.TabIndex = 10;
            this.rbHeater1Auto.TabStop = true;
            this.rbHeater1Auto.Text = "Heater ON Auto";
            this.rbHeater1Auto.UseVisualStyleBackColor = true;
            this.rbHeater1Auto.CheckedChanged += new System.EventHandler(this.RbHeater1Auto_CheckedChanged);
            // 
            // rbHeater1OFF
            // 
            this.rbHeater1OFF.AutoSize = true;
            this.rbHeater1OFF.Location = new System.Drawing.Point(9, 20);
            this.rbHeater1OFF.Name = "rbHeater1OFF";
            this.rbHeater1OFF.Size = new System.Drawing.Size(80, 17);
            this.rbHeater1OFF.TabIndex = 9;
            this.rbHeater1OFF.TabStop = true;
            this.rbHeater1OFF.Text = "Heater OFF";
            this.rbHeater1OFF.UseVisualStyleBackColor = true;
            this.rbHeater1OFF.CheckedChanged += new System.EventHandler(this.RbHeater1OFF_CheckedChanged);
            // 
            // rbHeater1Manual
            // 
            this.rbHeater1Manual.AutoSize = true;
            this.rbHeater1Manual.Location = new System.Drawing.Point(240, 19);
            this.rbHeater1Manual.Name = "rbHeater1Manual";
            this.rbHeater1Manual.Size = new System.Drawing.Size(114, 17);
            this.rbHeater1Manual.TabIndex = 8;
            this.rbHeater1Manual.TabStop = true;
            this.rbHeater1Manual.Text = "Heater ON Manual";
            this.rbHeater1Manual.UseVisualStyleBackColor = true;
            this.rbHeater1Manual.CheckedChanged += new System.EventHandler(this.RbHeater1Manual_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Power (%)";
            // 
            // tbPower1
            // 
            this.tbPower1.Location = new System.Drawing.Point(240, 51);
            this.tbPower1.Name = "tbPower1";
            this.tbPower1.ReadOnly = true;
            this.tbPower1.Size = new System.Drawing.Size(44, 20);
            this.tbPower1.TabIndex = 5;
            this.tbPower1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Temperature (C)";
            // 
            // tbTempSensor1
            // 
            this.tbTempSensor1.Location = new System.Drawing.Point(117, 51);
            this.tbTempSensor1.Name = "tbTempSensor1";
            this.tbTempSensor1.ReadOnly = true;
            this.tbTempSensor1.Size = new System.Drawing.Size(44, 20);
            this.tbTempSensor1.TabIndex = 3;
            this.tbTempSensor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPower2Plus);
            this.groupBox4.Controls.Add(this.btnPower2Min);
            this.groupBox4.Controls.Add(this.rbHeater2Auto);
            this.groupBox4.Controls.Add(this.rbHeater2OFF);
            this.groupBox4.Controls.Add(this.rbHeater2Manual);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbPower2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbTempSensor2);
            this.groupBox4.Location = new System.Drawing.Point(238, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 80);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Heater 2";
            // 
            // btnPower2Plus
            // 
            this.btnPower2Plus.Location = new System.Drawing.Point(326, 42);
            this.btnPower2Plus.Name = "btnPower2Plus";
            this.btnPower2Plus.Size = new System.Drawing.Size(35, 23);
            this.btnPower2Plus.TabIndex = 19;
            this.btnPower2Plus.Text = "+";
            this.btnPower2Plus.UseVisualStyleBackColor = true;
            this.btnPower2Plus.Click += new System.EventHandler(this.BtnPower2Plus_Click);
            // 
            // btnPower2Min
            // 
            this.btnPower2Min.Location = new System.Drawing.Point(290, 42);
            this.btnPower2Min.Name = "btnPower2Min";
            this.btnPower2Min.Size = new System.Drawing.Size(35, 23);
            this.btnPower2Min.TabIndex = 18;
            this.btnPower2Min.Text = "-";
            this.btnPower2Min.UseVisualStyleBackColor = true;
            this.btnPower2Min.Click += new System.EventHandler(this.BtnPower2Min_Click);
            // 
            // rbHeater2Auto
            // 
            this.rbHeater2Auto.AutoSize = true;
            this.rbHeater2Auto.Location = new System.Drawing.Point(117, 16);
            this.rbHeater2Auto.Name = "rbHeater2Auto";
            this.rbHeater2Auto.Size = new System.Drawing.Size(101, 17);
            this.rbHeater2Auto.TabIndex = 17;
            this.rbHeater2Auto.TabStop = true;
            this.rbHeater2Auto.Text = "Heater ON Auto";
            this.rbHeater2Auto.UseVisualStyleBackColor = true;
            this.rbHeater2Auto.CheckedChanged += new System.EventHandler(this.RbHeater2Auto_CheckedChanged);
            // 
            // rbHeater2OFF
            // 
            this.rbHeater2OFF.AutoSize = true;
            this.rbHeater2OFF.Location = new System.Drawing.Point(9, 15);
            this.rbHeater2OFF.Name = "rbHeater2OFF";
            this.rbHeater2OFF.Size = new System.Drawing.Size(80, 17);
            this.rbHeater2OFF.TabIndex = 16;
            this.rbHeater2OFF.TabStop = true;
            this.rbHeater2OFF.Text = "Heater OFF";
            this.rbHeater2OFF.UseVisualStyleBackColor = true;
            this.rbHeater2OFF.CheckedChanged += new System.EventHandler(this.RbHeater2OFF_CheckedChanged);
            // 
            // rbHeater2Manual
            // 
            this.rbHeater2Manual.AutoSize = true;
            this.rbHeater2Manual.Location = new System.Drawing.Point(240, 18);
            this.rbHeater2Manual.Name = "rbHeater2Manual";
            this.rbHeater2Manual.Size = new System.Drawing.Size(114, 17);
            this.rbHeater2Manual.TabIndex = 15;
            this.rbHeater2Manual.TabStop = true;
            this.rbHeater2Manual.Text = "Heater ON Manual";
            this.rbHeater2Manual.UseVisualStyleBackColor = true;
            this.rbHeater2Manual.CheckedChanged += new System.EventHandler(this.RbHeater2Manual_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Power (%)";
            // 
            // tbPower2
            // 
            this.tbPower2.Location = new System.Drawing.Point(240, 44);
            this.tbPower2.Name = "tbPower2";
            this.tbPower2.ReadOnly = true;
            this.tbPower2.Size = new System.Drawing.Size(44, 20);
            this.tbPower2.TabIndex = 13;
            this.tbPower2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Temperature (C)";
            // 
            // tbTempSensor2
            // 
            this.tbTempSensor2.Location = new System.Drawing.Point(117, 44);
            this.tbTempSensor2.Name = "tbTempSensor2";
            this.tbTempSensor2.ReadOnly = true;
            this.tbTempSensor2.Size = new System.Drawing.Size(44, 20);
            this.tbTempSensor2.TabIndex = 11;
            this.tbTempSensor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(623, 191);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pew Pew Dew";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbAmbientTemp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDewPoint;
        private System.Windows.Forms.TextBox tbAmbientHum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPower1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTempSensor1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbHeater1OFF;
        private System.Windows.Forms.RadioButton rbHeater1Manual;
        private System.Windows.Forms.RadioButton rbHeater1Auto;
        private System.Windows.Forms.RadioButton rbHeater2Auto;
        private System.Windows.Forms.RadioButton rbHeater2OFF;
        private System.Windows.Forms.RadioButton rbHeater2Manual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPower2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTempSensor2;
        private System.Windows.Forms.Button btnPower1Plus;
        private System.Windows.Forms.Button btnPower1Min;
        private System.Windows.Forms.Button btnPower2Plus;
        private System.Windows.Forms.Button btnPower2Min;
    }
}

