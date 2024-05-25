namespace NotePad
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
            txtBody = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newbtn = new ToolStripMenuItem();
            openbtn = new ToolStripMenuItem();
            savebtn = new ToolStripMenuItem();
            saveAsbtn = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            Exit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cut = new ToolStripMenuItem();
            copy = new ToolStripMenuItem();
            paste = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            undo = new ToolStripMenuItem();
            redo = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            selectAll = new ToolStripMenuItem();
            Delete = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            findToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            backColorToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            foreColorToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBody
            // 
            txtBody.Dock = DockStyle.Fill;
            txtBody.Location = new Point(0, 30);
            txtBody.Margin = new Padding(3, 4, 3, 4);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.ScrollBars = ScrollBars.Both;
            txtBody.Size = new Size(914, 570);
            txtBody.TabIndex = 0;
            txtBody.WordWrap = false;
            txtBody.TextChanged += txtBody_TextChanged;
            txtBody.KeyUp += txtBody_KeyUp;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newbtn, openbtn, savebtn, saveAsbtn, toolStripMenuItem1, Exit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newbtn
            // 
            newbtn.Name = "newbtn";
            newbtn.ShortcutKeys = Keys.Control | Keys.N;
            newbtn.Size = new Size(181, 26);
            newbtn.Text = "New";
            newbtn.Click += newbtn_Click;
            // 
            // openbtn
            // 
            openbtn.Name = "openbtn";
            openbtn.ShortcutKeys = Keys.Control | Keys.O;
            openbtn.Size = new Size(181, 26);
            openbtn.Text = "Open";
            openbtn.Click += open_Click;
            // 
            // savebtn
            // 
            savebtn.Name = "savebtn";
            savebtn.ShortcutKeys = Keys.Control | Keys.S;
            savebtn.Size = new Size(181, 26);
            savebtn.Text = "Save";
            savebtn.Click += save_Click;
            // 
            // saveAsbtn
            // 
            saveAsbtn.Name = "saveAsbtn";
            saveAsbtn.Size = new Size(181, 26);
            saveAsbtn.Text = "Save as";
            saveAsbtn.Click += saveAsbtn_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(178, 6);
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.Size = new Size(181, 26);
            Exit.Text = "Exit";
            Exit.Click += Exit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cut, copy, paste, toolStripMenuItem2, undo, redo, toolStripMenuItem3, selectAll, Delete, toolStripMenuItem4, findToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // cut
            // 
            cut.Name = "cut";
            cut.Size = new Size(154, 26);
            cut.Text = "Cut";
            cut.Click += cut_Click;
            // 
            // copy
            // 
            copy.Name = "copy";
            copy.Size = new Size(154, 26);
            copy.Text = "Copy";
            copy.Click += copy_Click;
            // 
            // paste
            // 
            paste.Name = "paste";
            paste.Size = new Size(154, 26);
            paste.Text = "Paste";
            paste.Click += paste_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(151, 6);
            // 
            // undo
            // 
            undo.Name = "undo";
            undo.Size = new Size(154, 26);
            undo.Text = "Undo";
            undo.Click += undo_Click;
            // 
            // redo
            // 
            redo.Name = "redo";
            redo.Size = new Size(154, 26);
            redo.Text = "Redo";
            redo.Click += redo_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(151, 6);
            // 
            // selectAll
            // 
            selectAll.Name = "selectAll";
            selectAll.Size = new Size(154, 26);
            selectAll.Text = "Select All";
            selectAll.Click += selectAll_Click;
            // 
            // Delete
            // 
            Delete.Name = "Delete";
            Delete.Size = new Size(154, 26);
            Delete.Text = "Delete";
            Delete.Click += Delete_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(151, 6);
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(154, 26);
            findToolStripMenuItem.Text = "Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backColorToolStripMenuItem, foreColorToolStripMenuItem, fontToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "F&ormat";
            // 
            // backColorToolStripMenuItem
            // 
            backColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, greenToolStripMenuItem, blueToolStripMenuItem });
            backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            backColorToolStripMenuItem.Size = new Size(224, 26);
            backColorToolStripMenuItem.Text = "BackColor";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(224, 26);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(224, 26);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(224, 26);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // foreColorToolStripMenuItem
            // 
            foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            foreColorToolStripMenuItem.Size = new Size(224, 26);
            foreColorToolStripMenuItem.Text = "ForeColor";
            foreColorToolStripMenuItem.Click += foreColorToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(224, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtBody);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "NotePad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBody;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newbtn;
        private ToolStripMenuItem openbtn;
        private ToolStripMenuItem savebtn;
        private ToolStripMenuItem saveAsbtn;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem Exit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cut;
        private ToolStripMenuItem copy;
        private ToolStripMenuItem paste;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem undo;
        private ToolStripMenuItem redo;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem backColorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem foreColorToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem selectAll;
        private ToolStripMenuItem Delete;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem findToolStripMenuItem;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}
