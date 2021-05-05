
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.ComMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RobotConfigMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.пиныУправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PortStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.BatteryLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.RightMotorPB = new System.Windows.Forms.ProgressBar();
            this.LeftMotorPB = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightMotorTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMotorTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.обАвтореToolStripMenuItem,
            this.PortStatus,
            this.BatteryLevel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 38);
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
            this.ComMenu});
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
            // RobotConfigMenu
            // 
            this.RobotConfigMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пиныУправленияToolStripMenuItem});
            this.RobotConfigMenu.Name = "RobotConfigMenu";
            this.RobotConfigMenu.Size = new System.Drawing.Size(141, 22);
            this.RobotConfigMenu.Text = "Робот";
            // 
            // пиныУправленияToolStripMenuItem
            // 
            this.пиныУправленияToolStripMenuItem.Name = "пиныУправленияToolStripMenuItem";
            this.пиныУправленияToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.пиныУправленияToolStripMenuItem.Text = "Пины управления";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            // 
            // PortStatus
            // 
            this.PortStatus.ForeColor = System.Drawing.Color.Red;
            this.PortStatus.Name = "PortStatus";
            this.PortStatus.Size = new System.Drawing.Size(164, 34);
            this.PortStatus.Text = "Устройство не подкючено";
            this.PortStatus.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // BatteryLevel
            // 
            this.BatteryLevel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BatteryLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BatteryLevel.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.BatteryLevel.Name = "BatteryLevel";
            this.BatteryLevel.Padding = new System.Windows.Forms.Padding(10, 15, 4, 0);
            this.BatteryLevel.ShowShortcutKeys = false;
            this.BatteryLevel.Size = new System.Drawing.Size(53, 34);
            this.BatteryLevel.Text = "100%";
            this.BatteryLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfoPanel.Controls.Add(this.RightMotorPB);
            this.InfoPanel.Controls.Add(this.LeftMotorPB);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 38);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(379, 54);
            this.InfoPanel.TabIndex = 1;
            // 
            // RightMotorPB
            // 
            this.RightMotorPB.Location = new System.Drawing.Point(81, 29);
            this.RightMotorPB.Maximum = 250;
            this.RightMotorPB.Name = "RightMotorPB";
            this.RightMotorPB.Size = new System.Drawing.Size(288, 18);
            this.RightMotorPB.TabIndex = 3;
            this.RightMotorPB.Value = 125;
            // 
            // LeftMotorPB
            // 
            this.LeftMotorPB.Location = new System.Drawing.Point(81, 6);
            this.LeftMotorPB.Maximum = 250;
            this.LeftMotorPB.Name = "LeftMotorPB";
            this.LeftMotorPB.Size = new System.Drawing.Size(287, 18);
            this.LeftMotorPB.TabIndex = 2;
            this.LeftMotorPB.Value = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Правый мотор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Левый мотор";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RightButton);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LeftIndependedButton);
            this.panel1.Controls.Add(this.RightIndependedButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.ForwardButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 257);
            this.panel1.TabIndex = 2;
            // 
            // RightButton
            // 
            this.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightButton.ForeColor = System.Drawing.Color.Red;
            this.RightButton.Location = new System.Drawing.Point(133, 214);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(40, 40);
            this.RightButton.TabIndex = 8;
            this.RightButton.Text = "D";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // LeftButton
            // 
            this.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftButton.ForeColor = System.Drawing.Color.Red;
            this.LeftButton.Location = new System.Drawing.Point(12, 214);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(40, 40);
            this.LeftButton.TabIndex = 7;
            this.LeftButton.Text = "A";
            this.LeftButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рулевое управление";
            // 
            // LeftIndependedButton
            // 
            this.LeftIndependedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftIndependedButton.ForeColor = System.Drawing.Color.Red;
            this.LeftIndependedButton.Location = new System.Drawing.Point(6, 123);
            this.LeftIndependedButton.Name = "LeftIndependedButton";
            this.LeftIndependedButton.Size = new System.Drawing.Size(40, 40);
            this.LeftIndependedButton.TabIndex = 4;
            this.LeftIndependedButton.Text = "Q";
            this.LeftIndependedButton.UseVisualStyleBackColor = true;
            // 
            // RightIndependedButton
            // 
            this.RightIndependedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightIndependedButton.ForeColor = System.Drawing.Color.Red;
            this.RightIndependedButton.Location = new System.Drawing.Point(133, 123);
            this.RightIndependedButton.Name = "RightIndependedButton";
            this.RightIndependedButton.Size = new System.Drawing.Size(40, 40);
            this.RightIndependedButton.TabIndex = 3;
            this.RightIndependedButton.Text = "E";
            this.RightIndependedButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.ForeColor = System.Drawing.Color.Red;
            this.BackButton.Location = new System.Drawing.Point(69, 214);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 40);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "S";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopButton.Location = new System.Drawing.Point(69, 123);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(40, 40);
            this.StopButton.TabIndex = 1;
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.ForeColor = System.Drawing.Color.Red;
            this.ForwardButton.Location = new System.Drawing.Point(69, 42);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(40, 40);
            this.ForwardButton.TabIndex = 0;
            this.ForwardButton.Text = "W";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            this.ForwardButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForwardButton_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RightMotorTrack);
            this.panel2.Controls.Add(this.LeftMotorTrack);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(179, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 257);
            this.panel2.TabIndex = 3;
            // 
            // RightMotorTrack
            // 
            this.RightMotorTrack.Location = new System.Drawing.Point(121, 42);
            this.RightMotorTrack.Maximum = 250;
            this.RightMotorTrack.Name = "RightMotorTrack";
            this.RightMotorTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightMotorTrack.Size = new System.Drawing.Size(45, 177);
            this.RightMotorTrack.TabIndex = 7;
            this.RightMotorTrack.Value = 125;
            this.RightMotorTrack.Scroll += new System.EventHandler(this.RightMotorTrack_Scroll);
            // 
            // LeftMotorTrack
            // 
            this.LeftMotorTrack.Location = new System.Drawing.Point(30, 42);
            this.LeftMotorTrack.Maximum = 250;
            this.LeftMotorTrack.Name = "LeftMotorTrack";
            this.LeftMotorTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftMotorTrack.Size = new System.Drawing.Size(45, 177);
            this.LeftMotorTrack.TabIndex = 6;
            this.LeftMotorTrack.Value = 125;
            this.LeftMotorTrack.Scroll += new System.EventHandler(this.LeftMotorTrack_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Независимое управление";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 380);
            this.MinimumSize = new System.Drawing.Size(387, 380);
            this.Name = "Form1";
            this.Text = "Система управления роботом";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightMotorTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMotorTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Connection;
        private System.Windows.Forms.ToolStripMenuItem RobotConfigMenu;
        private System.Windows.Forms.ToolStripMenuItem ComMenu;
        private System.Windows.Forms.ToolStripMenuItem пиныУправленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BatteryLevel;
        private System.Windows.Forms.ToolStripMenuItem PortStatus;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.ProgressBar RightMotorPB;
        private System.Windows.Forms.ProgressBar LeftMotorPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
    }
}

