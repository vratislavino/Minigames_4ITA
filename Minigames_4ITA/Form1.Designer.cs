namespace Minigames_4ITA
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.player1image = new System.Windows.Forms.PictureBox();
            this.player1name = new System.Windows.Forms.Label();
            this.player1hp = new System.Windows.Forms.ProgressBar();
            this.player1hptext = new System.Windows.Forms.Label();
            this.player2image = new System.Windows.Forms.PictureBox();
            this.player2name = new System.Windows.Forms.Label();
            this.player2hp = new System.Windows.Forms.ProgressBar();
            this.player2hptext = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.minigamePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.player1image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2image)).BeginInit();
            this.SuspendLayout();
            // 
            // player1image
            // 
            this.player1image.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1image.Location = new System.Drawing.Point(12, 28);
            this.player1image.Name = "player1image";
            this.player1image.Size = new System.Drawing.Size(222, 499);
            this.player1image.TabIndex = 0;
            this.player1image.TabStop = false;
            // 
            // player1name
            // 
            this.player1name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1name.Location = new System.Drawing.Point(12, 530);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(222, 38);
            this.player1name.TabIndex = 1;
            this.player1name.Text = "Petr";
            this.player1name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1hp
            // 
            this.player1hp.Location = new System.Drawing.Point(12, 571);
            this.player1hp.Name = "player1hp";
            this.player1hp.Size = new System.Drawing.Size(346, 34);
            this.player1hp.TabIndex = 2;
            this.player1hp.Value = 50;
            // 
            // player1hptext
            // 
            this.player1hptext.AutoSize = true;
            this.player1hptext.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1hptext.Location = new System.Drawing.Point(12, 608);
            this.player1hptext.Name = "player1hptext";
            this.player1hptext.Size = new System.Drawing.Size(118, 38);
            this.player1hptext.TabIndex = 3;
            this.player1hptext.Text = "100/100";
            // 
            // player2image
            // 
            this.player2image.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player2image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2image.Location = new System.Drawing.Point(1020, 28);
            this.player2image.Name = "player2image";
            this.player2image.Size = new System.Drawing.Size(222, 499);
            this.player2image.TabIndex = 4;
            this.player2image.TabStop = false;
            // 
            // player2name
            // 
            this.player2name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2name.Location = new System.Drawing.Point(1020, 530);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(222, 38);
            this.player2name.TabIndex = 5;
            this.player2name.Text = "Peasdasd";
            this.player2name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player2hp
            // 
            this.player2hp.Location = new System.Drawing.Point(896, 571);
            this.player2hp.Name = "player2hp";
            this.player2hp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.player2hp.RightToLeftLayout = true;
            this.player2hp.Size = new System.Drawing.Size(346, 34);
            this.player2hp.TabIndex = 6;
            this.player2hp.Value = 50;
            // 
            // player2hptext
            // 
            this.player2hptext.AutoSize = true;
            this.player2hptext.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2hptext.Location = new System.Drawing.Point(1124, 608);
            this.player2hptext.Name = "player2hptext";
            this.player2hptext.Size = new System.Drawing.Size(118, 38);
            this.player2hptext.TabIndex = 7;
            this.player2hptext.Text = "100/100";
            // 
            // actionLabel
            // 
            this.actionLabel.BackColor = System.Drawing.Color.White;
            this.actionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionLabel.Location = new System.Drawing.Point(364, 571);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(526, 90);
            this.actionLabel.TabIndex = 8;
            this.actionLabel.Text = "label1";
            // 
            // minigamePanel
            // 
            this.minigamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minigamePanel.Location = new System.Drawing.Point(300, 28);
            this.minigamePanel.Name = "minigamePanel";
            this.minigamePanel.Size = new System.Drawing.Size(662, 515);
            this.minigamePanel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 670);
            this.Controls.Add(this.minigamePanel);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.player2hptext);
            this.Controls.Add(this.player2hp);
            this.Controls.Add(this.player2name);
            this.Controls.Add(this.player2image);
            this.Controls.Add(this.player1hptext);
            this.Controls.Add(this.player1hp);
            this.Controls.Add(this.player1name);
            this.Controls.Add(this.player1image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player1image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox player1image;
        private Label player1name;
        private ProgressBar player1hp;
        private Label player1hptext;
        private PictureBox player2image;
        private Label player2name;
        private ProgressBar player2hp;
        private Label player2hptext;
        private Label actionLabel;
        private Panel minigamePanel;
    }
}