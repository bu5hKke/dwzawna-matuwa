
namespace WinFormsApp4
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
            this.PrezIme = new System.Windows.Forms.TextBox();
            this.DrugiPredmet = new System.Windows.Forms.TextBox();
            this.PrviPredmet = new System.Windows.Forms.TextBox();
            this.Jezik = new System.Windows.Forms.TextBox();
            this.Smer = new System.Windows.Forms.TextBox();
            this.Odeljenje = new System.Windows.Forms.TextBox();
            this.Skola = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ucenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTemplateFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TreciPredmet = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrezIme
            // 
            this.PrezIme.Location = new System.Drawing.Point(17, 322);
            this.PrezIme.Name = "PrezIme";
            this.PrezIme.Size = new System.Drawing.Size(452, 23);
            this.PrezIme.TabIndex = 1;
            // 
            // DrugiPredmet
            // 
            this.DrugiPredmet.Location = new System.Drawing.Point(17, 195);
            this.DrugiPredmet.Name = "DrugiPredmet";
            this.DrugiPredmet.Size = new System.Drawing.Size(452, 23);
            this.DrugiPredmet.TabIndex = 1;
            this.DrugiPredmet.Enter += new System.EventHandler(this.placeholderTextEn);
            this.DrugiPredmet.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // PrviPredmet
            // 
            this.PrviPredmet.Location = new System.Drawing.Point(17, 166);
            this.PrviPredmet.Name = "PrviPredmet";
            this.PrviPredmet.Size = new System.Drawing.Size(452, 23);
            this.PrviPredmet.TabIndex = 1;
            this.PrviPredmet.Enter += new System.EventHandler(this.placeholderTextEn);
            this.PrviPredmet.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // Jezik
            // 
            this.Jezik.Location = new System.Drawing.Point(17, 137);
            this.Jezik.Name = "Jezik";
            this.Jezik.Size = new System.Drawing.Size(452, 23);
            this.Jezik.TabIndex = 1;
            this.Jezik.Enter += new System.EventHandler(this.placeholderTextEn);
            this.Jezik.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // Smer
            // 
            this.Smer.Location = new System.Drawing.Point(17, 108);
            this.Smer.Name = "Smer";
            this.Smer.Size = new System.Drawing.Size(452, 23);
            this.Smer.TabIndex = 1;
            this.Smer.Enter += new System.EventHandler(this.placeholderTextEn);
            this.Smer.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // Odeljenje
            // 
            this.Odeljenje.Location = new System.Drawing.Point(17, 79);
            this.Odeljenje.Name = "Odeljenje";
            this.Odeljenje.Size = new System.Drawing.Size(452, 23);
            this.Odeljenje.TabIndex = 1;
            this.Odeljenje.Enter += new System.EventHandler(this.placeholderTextEn);
            this.Odeljenje.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // Skola
            // 
            this.Skola.Location = new System.Drawing.Point(17, 50);
            this.Skola.Name = "Skola";
            this.Skola.Size = new System.Drawing.Size(452, 23);
            this.Skola.TabIndex = 1;
            this.Skola.Enter += new System.EventHandler(this.placeholderTextEn);
            this.Skola.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ucenikToolStripMenuItem,
            this.templateToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 22);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ucenikToolStripMenuItem
            // 
            this.ucenikToolStripMenuItem.Name = "ucenikToolStripMenuItem";
            this.ucenikToolStripMenuItem.Size = new System.Drawing.Size(93, 18);
            this.ucenikToolStripMenuItem.Text = "Ucitaj ucenike";
            // 
            // templateToolStripMenuItem
            // 
            this.templateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTemplateFileToolStripMenuItem,
            this.saveTemplateToolStripMenuItem});
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(67, 18);
            this.templateToolStripMenuItem.Text = "Template";
            // 
            // loadTemplateFileToolStripMenuItem
            // 
            this.loadTemplateFileToolStripMenuItem.Name = "loadTemplateFileToolStripMenuItem";
            this.loadTemplateFileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadTemplateFileToolStripMenuItem.Text = "Load Template File";
            this.loadTemplateFileToolStripMenuItem.Click += new System.EventHandler(this.loadTemplateFileToolStripMenuItem_Click);
            // 
            // saveTemplateToolStripMenuItem
            // 
            this.saveTemplateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.existingFileToolStripMenuItem});
            this.saveTemplateToolStripMenuItem.Name = "saveTemplateToolStripMenuItem";
            this.saveTemplateToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveTemplateToolStripMenuItem.Text = "Save Template";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // existingFileToolStripMenuItem
            // 
            this.existingFileToolStripMenuItem.Name = "existingFileToolStripMenuItem";
            this.existingFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.existingFileToolStripMenuItem.Text = "Existing File";
            this.existingFileToolStripMenuItem.Click += new System.EventHandler(this.existingFileToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 18);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 477);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.TreciPredmet);
            this.tabPage1.Controls.Add(this.Ime);
            this.tabPage1.Controls.Add(this.PrezIme);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.DrugiPredmet);
            this.tabPage1.Controls.Add(this.Skola);
            this.tabPage1.Controls.Add(this.PrviPredmet);
            this.tabPage1.Controls.Add(this.Odeljenje);
            this.tabPage1.Controls.Add(this.Jezik);
            this.tabPage1.Controls.Add(this.Smer);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unos informacija";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragDrop);
            this.tabPage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragEnter);
            // 
            // TreciPredmet
            // 
            this.TreciPredmet.Location = new System.Drawing.Point(17, 224);
            this.TreciPredmet.Name = "TreciPredmet";
            this.TreciPredmet.Size = new System.Drawing.Size(452, 23);
            this.TreciPredmet.TabIndex = 1;
            this.TreciPredmet.Enter += new System.EventHandler(this.placeholderTextEn);
            this.TreciPredmet.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(17, 293);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(452, 23);
            this.Ime.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spisak ucenika";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(479, 418);
            this.checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 517);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(537, 556);
            this.MinimumSize = new System.Drawing.Size(537, 556);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTemplateFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ucenikToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox PrezIme;
        private System.Windows.Forms.TextBox DrugiPredmet;
        private System.Windows.Forms.TextBox PrviPredmet;
        private System.Windows.Forms.TextBox Jezik;
        private System.Windows.Forms.TextBox Smer;
        private System.Windows.Forms.TextBox Odeljenje;
        private System.Windows.Forms.TextBox Skola;
        private System.Windows.Forms.TextBox TreciPredmet;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
    }
}

