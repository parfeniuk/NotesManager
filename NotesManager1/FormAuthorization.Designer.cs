namespace NotesManager1
{
    partial class FormAuthorization
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
            this.EntranceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntranceBtn
            // 
            this.EntranceBtn.Location = new System.Drawing.Point(119, 69);
            this.EntranceBtn.Name = "EntranceBtn";
            this.EntranceBtn.Size = new System.Drawing.Size(97, 38);
            this.EntranceBtn.TabIndex = 0;
            this.EntranceBtn.Text = "Entrance";
            this.EntranceBtn.UseVisualStyleBackColor = true;
            this.EntranceBtn.Click += new System.EventHandler(this.EntranceBtn_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 181);
            this.Controls.Add(this.EntranceBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAuthorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EntranceBtn;
    }
}

