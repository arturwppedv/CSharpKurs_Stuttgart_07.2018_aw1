using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Mitarbeiterverwaltung.Konstanten;
using Mitarbeiterverwaltung.Model;
using Mitarbeiterverwaltung.Dienste;
using System.Windows.Markup;
using System.Globalization;

namespace Mitarbeiterverwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();
        private MitarbeiterDienst mitarbeiterDienst = new MitarbeiterDienst();

        public MainWindow()
        {
            InitializeComponent();

            LanguageProperty.OverrideMetadata(
                typeof(FrameworkElement),
                new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));

            cmb_MitarbeiterTyp.Items.Add(Werte.MitarbeiterTyp.Azubi);
            cmb_MitarbeiterTyp.Items.Add(Werte.MitarbeiterTyp.Entwickler);
            cmb_MitarbeiterTyp.Items.Add(Werte.MitarbeiterTyp.Projektleiter);

            cmb_MitarbeiterTyp.SelectedIndex = 0;

            mitarbeiterListe = mitarbeiterDienst.GetMitarbeiter();
            lstv_Mitarbeiter.ItemsSource = mitarbeiterListe;

            dp_Eintritsdatum.SelectedDate = DateTime.Now;
            dp_Geburtsdatum.SelectedDate = DateTime.Now;
        }

        private void btn_MitarbeiterHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtb_Vorname.Text) &&
                !string.IsNullOrWhiteSpace(txtb_Nachname.Text))
            {
                switch (cmb_MitarbeiterTyp.SelectedItem)
                {
                    case Werte.MitarbeiterTyp.Azubi:

                        Azubi azubi;

                        //Gehtalt wurde nicht eingetragen
                        if (string.IsNullOrWhiteSpace(txtb_Gehalt.Text))
                        {
                            azubi = new Azubi(txtb_Vorname.Text, txtb_Nachname.Text,
                                            dp_Geburtsdatum.SelectedDate.Value, dp_Eintritsdatum.SelectedDate.Value);
                        }
                        else
                        {
                            azubi = new Azubi(txtb_Vorname.Text, txtb_Nachname.Text, dp_Geburtsdatum.SelectedDate.Value,
                                        dp_Eintritsdatum.SelectedDate.Value, Convert.ToDouble(txtb_Gehalt.Text));
                        }

                        mitarbeiterDienst.MitarbeiterAnlegen(azubi);
                        mitarbeiterListe.Add(azubi);
                        lstv_Mitarbeiter.Items.Refresh();

                        break;
                    case Werte.MitarbeiterTyp.Entwickler:

                        Entwickler entwickler;

                        //Gehtalt wurde nicht eingetragen
                        if (string.IsNullOrWhiteSpace(txtb_Gehalt.Text))
                        {
                            entwickler = new Entwickler(txtb_Vorname.Text, txtb_Nachname.Text,
                                            dp_Geburtsdatum.SelectedDate.Value, dp_Eintritsdatum.SelectedDate.Value);
                        }
                        else
                        {
                            entwickler = new Entwickler(txtb_Vorname.Text, txtb_Nachname.Text, dp_Geburtsdatum.SelectedDate.Value,
                                        dp_Eintritsdatum.SelectedDate.Value, Convert.ToDouble(txtb_Gehalt.Text));
                        }

                        mitarbeiterDienst.MitarbeiterAnlegen(entwickler);
                        mitarbeiterListe.Add(entwickler);
                        lstv_Mitarbeiter.Items.Refresh();

                        break;
                    case Werte.MitarbeiterTyp.Projektleiter:

                        Projektleiter projektleiter;

                        //Gehtalt wurde nicht eingetragen
                        if (string.IsNullOrWhiteSpace(txtb_Gehalt.Text))
                        {
                            projektleiter = new Projektleiter(txtb_Vorname.Text, txtb_Nachname.Text,
                                            dp_Geburtsdatum.SelectedDate.Value, dp_Eintritsdatum.SelectedDate.Value);
                        }
                        else
                        {
                            projektleiter = new Projektleiter(txtb_Vorname.Text, txtb_Nachname.Text, dp_Geburtsdatum.SelectedDate.Value,
                                        dp_Eintritsdatum.SelectedDate.Value, Convert.ToDouble(txtb_Gehalt.Text));
                        }

                        mitarbeiterDienst.MitarbeiterAnlegen(projektleiter);
                        mitarbeiterListe.Add(projektleiter);
                        lstv_Mitarbeiter.Items.Refresh();

                        break;
                }
            }
        }

        private void btn_Kuendigen_Click(object sender, RoutedEventArgs e)
        {
            foreach (Mitarbeiter mitar in lstv_Mitarbeiter.SelectedItems)
            {
                mitarbeiterDienst.Kuendigen(mitar);
                mitarbeiterListe.Remove(mitar);
            }
            lstv_Mitarbeiter.Items.Refresh();
        }

        private void btn_GehaltErhoehen_Click(object sender, RoutedEventArgs e)
        {
            foreach (Mitarbeiter mitar in lstv_Mitarbeiter.SelectedItems)
            {
                mitar.GehaltErhoehen();
                mitarbeiterDienst.Aktualisieren(mitar);
            }

            mitarbeiterListe = mitarbeiterDienst.GetMitarbeiter();
            lstv_Mitarbeiter.ItemsSource = mitarbeiterListe;
        }
    }
}
