using System;
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
    public partial class Form1 : Form {


        Dictionary<string, Template> templates = new Dictionary<string, Template>();
        Template proba;
        int? activeRow;

        public Form1() {
            InitializeComponent();
            foreach (TextBox t in this.Controls.OfType<TextBox>()) {
                t.Text = t.Name;
                t.ForeColor = Color.Gray;
            }
            Jezik.Items.AddRange(predmeti.jezici.ToArray());
            Smer.Items.AddRange(new string[] {"Opšti", "Stručni", "Umetnički"});
            comboBox2.Items.AddRange(predmeti.strucni.Keys.ToArray());
            PrviPredmet.Items.AddRange(predmeti.jezici.ToArray());
            DrugiPredmet.Items.Add("Matematika");
            comboBox2.Enabled = false;

            button2.Enabled = false;
            button3.Enabled = false;
            activeRow = null;
        }

        private void loadTemplateFileToolStripMenuItem_Click(object sender, EventArgs e) {

            comboBox1.Items.Clear();
            comboBox1.Refresh();
            templates = new Dictionary<string, Template>();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";
            dialog.ShowDialog();

            try {
                StreamReader file = new StreamReader(dialog.OpenFile());
                while ( !file.EndOfStream ) { 
                    proba = new Template(file.ReadLine());
                    if ( templates.Keys.Contains(proba.ime) )
                        continue;
                    templates.Add(proba.ime, proba);
                }
                file.Close();
            } catch {
                MessageBox.Show("Došlo je do greške pri čitanju fajla.");
                return; 
            }


            comboBox1.Items.AddRange(templates.Keys.ToArray());

            

        }

        private void inputFromTemplate( Template t ) {
            if ( t == null ) return;

            Škola.Text = t.attr[0];
            Škola.ForeColor = Color.Black;
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
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";
            dialog.ShowDialog();
            try { 
                StreamWriter writer = new StreamWriter(dialog.OpenFile());
                foreach (Template t in templates.Values) {
                    writer.WriteLine(t.ToString());
                }
                writer.Close();
            } catch {}
            comboBox2.SelectedValue = "";

        }

        private void existingFileToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";
            dialog.ShowDialog();

            try { 
                StreamWriter writer = new StreamWriter(dialog.FileName, append: true);
                foreach (Template t in templates.Values) {
                    writer.WriteLine(t.ToString());
                }
                writer.Close();
            } catch {}
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {           
            foreach ( TextBox t in this.Controls.OfType<TextBox>() ) {
                if ( t.ForeColor != Color.Gray ) {
                    t.Text = t.Name;
                    t.ForeColor = Color.Gray;
                }
            }

            foreach ( ComboBox cb in this.Controls.OfType<ComboBox>() ) {
                cb.Text = "";
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
            //idk sta ovde treba da ide
        }

        private void Skola_TextChanged(object sender, EventArgs e)
        {

        }

        private void Smer_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox2.Enabled = false;
            TreciPredmet.Items.Clear();
            TreciPredmet.Text = "";
            switch ( Smer.SelectedItem ) {
                case "Opšti":
                    TreciPredmet.Items.AddRange(predmeti.opsta.ToArray());
                    break;
                case "Umetnički":
                    TreciPredmet.Items.AddRange(predmeti.umetnicka.ToArray());
                    break;
                case "Stručni":
                    comboBox2.Enabled = true;
                    if ( comboBox2.Text != "" )
                        TreciPredmet.Items.AddRange(predmeti.strucni[comboBox2.SelectedItem.ToString()].ToArray());
                    break;
                default:
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            TreciPredmet.Items.Clear();
            TreciPredmet.Text = "";
            TreciPredmet.Items.AddRange(predmeti.strucni[comboBox2.SelectedItem.ToString()].ToArray());
        }

        private void button1_Click(object sender, EventArgs e) {
            if ( PrviPredmet.Text == "Srpski jezik i književnost" && TreciPredmet.Text == "Srpski kao nematernji jezik" ) {
                MessageBox.Show("Ne može se dva puta polagati isti predmet.");
                return;
            }

            foreach ( TextBox t in this.Controls.OfType<TextBox>() ) {
                if ( t.ForeColor == Color.Gray ) {
                    MessageBox.Show("Polje " + t.Name + " je ostalo prazno.");
                    return;
                }
            }

            foreach (ComboBox cb in this.Controls.OfType<ComboBox>()) {
                if ( cb == comboBox1 || cb == comboBox2 ) continue;
                if ( cb.Text == "" ) {
                    MessageBox.Show("Polje " + cb.Name + " je ostalo prazno.");
                    return;
                }
            }

            string[] uce = new string[] {
                this.Ime.Text,
                this.PrezIme.Text,
                this.Odeljenje.Text,
                this.Škola.Text,
                this.Jezik.Text,
                this.PrviPredmet.Text,
                this.DrugiPredmet.Text,
                this.TreciPredmet.Text,
            };

            this.dataGridView1.Rows.Add(uce);
            
                
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) {
            activeRow = e.RowIndex;
            button2.Enabled = true;
            button3.Enabled = true;
            Ime.Text = (string)dataGridView1.Rows[(int)activeRow].Cells[0].Value;
            Ime.ForeColor = Color.Black;
            PrezIme.Text = (string)dataGridView1.Rows[(int)activeRow].Cells[1].Value;
            PrezIme.ForeColor = Color.Black;
            Odeljenje.Text = (string)dataGridView1.Rows[(int)activeRow].Cells[2].Value;
            Odeljenje.ForeColor = Color.Black;
            Škola.Text = (string)dataGridView1.Rows[(int)activeRow].Cells[3].Value;
            Škola.ForeColor = Color.Black;
            Jezik.Text = (string)dataGridView1.Rows[(int)activeRow].Cells[4].Value;
            Jezik.ForeColor = Color.Black;
            PrviPredmet.Text = (string)dataGridView1.Rows[(int)activeRow].Cells[5].Value;
            PrviPredmet.ForeColor = Color.Black;
            DrugiPredmet.ForeColor = Color.Black;
            DrugiPredmet.Text = (string)dataGridView1.Rows[(int)activeRow].Cells[6].Value;
            TreciPredmet.ForeColor = Color.Black;
            TreciPredmet.Text = (string)dataGridView1.Rows[(int)activeRow].Cells[7].Value;
        }

        private void button2_Click(object sender, EventArgs e) {
            if ( activeRow == null ) {
                MessageBox.Show("Nije izabran učenik.");
                button2.Enabled = false;
                button3.Enabled = false;
                return;
            }

            string[] uce = new string[] {
                this.Ime.Text,
                this.PrezIme.Text,
                this.Odeljenje.Text,
                this.Škola.Text,
                this.Jezik.Text,
                this.PrviPredmet.Text,
                this.DrugiPredmet.Text,
                this.TreciPredmet.Text,
            };

            dataGridView1.Rows[(int)activeRow].SetValues(uce);
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) {
            if (activeRow == null) {
                MessageBox.Show("Nije izabran učenik.");
                button2.Enabled = false;
                button3.Enabled = false;
                return;
            }


            dataGridView1.Rows.RemoveAt((int)activeRow);
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";
            dialog.ShowDialog();
            try { 
                StreamReader reader = new StreamReader(dialog.OpenFile());
                while ( !reader.EndOfStream ) {
                    string line = reader.ReadLine();
                    dataGridView1.Rows.Add(line.Split(";"));
                }
            } catch {}
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
            

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";
            dialog.ShowDialog();
            try { 
                StreamWriter writer = new StreamWriter(dialog.OpenFile());
                foreach ( DataGridViewRow row in dataGridView1.Rows ) {
                    string saved = "";
                    foreach ( DataGridViewCell s in row.Cells ) {
                        saved += s.Value + ";";
                    }
                    writer.WriteLine(saved);
                }
                writer.Close();
            } catch {}


        }

        private void button4_Click(object sender, EventArgs e) {
            if ( comboBox1.Text == "" ) {
                MessageBox.Show("Ime šablona ne sme da bude prazno.");
                return;
            }
            string saved = comboBox1.Text + ";";

            saved += Škola.ForeColor == Color.Gray ? "null;" : Škola.Text + ";";
            saved += Odeljenje.ForeColor == Color.Gray ? "null;" : Odeljenje.Text + ";";
            saved += Smer.ForeColor == Color.Gray ? "null;" : Smer.Text + ";";
            saved += Jezik.ForeColor == Color.Gray ? "null;" : Jezik.Text + ";";
            saved += PrviPredmet.ForeColor == Color.Gray ? "null;" : PrviPredmet.Text + ";";
            saved += DrugiPredmet.ForeColor == Color.Gray ? "null;" : DrugiPredmet.Text + ";";
            saved += TreciPredmet.ForeColor == Color.Gray ? "null;" : TreciPredmet.Text + ";";

            Template template = new Template(saved);

            try {
                templates.Add(comboBox1.Text, template);
                comboBox1.Items.Add(templates[comboBox1.Text].ime);
            } catch ( ArgumentException ) {
                MessageBox.Show("Šablon sa istim imenom vec postoji.");
            }
        }

        private void resetujSabloneToolStripMenuItem_Click(object sender, EventArgs e) {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Refresh();
            templates.Clear();
        }
    }
}
