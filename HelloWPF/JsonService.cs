using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace HelloWPF
{
    public class JsonService
    {
        private string _Pfad = "jsonString.txt";

        //Schreibt die Personenliste als JsonString in einer txt-Datei
        public void AddData(List<Person> personen)
        {            
            string json = JsonConvert.SerializeObject(personen);            
            File.WriteAllText(_Pfad, json);
        }

        //Liest den JsonString aus und rekonstruiert das Model (Liste von Personen)
        public List<Person> GetData()
        {
            if (File.Exists(_Pfad))
            {
                string json = File.ReadAllText(_Pfad);
                return JsonConvert.DeserializeObject<List<Person>>(json);
            }

            return new List<Person>();
        }
    }
}
