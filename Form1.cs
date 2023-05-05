﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp4 {
    public partial class Form1 : Form
    {
        Dictionary<string, Template> templates = new Dictionary<string, Template>();
        Template proba;
        public Form1() {
            InitializeComponent();
            foreach ( TextBox t in tabPage1.Controls.OfType<TextBox>()) {
                t.Text = t.Name;
                t.ForeColor = Color.Gray;
            }
        }

        private void loadTemplateFileToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";
            dialog.ShowDialog();

            try {
                StreamReader file = new StreamReader(dialog.OpenFile());
                while ( !file.EndOfStream ) { 
                    proba = new Template(file.ReadLine());
                    templates.Add(proba.ime, proba);
                }
            } catch { return; }


            comboBox1.Items.AddRange(templates.Keys.ToArray());


        }

        private void inputFromTemplate( Template t ) {
            if ( t == null ) return;

            Skola.Text = t.attr[0];
            Skola.ForeColor = Color.Black;
            Odeljenje.Text = t.attr[1];
            Odeljenje.ForeColor = Color.Black;
            Smer.Text = t.attr[2];
            Smer.ForeColor = Color.Black;
            Jezik.Text = t.attr[3];
            Jezik.ForeColor = Color.Black;
            PrviPredmet.Text = t.attr[4];
            PrviPredmet.ForeColor = Color.Black;
            DrugiPredmet.Text = t.attr[5];
            DrugiPredmet.ForeColor = Color.Black;
            TreciPredmet.Text = t.attr[6];
            TreciPredmet.ForeColor = Color.Black;


        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) {
            Template template = templates[(string)comboBox1.SelectedItem];
            inputFromTemplate(template);
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e) {
            string saved = comboBox1.Text + ";";

            saved += Skola.Text + ";";
            saved += Odeljenje.Text + ";";
            saved += Smer.Text + ";";
            saved += Jezik.Text + ";";
            saved += PrviPredmet.Text + ";";
            saved += DrugiPredmet.Text + ";";
            saved += TreciPredmet.Text + ";";

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";
            dialog.ShowDialog();
            StreamWriter writer = new StreamWriter(dialog.OpenFile());
            writer.WriteLine(saved);
            writer.Close();


        }

        private void existingFileToolStripMenuItem_Click(object sender, EventArgs e) {
            string saved = comboBox1.Text + ";";

            saved += textBox1.Text + ";";
            saved += textBox2.Text + ";";
            saved += textBox3.Text + ";";
            saved += textBox4.Text + ";";
            saved += textBox5.Text + ";";
            saved += textBox6.Text + ";";
            saved += textBox7.Text + ";";

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";
            dialog.ShowDialog();

            StreamWriter writer = new StreamWriter(dialog.FileName);
            writer.WriteLine(saved);
            writer.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            comboBox1.Refresh();
            templates.Clear();
            foreach ( TextBox t in tabPage1.Controls.OfType<TextBox>() ) {
                t.Clear();
            }
        }

        private void tabPage1_DragDrop(object sender, DragEventArgs e) {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if ( paths.Length > 1 ) return;

            try {
                StreamReader file = new StreamReader(paths[0]);
                while ( !file.EndOfStream ) { 
                    proba = new Template(file.ReadLine());
                    templates.Add(proba.ime, proba);
                }
            } catch { return; }


            foreach ( string key in templates.Keys ) {
                if ( comboBox1.Items.Contains(key) ) continue;
                comboBox1.Items.Add(key);
            }
        }

        private void tabPage1_DragEnter(object sender, DragEventArgs e){
            e.Effect = DragDropEffects.Move;
        }

        private void placeholderTextEn(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if ( textBox.ForeColor == Color.Gray ) {
                textBox.Clear();
                textBox.ForeColor = Color.Black;
            }
        }

        private void placeholderTextLe(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if ( textBox.Text == "" ) {
                textBox.Text = textBox.Name;
                textBox.ForeColor = Color.Gray;

            }
        }

        private void Odeljenje_TextChanged(object sender, EventArgs e)
        {

        }

        private void Skola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
