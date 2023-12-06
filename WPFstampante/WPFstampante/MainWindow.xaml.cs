using System;
using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private Stampante stampante;

        public MainWindow()
        {
            InitializeComponent();

            stampante = new Stampante();
            AggiornaStato();
        }

        private void AggiornaStato()
        {
            // Aggiorna i controlli con lo stato corrente della stampante
            txtInchiostro.Text = $"Inchiostro - C: {stampante.C}, M: {stampante.M}, Y: {stampante.Y}, B: {stampante.B}";
            txtCarta.Text = $"Carta disponibile: {stampante.Fogli} fogli";
        }

        private void RegolaColore_Click(object sender, RoutedEventArgs e)
        {
            // Implementa la logica per regolare il colore
            // Potresti aprire una finestra di dialogo per selezionare il colore desiderato
            // e aggiornare i valori della stampante di conseguenza
            MessageBox.Show("Regola Colore");
        }

        private void RegolaFogli_Click(object sender, RoutedEventArgs e)
        {
            // Implementa la logica per regolare il numero di fogli
            // Potresti aprire una finestra di dialogo per inserire la nuova quantità di fogli
            // e aggiornare il valore della stampante di conseguenza
            MessageBox.Show("Regola Fogli");
        }

        private void TestStampaAnteprima_Click(object sender, RoutedEventArgs e)
        {
            // Implementa la logica per il test di stampa con anteprima
            // Potresti aprire una finestra di anteprima con la simulazione di stampa
            MessageBox.Show("Test Stampa con Anteprima");
        }

        private void StampaNormale_Click(object sender, RoutedEventArgs e)
        {
            // Implementa la logica per la stampa normale
            // Aggiorna la stampante e i controlli di stato di conseguenza
            Pagina pagina = new Pagina(1, 2, 3, 4); // Esempio di pagina con colori casuali

            bool stampaRiuscita = stampante.Stampa(pagina);

            if (stampaRiuscita)
            {
                MessageBox.Show("Pagina stampata con successo!");
            }
            else
            {
                MessageBox.Show("Impossibile stampare la pagina. Controllare lo stato della stampante.");
            }

            AggiornaStato();
        }
    }
}
