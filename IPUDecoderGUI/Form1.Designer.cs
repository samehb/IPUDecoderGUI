namespace IPUDecoderGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.IPUStreamsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPUDecTabs = new System.Windows.Forms.TabControl();
            this.ConvertTab = new System.Windows.Forms.TabPage();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ModeCB = new System.Windows.Forms.CheckBox();
            this.IPUDecTabs.SuspendLayout();
            this.ConvertTab.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(481, 178);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcessBtn.TabIndex = 0;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // IPUStreamsListBox
            // 
            this.IPUStreamsListBox.AllowDrop = true;
            this.IPUStreamsListBox.FormattingEnabled = true;
            this.IPUStreamsListBox.HorizontalScrollbar = true;
            this.IPUStreamsListBox.Location = new System.Drawing.Point(13, 38);
            this.IPUStreamsListBox.Name = "IPUStreamsListBox";
            this.IPUStreamsListBox.Size = new System.Drawing.Size(543, 134);
            this.IPUStreamsListBox.TabIndex = 1;
            this.IPUStreamsListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.IPUStreamsListBox_DragDrop);
            this.IPUStreamsListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.IPUStreamsListBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drag and drop the IPS/IPU files into this box (make sure they are in the same fol" +
    "der as the tool)";
            // 
            // IPUDecTabs
            // 
            this.IPUDecTabs.Controls.Add(this.ConvertTab);
            this.IPUDecTabs.Controls.Add(this.AboutTab);
            this.IPUDecTabs.Location = new System.Drawing.Point(-4, 3);
            this.IPUDecTabs.Name = "IPUDecTabs";
            this.IPUDecTabs.SelectedIndex = 0;
            this.IPUDecTabs.Size = new System.Drawing.Size(578, 238);
            this.IPUDecTabs.TabIndex = 3;
            // 
            // ConvertTab
            // 
            this.ConvertTab.BackColor = System.Drawing.SystemColors.Control;
            this.ConvertTab.Controls.Add(this.ModeCB);
            this.ConvertTab.Controls.Add(this.IPUStreamsListBox);
            this.ConvertTab.Controls.Add(this.label1);
            this.ConvertTab.Controls.Add(this.ProcessBtn);
            this.ConvertTab.Location = new System.Drawing.Point(4, 22);
            this.ConvertTab.Name = "ConvertTab";
            this.ConvertTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConvertTab.Size = new System.Drawing.Size(570, 212);
            this.ConvertTab.TabIndex = 0;
            this.ConvertTab.Text = "Convert";
            // 
            // AboutTab
            // 
            this.AboutTab.BackColor = System.Drawing.SystemColors.Control;
            this.AboutTab.Controls.Add(this.textBox1);
            this.AboutTab.Controls.Add(this.label2);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(570, 212);
            this.AboutTab.TabIndex = 1;
            this.AboutTab.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 236);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "IPUDecoder";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.Location = new System.Drawing.Point(15, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 137);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // ModeCB
            // 
            this.ModeCB.AutoSize = true;
            this.ModeCB.Location = new System.Drawing.Point(369, 182);
            this.ModeCB.Name = "ModeCB";
            this.ModeCB.Size = new System.Drawing.Size(106, 17);
            this.ModeCB.TabIndex = 3;
            this.ModeCB.Text = "Alternative Mode";
            this.ModeCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 258);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.IPUDecTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "IPUDecoder";
            this.IPUDecTabs.ResumeLayout(false);
            this.ConvertTab.ResumeLayout(false);
            this.ConvertTab.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.ListBox IPUStreamsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl IPUDecTabs;
        private System.Windows.Forms.TabPage ConvertTab;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ModeCB;
    }
}

