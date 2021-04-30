
namespace Fibonacci
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.outputlb = new System.Windows.Forms.ListBox();
            this.clcbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(10, 10);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(46, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Anzahl:";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(60, 2);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(50, 23);
            this.tb.TabIndex = 2;
            // 
            // outputlb
            // 
            this.outputlb.FormattingEnabled = true;
            this.outputlb.Location = new System.Drawing.Point(10, 67);
            this.outputlb.Name = "outputlb";
            this.outputlb.Size = new System.Drawing.Size(200, 200);
            this.outputlb.TabIndex = 5;
            // 
            // clcbtn
            // 
            this.clcbtn.Location = new System.Drawing.Point(10, 31);
            this.clcbtn.Name = "clcbtn";
            this.clcbtn.Size = new System.Drawing.Size(100, 30);
            this.clcbtn.TabIndex = 4;
            this.clcbtn.Text = "Berechnung";
            this.clcbtn.UseVisualStyleBackColor = true;
            this.clcbtn.Click += new System.EventHandler(this.clcbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 312);
            this.Controls.Add(this.clcbtn);
            this.Controls.Add(this.outputlb);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.ListBox outputlb;
        private System.Windows.Forms.Button clcbtn;
    }
}

