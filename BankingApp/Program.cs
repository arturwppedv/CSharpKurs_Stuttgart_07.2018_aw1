using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            List<Person> personList = new List<Person>();
            Person selectedPerson;

            //Hauptmenü => Programm wird erst beendet, wenn man 'exit' eingibt
            while (!isExit)
            {
                Console.Clear();
                int z = 0;
                string auswahl;
                Console.WriteLine("##### Banking-App #####");
                Console.WriteLine("Wählen Sie eine Person: ");
                Console.WriteLine("new: Neue Person anlegen");
                Console.WriteLine("exit: Programm beenden");

                //Listet alle Personen auf mit der Zahl, mit der man diese auswählt
                foreach (Person p in personList)
                {
                    Console.WriteLine($"{z}: {p}");
                    z++;
                }

                //liest die Auswahl aus
                auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    //Menü, um eine neue Person anzulegen (Vorname, Nachname werden abgefragt), wird angezeigt
                    case "new":
                        ShowNewPersonDialog();
                        break;
                    //Programm wird beendet
                    case "exit":
                        isExit = true;
                        break;
                    //Person wird aus der Personenliste gewählt und das Banking-Menü wird geöffnet
                    default:
                        selectedPerson = personList[Convert.ToInt32(auswahl)];
                        OpenBankingMenu();
                        break;
                }
            }

            void ShowNewPersonDialog()
            {
                Console.Clear();    //Konsolenfenster wird geleert
                Person newPerson = new Person();
                Console.WriteLine("-----Neue Person anlegen-----");

                Console.WriteLine("Vorname:");
                newPerson.Vorname = Console.ReadLine();

                Console.WriteLine("Nachname:");
                newPerson.Nachname = Console.ReadLine();

                personList.Add(newPerson);

                Console.WriteLine($"{newPerson.Vorname} {newPerson.Nachname} wurde erfolgreich angelegt");
            }

            void OpenBankingMenu()
            {
                bool isInWork = false;
                Console.Clear();
                while (!isInWork)
                {
                    int benutzerWahl;
                    Console.WriteLine($"#### Sie sind eingeloggt als {selectedPerson.Vorname} {selectedPerson.Nachname} ####");
                    Console.WriteLine("Wählen Sie eine Option:");
                    Console.WriteLine("1: Anzeigen aller Konten");
                    Console.WriteLine("2: Überweisen/Umbuchen");
                    Console.WriteLine("3: Einzahlen");
                    Console.WriteLine("4: Neues Konto anlegen");
                    Console.WriteLine("5: clear screen");
                    Console.WriteLine("6: Zurück zum Hauptmenü");

                    benutzerWahl = Convert.ToInt32(Console.ReadLine());

                    switch (benutzerWahl)
                    {
                        case 1:
                            ShowAlleKonten();
                            break;
                        case 2:
                            OpenTransferDialog();
                            break;
                        case 3:
                            OpenEinzahlenDialog();
                            break;
                        case 4:
                            OpenAddKontoDialog();
                            break;
                        case 5:
                            Console.Clear();
                            break;
                        case 6:
                            isInWork = true;
                            break;
                    }
                }
            }

            void ShowAlleKonten()
            {
                Console.WriteLine("###### Alle Konten ######");

                foreach (Konto kto in selectedPerson.Konten)
                {
                    string type;
                    if (kto is Girokonto)
                        type = "Girokonto";
                    else if (kto is Sparkonto)
                        type = "Sparkonto";
                    else
                        type = "Tagesgeld";

                    Console.WriteLine($"###### {kto.Kontonummer} ######## {kto.Guthaben} ######### {type} ######");
                }
            }

            void OpenAddKontoDialog()
            {
                Console.Clear();
                Console.WriteLine("Wähle Typ aus:");
                Console.WriteLine("1: Girokonto");
                Console.WriteLine("2: Sparkonto");
                Console.WriteLine("3: Tagesgeld");

                AddKonto(Convert.ToInt32(Console.ReadLine()));


            }

            void OpenEinzahlenDialog()
            {
                Console.Clear();
                Console.WriteLine("Geben Sie die Kto-Nr ein:");
                int ktoNr = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben Sie die Summe ein:");
                double summe = Convert.ToDouble(Console.ReadLine());

                if (selectedPerson.Konten.Find(x => x.Kontonummer == ktoNr) != null)
                {
                    selectedPerson.Konten.First(x => x.Kontonummer == ktoNr).Einzahlen(summe);
                    Console.WriteLine($"{summe} wurden auf das Konto {ktoNr} eingezahlt");
                    return;
                }

                Console.WriteLine($"Es wurde kein Konto mit der Nr {ktoNr} gefunden");
            }

            void OpenTransferDialog()
            {
                Console.WriteLine("Absender KtoNr");
                int absender = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Empfänger Name");
                string empfängerName = Console.ReadLine();

                Console.WriteLine("Empfänger KtoNr");
                int empfänger = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Betrag");
                double betrag = Convert.ToInt32(Console.ReadLine());

                Person empfängerPerson;

                try
                {
                    if (!string.IsNullOrEmpty(empfängerName))
                        empfängerPerson = personList.First(x => (x.Vorname + " " + x.Nachname) == empfängerName);
                    else
                        empfängerPerson = selectedPerson;

                    if (empfängerPerson != null)
                    {
                        Konto absKto = selectedPerson.Konten.First(x => x.Kontonummer == absender);
                        Konto empfKto = empfängerPerson.Konten.First(x => x.Kontonummer == empfänger);

                        //Konto absKonto;
                        //foreach (Konto kto in selectedPerson.Konten)
                        //{
                        //    if (kto.Kontonummer == absender)
                        //    {
                        //        absKonto = kto;
                        //        break;
                        //    }
                        //}

                        if (!absKto.IsDisposition)
                        {
                            if (absKto.Guthaben - betrag < 0)
                            {
                                Console.WriteLine("Konto hat kein Dispo und nicht genügend Guthaben.");
                                return;
                            }
                        }
                        else
                        {
                            if (absKto is Girokonto)
                            {
                                (absKto as Girokonto).Überweisen(empfKto, betrag);
                            }
                            else if (absKto is Sparkonto)
                            {
                                (absKto as Sparkonto).Umbuchen(empfKto, betrag);
                            }
                            else
                            {
                                (absKto as Tagesgeldkonto).Umbuchen(empfKto, betrag);
                            }


                            Console.WriteLine("Überweisung/Umbuchung erfolgreich erledigt");
                            return;
                        }
                    }

                    Console.WriteLine("Empfänger nicht gefunden!!!");
                }
                catch(InvalidOperationException ex)
                {
                    Console.WriteLine("KontoNr oder Empfängername wurde nicht gefunden");
                    Console.WriteLine(ex.Message);
                }
                catch(NullReferenceException nex)
                {

                }
                catch(Exception)
                {

                }
                //finally
                //{

                //}

            }

            //Neues Konto wird zu der Konten-Liste der gewählten Person hinzugefügt
            //und eine KtoNr wird zufällig generiert (zwischen 1000 und 10000)
            void AddKonto(int auswahl)
            {
                Random rand = new Random();
                switch (auswahl)
                {
                    case 1:
                        selectedPerson.Konten.Add(new Girokonto(rand.Next(1000, 10000), 0, selectedPerson));
                        Console.WriteLine("Girokonto wurde erfolgreich angelegt");
                        break;
                    case 2:
                        selectedPerson.Konten.Add(new Sparkonto(rand.Next(1000, 10000), 0, selectedPerson));
                        Console.WriteLine("Sparkonto wurde erfolgreich angelegt");
                        break;
                    case 3:
                        selectedPerson.Konten.Add(new Tagesgeldkonto(rand.Next(1000, 10000), 0, selectedPerson));
                        Console.WriteLine("Girokonto wurde erfolgreich angelegt");
                        break;
                }
            }
        }
    }
}
