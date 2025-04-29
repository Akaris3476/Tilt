namespace Tilt
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            Label1 = new Label();
            StartBtn = new Button();
            progressBar1 = new ProgressBar();
            DefeatPanel = new Panel();
            llastkatka = new Label();
            lwinlose = new Label();
            ltag = new Label();
            lnick = new Label();
            lrole = new Label();
            lkda = new Label();
            lgamelength = new Label();
            ldamage = new Label();
            llongago = new Label();
            lchamp = new Label();
            lgameMode = new Label();
            endgameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DefeatPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KataDance;
            pictureBox1.Location = new Point(578, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(190, 27);
            Label1.Name = "Label1";
            Label1.Size = new Size(404, 100);
            Label1.TabIndex = 1;
            Label1.Text = "Пососал ли сегодня \r\nЖенечка тильт в лиге?";
            Label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.FromArgb(250, 236, 255);
            StartBtn.FlatStyle = FlatStyle.Popup;
            StartBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StartBtn.Location = new Point(275, 185);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(216, 69);
            StartBtn.TabIndex = 2;
            StartBtn.Text = "Узнать Ответ";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(196, 198);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(376, 36);
            progressBar1.TabIndex = 3;
            progressBar1.Visible = false;
            // 
            // DefeatPanel
            // 
            DefeatPanel.Controls.Add(llastkatka);
            DefeatPanel.Controls.Add(lwinlose);
            DefeatPanel.Controls.Add(ltag);
            DefeatPanel.Controls.Add(lnick);
            DefeatPanel.Controls.Add(lrole);
            DefeatPanel.Controls.Add(lkda);
            DefeatPanel.Controls.Add(lgamelength);
            DefeatPanel.Controls.Add(ldamage);
            DefeatPanel.Controls.Add(llongago);
            DefeatPanel.Controls.Add(lchamp);
            DefeatPanel.Controls.Add(lgameMode);
            DefeatPanel.Controls.Add(endgameLabel);
            DefeatPanel.Location = new Point(12, 12);
            DefeatPanel.Name = "DefeatPanel";
            DefeatPanel.Size = new Size(570, 426);
            DefeatPanel.TabIndex = 4;
            DefeatPanel.Visible = false;
            // 
            // llastkatka
            // 
            llastkatka.AutoSize = true;
            llastkatka.Location = new Point(31, 144);
            llastkatka.Name = "llastkatka";
            llastkatka.Size = new Size(65, 15);
            llastkatka.TabIndex = 20;
            llastkatka.Text = "ЛастКатка:";
            // 
            // lwinlose
            // 
            lwinlose.AutoSize = true;
            lwinlose.Location = new Point(31, 283);
            lwinlose.Name = "lwinlose";
            lwinlose.Size = new Size(66, 15);
            lwinlose.TabIndex = 19;
            lwinlose.Text = "gameresult";
            // 
            // ltag
            // 
            ltag.AutoSize = true;
            ltag.Location = new Point(135, 173);
            ltag.Name = "ltag";
            ltag.Size = new Size(24, 15);
            ltag.TabIndex = 18;
            ltag.Text = "tag";
            // 
            // lnick
            // 
            lnick.AutoSize = true;
            lnick.Location = new Point(31, 173);
            lnick.Name = "lnick";
            lnick.Size = new Size(61, 15);
            lnick.TabIndex = 17;
            lnick.Text = "Nickname";
            // 
            // lrole
            // 
            lrole.AutoSize = true;
            lrole.Location = new Point(262, 207);
            lrole.Name = "lrole";
            lrole.Size = new Size(27, 15);
            lrole.TabIndex = 16;
            lrole.Text = "role";
            // 
            // lkda
            // 
            lkda.AutoSize = true;
            lkda.Location = new Point(31, 341);
            lkda.Name = "lkda";
            lkda.Size = new Size(26, 15);
            lkda.TabIndex = 14;
            lkda.Text = "kda";
            // 
            // lgamelength
            // 
            lgamelength.AutoSize = true;
            lgamelength.Location = new Point(31, 240);
            lgamelength.Name = "lgamelength";
            lgamelength.Size = new Size(71, 15);
            lgamelength.TabIndex = 12;
            lgamelength.Text = "gamelength";
            // 
            // ldamage
            // 
            ldamage.AutoSize = true;
            ldamage.Location = new Point(262, 240);
            ldamage.Name = "ldamage";
            ldamage.Size = new Size(75, 15);
            ldamage.TabIndex = 11;
            ldamage.Text = "totalDamage";
            // 
            // llongago
            // 
            llongago.AutoSize = true;
            llongago.Location = new Point(31, 207);
            llongago.Name = "llongago";
            llongago.Size = new Size(80, 15);
            llongago.TabIndex = 10;
            llongago.Text = "how long ago";
            // 
            // lchamp
            // 
            lchamp.AutoSize = true;
            lchamp.Location = new Point(313, 207);
            lchamp.Name = "lchamp";
            lchamp.Size = new Size(61, 15);
            lchamp.TabIndex = 7;
            lchamp.Text = "champion";
            // 
            // lgameMode
            // 
            lgameMode.AutoSize = true;
            lgameMode.Location = new Point(115, 283);
            lgameMode.Name = "lgameMode";
            lgameMode.Size = new Size(68, 15);
            lgameMode.TabIndex = 6;
            lgameMode.Text = "gameMode";
            // 
            // endgameLabel
            // 
            endgameLabel.AutoSize = true;
            endgameLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endgameLabel.Location = new Point(178, 0);
            endgameLabel.Name = "endgameLabel";
            endgameLabel.Size = new Size(341, 120);
            endgameLabel.TabIndex = 5;
            endgameLabel.Text = "Сегодня Женечка Тильт \r\nв лигу не заходил, \r\nслава богу\r\n";
            endgameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 236, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(DefeatPanel);
            Controls.Add(progressBar1);
            Controls.Add(StartBtn);
            Controls.Add(Label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DefeatPanel.ResumeLayout(false);
            DefeatPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Label1;
        private Button StartBtn;
        private ProgressBar progressBar1;
        private Panel DefeatPanel;
        private Label endgameLabel;
        private Label lgameMode;
        private Label lgamelength;
        private Label ldamage;
        private Label llongago;
        private Label lchamp;
        private Label lkda;
        private Label lrole;
        private Label lnick;
        private Label ltag;
        private Label lwinlose;
        private Label llastkatka;
    }
}
