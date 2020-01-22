namespace Jeaopardy_App
{
    partial class FormOptions
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
            this.lblOpt = new System.Windows.Forms.Label();
            this.radBtn1 = new System.Windows.Forms.RadioButton();
            this.radBtn2 = new System.Windows.Forms.RadioButton();
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.txtBx2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpt
            // 
            this.lblOpt.AutoSize = true;
            this.lblOpt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpt.ForeColor = System.Drawing.Color.Gold;
            this.lblOpt.Location = new System.Drawing.Point(11, 9);
            this.lblOpt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpt.Name = "lblOpt";
            this.lblOpt.Size = new System.Drawing.Size(104, 15);
            this.lblOpt.TabIndex = 0;
            this.lblOpt.Text = "How many players?";
            // 
            // radBtn1
            // 
            this.radBtn1.AutoSize = true;
            this.radBtn1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn1.ForeColor = System.Drawing.SystemColors.Control;
            this.radBtn1.Location = new System.Drawing.Point(169, 11);
            this.radBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.radBtn1.Name = "radBtn1";
            this.radBtn1.Size = new System.Drawing.Size(30, 19);
            this.radBtn1.TabIndex = 1;
            this.radBtn1.TabStop = true;
            this.radBtn1.Text = "1";
            this.radBtn1.UseVisualStyleBackColor = true;
            this.radBtn1.CheckedChanged += new System.EventHandler(this.radBtn1_CheckedChanged);
            // 
            // radBtn2
            // 
            this.radBtn2.AutoSize = true;
            this.radBtn2.BackColor = System.Drawing.Color.Indigo;
            this.radBtn2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radBtn2.Location = new System.Drawing.Point(204, 13);
            this.radBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.radBtn2.Name = "radBtn2";
            this.radBtn2.Size = new System.Drawing.Size(32, 19);
            this.radBtn2.TabIndex = 2;
            this.radBtn2.TabStop = true;
            this.radBtn2.Text = "2";
            this.radBtn2.UseVisualStyleBackColor = false;
            this.radBtn2.CheckedChanged += new System.EventHandler(this.radBtn2_CheckedChanged);
            // 
            // txtBx1
            // 
            this.txtBx1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx1.Location = new System.Drawing.Point(114, 41);
            this.txtBx1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.Size = new System.Drawing.Size(128, 23);
            this.txtBx1.TabIndex = 4;
            this.txtBx1.TextChanged += new System.EventHandler(this.txtBx1_TextChanged);
            // 
            // txtBx2
            // 
            this.txtBx2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx2.Location = new System.Drawing.Point(114, 82);
            this.txtBx2.Margin = new System.Windows.Forms.Padding(2);
            this.txtBx2.Name = "txtBx2";
            this.txtBx2.Size = new System.Drawing.Size(128, 23);
            this.txtBx2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player One Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player Two Name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gold;
            this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSubmit.Location = new System.Drawing.Point(269, 45);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 48);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(2, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "You will have 60 minutes before the game manually closes. \r\nYou will also  have 1" +
    " minute per question. \r\nGood luck!";
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(361, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx2);
            this.Controls.Add(this.txtBx1);
            this.Controls.Add(this.radBtn2);
            this.Controls.Add(this.radBtn1);
            this.Controls.Add(this.lblOpt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpt;
        private System.Windows.Forms.RadioButton radBtn1;
        private System.Windows.Forms.RadioButton radBtn2;
        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.TextBox txtBx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
    }
}

