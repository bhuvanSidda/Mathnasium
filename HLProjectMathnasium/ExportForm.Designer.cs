
namespace HLProjectMathnasium
{
    partial class ExportForm
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
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pdf
            // 
            this.btn_pdf.Location = new System.Drawing.Point(291, 93);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(192, 65);
            this.btn_pdf.TabIndex = 0;
            this.btn_pdf.Text = "Text File";
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(291, 201);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(192, 59);
            this.btn_excel.TabIndex = 1;
            this.btn_excel.Text = "Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_pdf);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button btn_excel;
    }
}