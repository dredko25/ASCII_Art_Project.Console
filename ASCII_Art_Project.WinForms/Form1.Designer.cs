namespace ASCII_Art_Project.WinForms
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
            this.labelText = new System.Windows.Forms.Label();
            this.buttonConsole = new System.Windows.Forms.Button();
            this.buttonForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelText.Location = new System.Drawing.Point(99, 61);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(278, 24);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Оберіть інтерфейс програми:";
            // 
            // buttonConsole
            // 
            this.buttonConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonConsole.Location = new System.Drawing.Point(58, 139);
            this.buttonConsole.Name = "buttonConsole";
            this.buttonConsole.Size = new System.Drawing.Size(167, 50);
            this.buttonConsole.TabIndex = 1;
            this.buttonConsole.Text = "Консольний";
            this.buttonConsole.UseVisualStyleBackColor = true;
            this.buttonConsole.Click += new System.EventHandler(this.buttonConsole_Click);
            // 
            // buttonForms
            // 
            this.buttonForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonForms.Location = new System.Drawing.Point(261, 139);
            this.buttonForms.Name = "buttonForms";
            this.buttonForms.Size = new System.Drawing.Size(167, 50);
            this.buttonForms.TabIndex = 2;
            this.buttonForms.Text = "Графічний";
            this.buttonForms.UseVisualStyleBackColor = true;
            this.buttonForms.Click += new System.EventHandler(this.buttonForms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 236);
            this.Controls.Add(this.buttonForms);
            this.Controls.Add(this.buttonConsole);
            this.Controls.Add(this.labelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ASCII_Art_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonConsole;
        private System.Windows.Forms.Button buttonForms;
    }
}

