namespace WinFormDelegates {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnOpenChildForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxCount = new System.Windows.Forms.TextBox();
            this.lblHitCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenChildForm
            // 
            this.btnOpenChildForm.Location = new System.Drawing.Point(498, 46);
            this.btnOpenChildForm.Name = "btnOpenChildForm";
            this.btnOpenChildForm.Size = new System.Drawing.Size(112, 34);
            this.btnOpenChildForm.TabIndex = 0;
            this.btnOpenChildForm.Text = "Start timer!";
            this.btnOpenChildForm.UseVisualStyleBackColor = true;
            this.btnOpenChildForm.Click += new System.EventHandler(this.btnOpenChildForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Until when should the timer count?";
            // 
            // tbMaxCount
            // 
            this.tbMaxCount.Location = new System.Drawing.Point(325, 48);
            this.tbMaxCount.Name = "tbMaxCount";
            this.tbMaxCount.Size = new System.Drawing.Size(150, 31);
            this.tbMaxCount.TabIndex = 2;
            // 
            // lblHitCount
            // 
            this.lblHitCount.AutoSize = true;
            this.lblHitCount.Location = new System.Drawing.Point(211, 110);
            this.lblHitCount.Name = "lblHitCount";
            this.lblHitCount.Size = new System.Drawing.Size(0, 25);
            this.lblHitCount.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHitCount);
            this.Controls.Add(this.tbMaxCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenChildForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenChildForm;
        private Label label1;
        private TextBox tbMaxCount;
        private Label lblHitCount;
    }
}