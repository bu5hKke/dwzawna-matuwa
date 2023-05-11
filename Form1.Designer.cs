
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PrezIme = new System.Windows.Forms.TextBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TreciPredmet = new System.Windows.Forms.ComboBox();
            this.PrviPredmet = new System.Windows.Forms.ComboBox();
            this.DrugiPredmet = new System.Windows.Forms.ComboBox();
            this.Jezik = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Smer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Ime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrezIme
            // 
            this.PrezIme.Location = new System.Drawing.Point(544, 442);
            this.PrezIme.Name = "PrezIme";
            this.PrezIme.Size = new System.Drawing.Size(452, 23);
            this.PrezIme.TabIndex = 1;
            this.PrezIme.Enter += new System.EventHandler(this.placeholderTextEn);
            this.PrezIme.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // Odeljenje
            // 
            this.Odeljenje.Location = new System.Drawing.Point(929, 196);
            this.Odeljenje.Name = "Odeljenje";
            this.Odeljenje.Size = new System.Drawing.Size(67, 23);
            this.Odeljenje.TabIndex = 1;
            this.Odeljenje.Enter += new System.EventHandler(this.placeholderTextEn);
            this.Odeljenje.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // Skola
            // 
            this.Skola.Location = new System.Drawing.Point(544, 196);
            this.Skola.Name = "Skola";
            this.Skola.Size = new System.Drawing.Size(379, 23);
            this.Skola.TabIndex = 1;
            this.Skola.Enter += new System.EventHandler(this.placeholderTextEn);
            this.Skola.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 149);
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
            this.menuStrip1.Size = new System.Drawing.Size(1008, 22);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Predmet 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Predmet 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Predmet 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jezik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Smer";
            // 
            // TreciPredmet
            // 
            this.TreciPredmet.FormattingEnabled = true;
            this.TreciPredmet.Location = new System.Drawing.Point(616, 341);
            this.TreciPredmet.Name = "TreciPredmet";
            this.TreciPredmet.Size = new System.Drawing.Size(380, 23);
            this.TreciPredmet.TabIndex = 4;
            // 
            // PrviPredmet
            // 
            this.PrviPredmet.FormattingEnabled = true;
            this.PrviPredmet.Location = new System.Drawing.Point(616, 283);
            this.PrviPredmet.Name = "PrviPredmet";
            this.PrviPredmet.Size = new System.Drawing.Size(380, 23);
            this.PrviPredmet.TabIndex = 4;
            // 
            // DrugiPredmet
            // 
            this.DrugiPredmet.FormattingEnabled = true;
            this.DrugiPredmet.Location = new System.Drawing.Point(616, 312);
            this.DrugiPredmet.Name = "DrugiPredmet";
            this.DrugiPredmet.Size = new System.Drawing.Size(380, 23);
            this.DrugiPredmet.TabIndex = 4;
            // 
            // Jezik
            // 
            this.Jezik.FormattingEnabled = true;
            this.Jezik.Location = new System.Drawing.Point(616, 254);
            this.Jezik.Name = "Jezik";
            this.Jezik.Size = new System.Drawing.Size(380, 23);
            this.Jezik.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(766, 225);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(230, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Smer
            // 
            this.Smer.FormattingEnabled = true;
            this.Smer.Location = new System.Drawing.Point(616, 225);
            this.Smer.Name = "Smer";
            this.Smer.Size = new System.Drawing.Size(144, 23);
            this.Smer.TabIndex = 3;
            this.Smer.SelectedIndexChanged += new System.EventHandler(this.Smer_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(892, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(544, 413);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(452, 23);
            this.Ime.TabIndex = 1;
            this.Ime.Enter += new System.EventHandler(this.placeholderTextEn);
            this.Ime.Leave += new System.EventHandler(this.placeholderTextLe);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(517, 480);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormsApp4.Properties.Resources.komtreid;
            this.pictureBox1.Location = new System.Drawing.Point(544, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Odeljenje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Skola);
            this.Controls.Add(this.TreciPredmet);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PrviPredmet);
            this.Controls.Add(this.PrezIme);
            this.Controls.Add(this.DrugiPredmet);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.Jezik);
            this.Controls.Add(this.Smer);
            this.Controls.Add(this.comboBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 556);
            this.MinimumSize = new System.Drawing.Size(537, 556);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Comtrade™ DrzavnaMatura-inator™ 2023";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox PrezIme;
        private System.Windows.Forms.TextBox Odeljenje;
        private System.Windows.Forms.TextBox Skola;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TreciPredmet;
        private System.Windows.Forms.ComboBox PrviPredmet;
        private System.Windows.Forms.ComboBox DrugiPredmet;
        private System.Windows.Forms.ComboBox Jezik;
        private System.Windows.Forms.ComboBox Smer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

