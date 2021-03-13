using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressBar
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        public Form2()
        {

                this.progressBar1 = new System.Windows.Forms.ProgressBar();
                this.progressBar2 = new System.Windows.Forms.ProgressBar();
                this.SuspendLayout();
                // 
                // progressBar1
                // 
                this.progressBar1.Location = new System.Drawing.Point(94, 58);
                this.progressBar1.Name = "progressBar1";
                this.progressBar1.Size = new System.Drawing.Size(559, 23);
                this.progressBar1.TabIndex = 0;
                // 
                // progressBar2
                // 
                this.progressBar2.Location = new System.Drawing.Point(94, 111);
                this.progressBar2.Name = "progressBar2";
                this.progressBar2.Size = new System.Drawing.Size(559, 22);
                this.progressBar2.TabIndex = 1;
                // 
                // Form2
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(758, 450);
                this.Controls.Add(this.progressBar2);
                this.Controls.Add(this.progressBar1);
                this.Name = "Form2";
                this.Text = "Form2";
                this.ResumeLayout(false);

    }
    }
}
