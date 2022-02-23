
namespace HLProjectMathnasium
{
    partial class ImportForm
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
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_instructor = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_instructor = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tbox_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(289, 112);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(220, 20);
            this.tbox_name.TabIndex = 0;
            this.tbox_name.TextChanged += new System.EventHandler(this.tbox_name_TextChanged);
            // 
            // tbox_instructor
            // 
            this.tbox_instructor.Location = new System.Drawing.Point(289, 169);
            this.tbox_instructor.Name = "tbox_instructor";
            this.tbox_instructor.Size = new System.Drawing.Size(220, 20);
            this.tbox_instructor.TabIndex = 1;
            this.tbox_instructor.TextChanged += new System.EventHandler(this.tbox_instructor_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(196, 112);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_instructor
            // 
            this.lbl_instructor.AutoSize = true;
            this.lbl_instructor.Location = new System.Drawing.Point(196, 169);
            this.lbl_instructor.Name = "lbl_instructor";
            this.lbl_instructor.Size = new System.Drawing.Size(54, 13);
            this.lbl_instructor.TabIndex = 3;
            this.lbl_instructor.Text = "Instructor:";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(334, 23);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(132, 46);
            this.lbl_header.TabIndex = 4;
            this.lbl_header.Text = "Import";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(342, 291);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(124, 40);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(196, 220);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(33, 13);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "Time:";
            // 
            // tbox_time
            // 
            this.tbox_time.Location = new System.Drawing.Point(290, 215);
            this.tbox_time.Name = "tbox_time";
            this.tbox_time.Size = new System.Drawing.Size(220, 20);
            this.tbox_time.TabIndex = 7;
            this.tbox_time.TextChanged += new System.EventHandler(this.tbox_time_TextChanged);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbox_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_instructor);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tbox_instructor);
            this.Controls.Add(this.tbox_name);
            this.Name = "ImportForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_instructor;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_instructor;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox tbox_time;
    }
}