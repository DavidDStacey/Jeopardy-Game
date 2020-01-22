namespace Jeaopardy_App
{
    partial class FormQandA
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
            this.txtBxQ = new System.Windows.Forms.TextBox();
            this.txtBxA = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxQ
            // 
            this.txtBxQ.BackColor = System.Drawing.Color.DarkMagenta;
            this.txtBxQ.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxQ.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBxQ.Location = new System.Drawing.Point(10, 11);
            this.txtBxQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxQ.Multiline = true;
            this.txtBxQ.Name = "txtBxQ";
            this.txtBxQ.ReadOnly = true;
            this.txtBxQ.Size = new System.Drawing.Size(316, 191);
            this.txtBxQ.TabIndex = 10;
            this.txtBxQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxA
            // 
            this.txtBxA.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxA.Location = new System.Drawing.Point(11, 215);
            this.txtBxA.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxA.Name = "txtBxA";
            this.txtBxA.Size = new System.Drawing.Size(314, 23);
            this.txtBxA.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.Gold;
            this.btnSubmit.Location = new System.Drawing.Point(121, 259);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 69);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkBlue;
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Gold;
            this.btnOK.Location = new System.Drawing.Point(121, 257);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 69);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormQandA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(340, 354);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBxA);
            this.Controls.Add(this.txtBxQ);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQandA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q and A Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQandA_FormClosed);
            this.Load += new System.EventHandler(this.FormQandA_Load);
            this.Shown += new System.EventHandler(this.FormQandA_Shown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxQ;
        private System.Windows.Forms.TextBox txtBxA;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnOK;
    }
}