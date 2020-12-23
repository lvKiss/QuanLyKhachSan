
namespace DXApplication1
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
            this.btnShowNhanVienForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowNhanVienForm
            // 
            this.btnShowNhanVienForm.Location = new System.Drawing.Point(205, 110);
            this.btnShowNhanVienForm.Name = "btnShowNhanVienForm";
            this.btnShowNhanVienForm.Size = new System.Drawing.Size(231, 23);
            this.btnShowNhanVienForm.TabIndex = 0;
            this.btnShowNhanVienForm.Text = "Mở form nhân viên";
            this.btnShowNhanVienForm.UseVisualStyleBackColor = true;
            this.btnShowNhanVienForm.Click += new System.EventHandler(this.btnShowNhanVienForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 442);
            this.Controls.Add(this.btnShowNhanVienForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowNhanVienForm;
    }
}

