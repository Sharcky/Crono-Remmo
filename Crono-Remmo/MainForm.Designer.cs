namespace Crono_Remmo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonMain = new Button();
            labelHour = new Label();
            buttonAction = new Button();
            panel4 = new Panel();
            labelMlSec = new Label();
            label4 = new Label();
            labelSeconds = new Label();
            label2 = new Label();
            labelMinute = new Label();
            label1 = new Label();
            panel5 = new Panel();
            buttonReset = new Button();
            timerEvent = new System.Windows.Forms.Timer(components);
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 20);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 664);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonMain);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(1017, 108);
            panel3.TabIndex = 2;
            // 
            // buttonMain
            // 
            buttonMain.BackColor = Color.FromArgb(52, 235, 103);
            buttonMain.FlatAppearance.BorderSize = 0;
            buttonMain.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 235, 103);
            buttonMain.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 235, 103);
            buttonMain.FlatStyle = FlatStyle.Flat;
            buttonMain.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMain.Location = new Point(60, 36);
            buttonMain.Name = "buttonMain";
            buttonMain.Size = new Size(123, 33);
            buttonMain.TabIndex = 0;
            buttonMain.Text = "Listar registros";
            buttonMain.UseVisualStyleBackColor = false;
            // 
            // labelHour
            // 
            labelHour.AutoSize = true;
            labelHour.Dock = DockStyle.Left;
            labelHour.Font = new Font("Bahnschrift SemiBold SemiConden", 72F, FontStyle.Bold, GraphicsUnit.Point);
            labelHour.ForeColor = Color.White;
            labelHour.Location = new Point(0, 0);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(139, 115);
            labelHour.TabIndex = 3;
            labelHour.Text = "00";
            // 
            // buttonAction
            // 
            buttonAction.Anchor = AnchorStyles.None;
            buttonAction.BackColor = Color.FromArgb(52, 235, 103);
            buttonAction.FlatAppearance.BorderSize = 0;
            buttonAction.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 235, 103);
            buttonAction.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 235, 103);
            buttonAction.FlatStyle = FlatStyle.Flat;
            buttonAction.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAction.Location = new Point(435, 411);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(122, 46);
            buttonAction.TabIndex = 4;
            buttonAction.UseVisualStyleBackColor = false;
            buttonAction.Click += buttonAction_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelMlSec);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(labelSeconds);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(labelMinute);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(labelHour);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(757, 120);
            panel4.TabIndex = 5;
            // 
            // labelMlSec
            // 
            labelMlSec.AutoSize = true;
            labelMlSec.Dock = DockStyle.Left;
            labelMlSec.Font = new Font("Bahnschrift SemiBold SemiConden", 72F, FontStyle.Bold, GraphicsUnit.Point);
            labelMlSec.ForeColor = Color.White;
            labelMlSec.Location = new Point(621, 0);
            labelMlSec.Name = "labelMlSec";
            labelMlSec.Size = new Size(139, 115);
            labelMlSec.TabIndex = 9;
            labelMlSec.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Bahnschrift SemiBold SemiConden", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(553, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 115);
            label4.TabIndex = 8;
            label4.Text = ".";
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Dock = DockStyle.Left;
            labelSeconds.Font = new Font("Bahnschrift SemiBold SemiConden", 72F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeconds.ForeColor = Color.White;
            labelSeconds.Location = new Point(414, 0);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(139, 115);
            labelSeconds.TabIndex = 7;
            labelSeconds.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(346, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 115);
            label2.TabIndex = 6;
            label2.Text = ".";
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Dock = DockStyle.Left;
            labelMinute.Font = new Font("Bahnschrift SemiBold SemiConden", 72F, FontStyle.Bold, GraphicsUnit.Point);
            labelMinute.ForeColor = Color.White;
            labelMinute.Location = new Point(207, 0);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(139, 115);
            labelMinute.TabIndex = 5;
            labelMinute.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 115);
            label1.TabIndex = 4;
            label1.Text = ".";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(buttonReset);
            panel5.Controls.Add(panel4);
            panel5.Location = new Point(60, 272);
            panel5.Name = "panel5";
            panel5.Size = new Size(872, 120);
            panel5.TabIndex = 6;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Transparent;
            buttonReset.Dock = DockStyle.Right;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 235, 103);
            buttonReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.Image = Properties.Resources.reload_64_px;
            buttonReset.Location = new Point(782, 0);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(90, 120);
            buttonReset.TabIndex = 5;
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // timerEvent
            // 
            timerEvent.Enabled = true;
            timerEvent.Interval = 10;
            timerEvent.Tick += timerEvent_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(1017, 764);
            Controls.Add(panel5);
            Controls.Add(buttonAction);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button buttonMain;
        private Label labelHour;
        private Button buttonAction;
        private Panel panel4;
        private Label labelSeconds;
        private Label label2;
        private Label labelMinute;
        private Label label1;
        private Panel panel5;
        private Button buttonReset;
        private System.Windows.Forms.Timer timerEvent;
        private Label labelMlSec;
        private Label label4;
    }
}