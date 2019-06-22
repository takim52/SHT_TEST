namespace INSIGHT_SDK_TEST
{
    partial class frmCamView
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
            this.components = new System.ComponentModel.Container();
            this.cvsInSightDisplay2 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.SuspendLayout();
            // 
            // cvsInSightDisplay2
            // 
            this.cvsInSightDisplay2.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay2.DialogIcon = null;
            this.cvsInSightDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsInSightDisplay2.Location = new System.Drawing.Point(0, 0);
            this.cvsInSightDisplay2.Name = "cvsInSightDisplay2";
            this.cvsInSightDisplay2.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.Default;
            this.cvsInSightDisplay2.Size = new System.Drawing.Size(849, 513);
            this.cvsInSightDisplay2.TabIndex = 1;
            // 
            // frmCamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 513);
            this.Controls.Add(this.cvsInSightDisplay2);
            this.Name = "frmCamView";
            this.Text = "frmCamView";
            this.ResumeLayout(false);

        }

        #endregion

        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay2;
    }
}