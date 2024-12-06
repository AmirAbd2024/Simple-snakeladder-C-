namespace SnakeAndLadder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.playing2 = new System.Windows.Forms.Button();
            this.playing1 = new System.Windows.Forms.Button();
            this.ChanceBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SnakeAndLadder.Properties.Resources.snakeladderback;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.playing2);
            this.panel1.Controls.Add(this.playing1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 600);
            this.panel1.TabIndex = 0;
            // 
            // playing2
            // 
            this.playing2.BackColor = System.Drawing.Color.Blue;
            this.playing2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playing2.Location = new System.Drawing.Point(26, 555);
            this.playing2.Name = "playing2";
            this.playing2.Size = new System.Drawing.Size(30, 25);
            this.playing2.TabIndex = 2;
            this.playing2.Text = "2";
            this.playing2.UseVisualStyleBackColor = false;
            // 
            // playing1
            // 
            this.playing1.BackColor = System.Drawing.Color.Red;
            this.playing1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playing1.Location = new System.Drawing.Point(26, 555);
            this.playing1.Name = "playing1";
            this.playing1.Size = new System.Drawing.Size(30, 25);
            this.playing1.TabIndex = 1;
            this.playing1.Text = "1";
            this.playing1.UseVisualStyleBackColor = false;
            // 
            // ChanceBTN
            // 
            this.ChanceBTN.Location = new System.Drawing.Point(828, 425);
            this.ChanceBTN.Name = "ChanceBTN";
            this.ChanceBTN.Size = new System.Drawing.Size(69, 54);
            this.ChanceBTN.TabIndex = 3;
            this.ChanceBTN.Text = "Dice";
            this.ChanceBTN.UseVisualStyleBackColor = true;
            this.ChanceBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(853, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChanceBTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeLadder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playing1;
        private System.Windows.Forms.Button ChanceBTN;
        private System.Windows.Forms.Button playing2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

