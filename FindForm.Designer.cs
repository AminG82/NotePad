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
            txtFind.Location = new Point(76, 26);
            txtFind.Margin = new Padding(3, 2, 3, 2);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(255, 23);
            txtFind.TabIndex = 0;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(345, 26);
            btnFind.Margin = new Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(82, 22);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "Find";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 66);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Replace";
            // 
            // txtReplace
            // 
            txtReplace.Location = new Point(76, 64);
            txtReplace.Margin = new Padding(3, 2, 3, 2);
            txtReplace.Name = "txtReplace";
            txtReplace.Size = new Size(255, 23);
            txtReplace.TabIndex = 4;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(344, 105);
            btnReplace.Margin = new Padding(3, 2, 3, 2);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(82, 22);
            btnReplace.TabIndex = 5;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            btnFindNext.Location = new Point(344, 66);
            btnFindNext.Margin = new Padding(3, 2, 3, 2);
            btnFindNext.Name = "btnFindNext";
            btnFindNext.Size = new Size(82, 22);
            btnFindNext.TabIndex = 6;
            btnFindNext.Text = "Find Next";
            btnFindNext.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 138);
            Controls.Add(btnFindNext);
            Controls.Add(btnReplace);
            Controls.Add(txtReplace);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Margin = new Padding(3, 2, 3, 2);
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