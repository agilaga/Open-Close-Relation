namespace Open_Close_Relation
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
            this.labelstate = new System.Windows.Forms.Label();
            this.buttonaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelstate
            // 
            this.labelstate.AutoSize = true;
            this.labelstate.Location = new System.Drawing.Point(155, 162);
            this.labelstate.Name = "labelstate";
            this.labelstate.Size = new System.Drawing.Size(94, 16);
            this.labelstate.TabIndex = 0;
            this.labelstate.Text = "Not connected";
            // 
            // buttonaction
            // 
            this.buttonaction.Location = new System.Drawing.Point(563, 135);
            this.buttonaction.Name = "buttonaction";
            this.buttonaction.Size = new System.Drawing.Size(216, 129);
            this.buttonaction.TabIndex = 1;
            this.buttonaction.Text = "Connect";
            this.buttonaction.UseVisualStyleBackColor = true;
            this.buttonaction.Click += new System.EventHandler(this.buttonaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 503);
            this.Controls.Add(this.buttonaction);
            this.Controls.Add(this.labelstate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelstate;
        private System.Windows.Forms.Button buttonaction;
    }
}

