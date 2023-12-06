using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfStampante
{
    public partial class MainWindow : Window
    {
        private Stampante stampante;

        public MainWindow()
        {
            InitializeComponent();

            // Inizializza la stampante
            stampante = new Stampante();

            // Aggiorna i controlli con lo stato iniziale
            AggiornaStato();
        }

        private void AggiornaStato()
        {
            // Aggiorna i controlli con lo stato corrente della stampante
            txtInchiostro.Text = $"Inchiostro - C: {stampante.C}, M: {stampante.M}, Y: {stampante.Y}, B: {stampante.B}";
            txtCarta.Text = $"Carta disponibile: {stampante.Fogli} fogli";
        }

        private void StampaPagina_Click(object sender, RoutedEventArgs e)
        {
            // Crea una pagina con colori casuali
            Pagina pagina = new Pagina();

            // Prova a stampare la pagina
            bool stampaRiuscita = stampante.Stampa(pagina);

            if (stampaRiuscita)
            {
                MessageBox.Show("Pagina stampata con successo!");
            }
            else
            {
                MessageBox.Show("Impossibile stampare la pagina. Controllare lo stato della stampante.");
            }

            // Aggiorna i controlli con lo stato aggiornato della stampante
            AggiornaStato();
        }
    }
}

