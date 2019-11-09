namespace MineSweeperGame
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
            this.flpMineArea = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpMineArea
            // 
            this.flpMineArea.Location = new System.Drawing.Point(13, 13);
            this.flpMineArea.Name = "flpMineArea";
            this.flpMineArea.Size = new System.Drawing.Size(468, 468);
            this.flpMineArea.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 493);
            this.Controls.Add(this.flpMineArea);
            this.Name = "Form1";
            this.Text = "Mine Sweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMineArea;
    }
}

