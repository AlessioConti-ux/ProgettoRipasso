namespace ProgettoRipasso
{
    public partial class Form1 : Form
    {

        List<string> prodotti = new List<string>();
        List<double> prezzi = new List<double>();
        List<int> quantita = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtArticolo.Text) ||
                string.IsNullOrWhiteSpace(txtPrezzo.Text) ||
                string.IsNullOrWhiteSpace(txtQuantita.Text))
            {

                MessageBox.Show("errore");
                return;

            }
            else
            {

                double prezzo = Convert.ToDouble(txtPrezzo.Text);
                int quant = Convert.ToInt32(txtQuantita.Text);
                double Tot = prezzo * quant;

                prodotti.Add(txtArticolo.Text);
                prezzi.Add(Convert.ToDouble(prezzo));
                quantita.Add(Convert.ToInt32(quant));

                listBox.Items.Add("x" + quant + " " + txtArticolo.Text + " - " + "$" + Tot);

                CalcolaTotale();
                txtArticolo.Clear();
                txtPrezzo.Clear();
                txtQuantita.Clear();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indice = listBox.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Seleziona un elmento");
                return;
            }
            else
            {

                listBox.Items.RemoveAt(indice);
                prodotti.RemoveAt(indice);
                prezzi.RemoveAt(indice);
                quantita.RemoveAt(indice);
                CalcolaTotale();
            }
        }

        //funzione per calcolare il totale
        private void CalcolaTotale()
        {
            double totale = 0;

            for (int i = 0; i < prezzi.Count; i++)
            {
                totale = totale + prezzi[i] * quantita[i];
            }

            lblPrezzo.Text = "€ " + totale.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (prodotti.Count == 0)
            {
                MessageBox.Show("Il carrello è vuoto!");
                return;
            }
            else
            {
                File.WriteAllText("scontrini.csv", "");
                string dataOra = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                double totale = 0;

                for (int i = 0; i < prodotti.Count; i++)
                {
                    double totaleRiga = prezzi[i] * quantita[i];
                    totale = totale + totaleRiga;
                    string riga = dataOra + " " + prodotti[i] + " " + quantita[i] + "pcs " + prezzi[i] + "$ " + "tot:" + totaleRiga + "$" + "\n";
                    File.AppendAllText("scontrini.csv", riga);
                    File.AppendAllText("scontrini.csv","TOTALE: " + totale + "$");
                }

                MessageBox.Show("Scontrino emesso e salvato su scontrini.csv!");

                prodotti.Clear();
                prezzi.Clear();
                quantita.Clear();
                listBox.Items.Clear();
                CalcolaTotale();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbltitolo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
