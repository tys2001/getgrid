namespace GetGrid
{
    partial class ConfigForm
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
            this.labelNull = new System.Windows.Forms.Label();
            this.textNull = new System.Windows.Forms.TextBox();
            this.textSeparator = new System.Windows.Forms.TextBox();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textQuotePre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNull
            // 
            this.labelNull.AutoSize = true;
            this.labelNull.Location = new System.Drawing.Point(12, 15);
            this.labelNull.Name = "labelNull";
            this.labelNull.Size = new System.Drawing.Size(67, 12);
            this.labelNull.TabIndex = 0;
            this.labelNull.Text = "NULLリテラル";
            // 
            // textNull
            // 
            this.textNull.Location = new System.Drawing.Point(139, 12);
            this.textNull.Name = "textNull";
            this.textNull.Size = new System.Drawing.Size(133, 19);
            this.textNull.TabIndex = 1;
            // 
            // textSeparator
            // 
            this.textSeparator.Location = new System.Drawing.Point(139, 37);
            this.textSeparator.Name = "textSeparator";
            this.textSeparator.Size = new System.Drawing.Size(133, 19);
            this.textSeparator.TabIndex = 2;
            // 
            // labelSeparator
            // 
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.Location = new System.Drawing.Point(12, 40);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(53, 12);
            this.labelSeparator.TabIndex = 2;
            this.labelSeparator.Text = "文末記号";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(220, 105);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(52, 28);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textQuotePre
            // 
            this.textQuotePre.Location = new System.Drawing.Point(139, 62);
            this.textQuotePre.Name = "textQuotePre";
            this.textQuotePre.Size = new System.Drawing.Size(133, 19);
            this.textQuotePre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "値プレフィックス";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.textQuotePre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textSeparator);
            this.Controls.Add(this.labelSeparator);
            this.Controls.Add(this.textNull);
            this.Controls.Add(this.labelNull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.Text = "設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNull;
        private System.Windows.Forms.TextBox textNull;
        private System.Windows.Forms.TextBox textSeparator;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textQuotePre;
        private System.Windows.Forms.Label label1;
    }
}