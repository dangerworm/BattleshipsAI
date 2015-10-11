namespace BattleshipsServer
{
    partial class MainWindow
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(12, 41);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(75, 23);
            this.btnPlace.TabIndex = 1;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(12, 70);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(93, 12);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(519, 297);
            this.txtConsole.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnStart);
            this.Name = "MainWindow";
            this.Text = "Battleships Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtConsole;
    }
}

