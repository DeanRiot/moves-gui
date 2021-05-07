
namespace RobotMovesUI
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.ComMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RobotConfigMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PinsConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.PortStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.BatteryLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftIndependedButton = new System.Windows.Forms.Button();
            this.RightIndependedButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RightMotorTrack = new System.Windows.Forms.TrackBar();
            this.LeftMotorTrack = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LeftMotorPB = new System.Windows.Forms.ProgressBar();
            this.RightMotorPB = new System.Windows.Forms.ProgressBar();
            this.batteryTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.SpeedCheck = new System.Windows.Forms.CheckBox();
            this.SpeedTrack = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightMotorTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMotorTrack)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.PortStatus,
            this.BatteryLevel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connection,
            this.RobotConfigMenu});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 34);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // Connection
            // 
            this.Connection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComMenu,
            this.CloseMenu});
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(141, 22);
            this.Connection.Text = "Соединение";
            // 
            // ComMenu
            // 
            this.ComMenu.Name = "ComMenu";
            this.ComMenu.Size = new System.Drawing.Size(190, 22);
            this.ComMenu.Text = "Конфигурация порта";
            this.ComMenu.Click += new System.EventHandler(this.ComMenu_Click);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(190, 22);
            this.CloseMenu.Text = "Отключиться";
            this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            // 
            // RobotConfigMenu
            // 
            this.RobotConfigMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PinsConfig});
            this.RobotConfigMenu.Name = "RobotConfigMenu";
            this.RobotConfigMenu.Size = new System.Drawing.Size(141, 22);
            this.RobotConfigMenu.Text = "Робот";
            // 
            // PinsConfig
            // 
            this.PinsConfig.Name = "PinsConfig";
            this.PinsConfig.Size = new System.Drawing.Size(174, 22);
            this.PinsConfig.Text = "Пины управления";
            this.PinsConfig.Click += new System.EventHandler(this.PinsConfig_Click);
            // 
            // PortStatus
            // 
            this.PortStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.PortStatus.ForeColor = System.Drawing.Color.Red;
            this.PortStatus.Name = "PortStatus";
            this.PortStatus.Size = new System.Drawing.Size(164, 34);
            this.PortStatus.Text = "Устройство не подкючено";
            // 
            // BatteryLevel
            // 
            this.BatteryLevel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BatteryLevel.BackgroundImage = global::RobotMovesUI.Properties.Resources.Battery;
            this.BatteryLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BatteryLevel.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.BatteryLevel.Name = "BatteryLevel";
            this.BatteryLevel.Padding = new System.Windows.Forms.Padding(10, 15, 4, 0);
            this.BatteryLevel.ShowShortcutKeys = false;
            this.BatteryLevel.Size = new System.Drawing.Size(41, 34);
            this.BatteryLevel.Text = "0%";
            this.BatteryLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.SpeedTrack);
            this.panel1.Controls.Add(this.SpeedCheck);
            this.panel1.Controls.Add(this.RightButton);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LeftIndependedButton);
            this.panel1.Controls.Add(this.RightIndependedButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.ForwardButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 353);
            this.panel1.TabIndex = 2;
            // 
            // RightButton
            // 
            this.RightButton.BackgroundImage = global::RobotMovesUI.Properties.Resources.CircleArrowRight;
            this.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightButton.Enabled = false;
            this.RightButton.ForeColor = System.Drawing.Color.Red;
            this.RightButton.Location = new System.Drawing.Point(152, 218);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(55, 55);
            this.RightButton.TabIndex = 8;
            this.RightButton.Tag = "6";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.Buttons_Click);
            this.RightButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button_KeyUp);
            // 
            // LeftButton
            // 
            this.LeftButton.BackgroundImage = global::RobotMovesUI.Properties.Resources.CircleArrowLeft;
            this.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftButton.Enabled = false;
            this.LeftButton.ForeColor = System.Drawing.Color.Red;
            this.LeftButton.Location = new System.Drawing.Point(10, 218);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(55, 55);
            this.LeftButton.TabIndex = 7;
            this.LeftButton.Tag = "4";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.Buttons_Click);
            this.LeftButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рулевое управление";
            // 
            // LeftIndependedButton
            // 
            this.LeftIndependedButton.BackgroundImage = global::RobotMovesUI.Properties.Resources.ArrowLeft;
            this.LeftIndependedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftIndependedButton.Enabled = false;
            this.LeftIndependedButton.ForeColor = System.Drawing.Color.Red;
            this.LeftIndependedButton.Location = new System.Drawing.Point(10, 144);
            this.LeftIndependedButton.Name = "LeftIndependedButton";
            this.LeftIndependedButton.Size = new System.Drawing.Size(55, 55);
            this.LeftIndependedButton.TabIndex = 4;
            this.LeftIndependedButton.Tag = "1";
            this.LeftIndependedButton.UseVisualStyleBackColor = true;
            this.LeftIndependedButton.Click += new System.EventHandler(this.Buttons_Click);
            this.LeftIndependedButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button_KeyUp);
            // 
            // RightIndependedButton
            // 
            this.RightIndependedButton.BackgroundImage = global::RobotMovesUI.Properties.Resources.ArrowRight;
            this.RightIndependedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightIndependedButton.Enabled = false;
            this.RightIndependedButton.ForeColor = System.Drawing.Color.Red;
            this.RightIndependedButton.Location = new System.Drawing.Point(152, 144);
            this.RightIndependedButton.Name = "RightIndependedButton";
            this.RightIndependedButton.Size = new System.Drawing.Size(55, 55);
            this.RightIndependedButton.TabIndex = 3;
            this.RightIndependedButton.Tag = "3";
            this.RightIndependedButton.UseVisualStyleBackColor = true;
            this.RightIndependedButton.Click += new System.EventHandler(this.Buttons_Click);
            this.RightIndependedButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button_KeyUp);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::RobotMovesUI.Properties.Resources.ArrowDown;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Enabled = false;
            this.BackButton.ForeColor = System.Drawing.Color.Red;
            this.BackButton.Location = new System.Drawing.Point(80, 218);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 55);
            this.BackButton.TabIndex = 2;
            this.BackButton.Tag = "5";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Buttons_Click);
            this.BackButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button_KeyUp);
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImage = global::RobotMovesUI.Properties.Resources.stop;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(82, 144);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(55, 55);
            this.StopButton.TabIndex = 1;
            this.StopButton.Tag = "2";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.Buttons_Click);
            this.StopButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button_KeyUp);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = global::RobotMovesUI.Properties.Resources.ArrowUPpng;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.Enabled = false;
            this.ForwardButton.ForeColor = System.Drawing.Color.Red;
            this.ForwardButton.Location = new System.Drawing.Point(80, 65);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(55, 55);
            this.ForwardButton.TabIndex = 0;
            this.ForwardButton.Tag = "0";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.Buttons_Click);
            this.ForwardButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.RightMotorTrack);
            this.panel2.Controls.Add(this.LeftMotorTrack);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(554, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 353);
            this.panel2.TabIndex = 3;
            // 
            // RightMotorTrack
            // 
            this.RightMotorTrack.Enabled = false;
            this.RightMotorTrack.Location = new System.Drawing.Point(148, 42);
            this.RightMotorTrack.Maximum = 250;
            this.RightMotorTrack.Name = "RightMotorTrack";
            this.RightMotorTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightMotorTrack.Size = new System.Drawing.Size(45, 297);
            this.RightMotorTrack.TabIndex = 7;
            this.RightMotorTrack.Tag = "12";
            this.RightMotorTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.RightMotorTrack.Value = 125;
            this.RightMotorTrack.Scroll += new System.EventHandler(this.RightMotorTrack_Scroll);
            // 
            // LeftMotorTrack
            // 
            this.LeftMotorTrack.Enabled = false;
            this.LeftMotorTrack.Location = new System.Drawing.Point(12, 42);
            this.LeftMotorTrack.Maximum = 250;
            this.LeftMotorTrack.Name = "LeftMotorTrack";
            this.LeftMotorTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftMotorTrack.Size = new System.Drawing.Size(45, 297);
            this.LeftMotorTrack.TabIndex = 6;
            this.LeftMotorTrack.Tag = "11";
            this.LeftMotorTrack.Value = 125;
            this.LeftMotorTrack.Scroll += new System.EventHandler(this.LeftMotorTrack_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Независимое управление";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RobotMovesUI.Properties.Resources.Robot;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LeftMotorPB);
            this.panel3.Controls.Add(this.RightMotorPB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(230, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 353);
            this.panel3.TabIndex = 4;
            // 
            // LeftMotorPB
            // 
            this.LeftMotorPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftMotorPB.Enabled = false;
            this.LeftMotorPB.Location = new System.Drawing.Point(0, 0);
            this.LeftMotorPB.Maximum = 250;
            this.LeftMotorPB.Name = "LeftMotorPB";
            this.LeftMotorPB.Size = new System.Drawing.Size(322, 18);
            this.LeftMotorPB.TabIndex = 2;
            this.LeftMotorPB.Tag = "9";
            this.LeftMotorPB.Value = 125;
            // 
            // RightMotorPB
            // 
            this.RightMotorPB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RightMotorPB.Enabled = false;
            this.RightMotorPB.Location = new System.Drawing.Point(0, 333);
            this.RightMotorPB.Maximum = 250;
            this.RightMotorPB.Name = "RightMotorPB";
            this.RightMotorPB.Size = new System.Drawing.Size(322, 18);
            this.RightMotorPB.TabIndex = 3;
            this.RightMotorPB.Tag = "10";
            this.RightMotorPB.Value = 125;
            // 
            // batteryTimer
            // 
            this.batteryTimer.Interval = 60000;
            this.batteryTimer.Tick += new System.EventHandler(this.batteryTimer_Tick);
            // 
            // StatusTimer
            // 
            this.StatusTimer.Interval = 1000;
            this.StatusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // SpeedCheck
            // 
            this.SpeedCheck.AutoSize = true;
            this.SpeedCheck.Location = new System.Drawing.Point(10, 283);
            this.SpeedCheck.Name = "SpeedCheck";
            this.SpeedCheck.Size = new System.Drawing.Size(142, 17);
            this.SpeedCheck.TabIndex = 9;
            this.SpeedCheck.Text = "С заданной скоростью";
            this.SpeedCheck.UseVisualStyleBackColor = true;
            // 
            // SpeedTrack
            // 
            this.SpeedTrack.Location = new System.Drawing.Point(3, 306);
            this.SpeedTrack.Maximum = 250;
            this.SpeedTrack.Name = "SpeedTrack";
            this.SpeedTrack.Size = new System.Drawing.Size(225, 45);
            this.SpeedTrack.TabIndex = 10;
            this.SpeedTrack.Scroll += new System.EventHandler(this.SpeedTrack_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 391);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 380);
            this.Name = "Form1";
            this.Text = "Система управления роботом";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightMotorTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMotorTrack)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Connection;
        private System.Windows.Forms.ToolStripMenuItem RobotConfigMenu;
        private System.Windows.Forms.ToolStripMenuItem ComMenu;
        private System.Windows.Forms.ToolStripMenuItem PinsConfig;
        private System.Windows.Forms.ToolStripMenuItem BatteryLevel;
        private System.Windows.Forms.ToolStripMenuItem PortStatus;
        private System.Windows.Forms.ProgressBar RightMotorPB;
        private System.Windows.Forms.ProgressBar LeftMotorPB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LeftIndependedButton;
        private System.Windows.Forms.Button RightIndependedButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar RightMotorTrack;
        private System.Windows.Forms.TrackBar LeftMotorTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem CloseMenu;
        private System.Windows.Forms.Timer batteryTimer;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.TrackBar SpeedTrack;
        private System.Windows.Forms.CheckBox SpeedCheck;
    }
}

