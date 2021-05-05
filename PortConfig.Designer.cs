
namespace RobotMovesUI
{
    partial class PortConfig
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
            this.PortConf = new System.Windows.Forms.ComboBox();
            this.SpeedConf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortConf
            // 
            this.PortConf.FormattingEnabled = true;
            this.PortConf.Location = new System.Drawing.Point(84, 15);
            this.PortConf.Name = "PortConf";
            this.PortConf.Size = new System.Drawing.Size(121, 21);
            this.PortConf.TabIndex = 0;
            // 
            // SpeedConf
            // 
            this.SpeedConf.FormattingEnabled = true;
            this.SpeedConf.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "2000000"});
            this.SpeedConf.Location = new System.Drawing.Point(84, 42);
            this.SpeedConf.Name = "SpeedConf";
            this.SpeedConf.Size = new System.Drawing.Size(121, 21);
            this.SpeedConf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Порт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Скорость(бод)";
            // 
            // ChangeConfig
            // 
            this.ChangeConfig.Location = new System.Drawing.Point(2, 66);
            this.ChangeConfig.Name = "ChangeConfig";
            this.ChangeConfig.Size = new System.Drawing.Size(203, 23);
            this.ChangeConfig.TabIndex = 4;
            this.ChangeConfig.Text = "Задать";
            this.ChangeConfig.UseVisualStyleBackColor = true;
            this.ChangeConfig.Click += new System.EventHandler(this.ChangeConfig_Click);
            // 
            // PortConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 100);
            this.Controls.Add(this.ChangeConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeedConf);
            this.Controls.Add(this.PortConf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortConfig";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "Настройки порта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortConf;
        private System.Windows.Forms.ComboBox SpeedConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeConfig;
    }
}