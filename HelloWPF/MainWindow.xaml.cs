using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _Countdown = 15;
        private List<Person> personenListe = new List<Person>();

        //Konstruktor
        public MainWindow()
        {
            //Generiert die Benutzeroberfläche
            InitializeComponent();

            txtb_Name.Focus();

            //Eine neue Spalte zu der ListView hinzufügen
            //(lstv_Personen.View as GridView).Columns.Add(new GridViewColumn() { Header = "Fahrzeug" });

            //Die Personenliste dient als Quelle für die Tabelle (ListView)
            lstv_Personen.ItemsSource = personenListe;
        }

        //sender ist das Steuerelement, was den Event ausgelöst hat
        //e sind EventArguments. Diese enthalten weitere Event-Informationen
        private void btn_ClickMe_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello WPF");
            
            //Der DispatcherTimer macht ein Invoke auf die Steuerelemente,
            //die es verwendet, damit der nächste Thread darauf zugreifen kann
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,1);
            timer.Tick += (s, re) =>
            {
                _Countdown--;
                lbl_Text.Content = _Countdown;

                if (_Countdown <= 0)
                {
                    timer.Stop();
                    _Countdown = 15;
                    btn_ClickMe.IsEnabled = true;
                }
            };

            timer.Start();


            //Den Button deaktivieren wir, 
            //damit wir keinen weiteren Timer erstellen können
            btn_ClickMe.IsEnabled = false;

            //Funktioniert nicht, da kein Invoke gemacht wird
            //Timer timer = new Timer();
            //timer.Interval = 1000;
            //timer.Elapsed += (s, re) =>
            //{
            //    _Countdown--;
            //    lbl_Text.Content = _Countdown;

            //    if (_Countdown <= 0)
            //        timer.Stop();
            //};

            //timer.Start();
        }

        private void btn_Hinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            //Neue Person wird erstellt
            //Überprüft, ob die Textfelder leer sind oder nur Leerzeichen enthalten. 
            //Legt eine neue Person nur dann an, wenn
            //beide Textfelder befüllt sind
            if (!string.IsNullOrWhiteSpace(txtb_Vorname.Text) && !string.IsNullOrWhiteSpace(txtb_Name.Text))
            {
                Person neuePerson = new Person()
                {
                    Vorname = txtb_Vorname.Text,
                    Nachname = txtb_Name.Text
                };

                //Neue Person wird in die Liste gelegt (Diese ist ja die Quelle der ListView)
                personenListe.Add(neuePerson);

                //ListView-Oberfläche wird aktualisiert
                lstv_Personen.Items.Refresh();

                txtb_Name.Clear();
                txtb_Vorname.Clear();
            }
            else
                MessageBox.Show("Mind. ein Textfeld ist leer");
        }
    }
}
