namespace NotePad
{
    partial class FindForm
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
            txtFind = new TextBox();
            btnFind = new Button();
            label1 = new Label();
            label2 = new Label();
            txtReplace = new TextBox();
            btnReplace = new Button();
            btnFindNext = new Button();
            SuspendLayout();
            // 
            // txtFind
            // 
            txtFind.Location = new Point(87, 35);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(291, 27);
            txtFind.TabIndex = 0;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(394, 35);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 2;
            label1.Text = "Find";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 88);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Replace";
            // 
            // txtReplace
            // 
            txtReplace.Location = new Point(87, 85);
            txtReplace.Name = "txtReplace";
            txtReplace.Size = new Size(291, 27);
            txtReplace.TabIndex = 4;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(393, 140);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(94, 29);
            btnReplace.TabIndex = 5;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // btnFindNext
            // 
            btnFindNext.Location = new Point(393, 88);
            btnFindNext.Name = "btnFindNext";
            btnFindNext.Size = new Size(94, 29);
            btnFindNext.TabIndex = 6;
            btnFindNext.Text = "Find Next";
            btnFindNext.UseVisualStyleBackColor = true;
            btnFindNext.Click += btnFindNext_Click;
            // 
            // FindForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 184);
            Controls.Add(btnFindNext);
            Controls.Add(btnReplace);
            Controls.Add(txtReplace);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Name = "FindForm";
            Text = "FindForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFind;
        private Button btnFind;
        private Label label1;
        private Label label2;
        private TextBox txtReplace;
        private Button btnReplace;
        private Button btnFindNext;
    }
}