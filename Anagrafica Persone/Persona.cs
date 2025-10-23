using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagrafica_Persone
{
    public class Persona
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public DateTime DataNascita { get; set; }

        public int Eta
        {
            get
            {
                int eta = DateTime.Now.Year - DataNascita.Year;
                if (DateTime.Now.DayOfYear < DataNascita.DayOfYear)
                {
                    eta--;
                }
                return eta;
            }
        }

        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
        }

        public override string ToString()
        {
            string dataFormattata = DataNascita.ToString("d");
            return $"{Cognome}, {Nome} (Nato il: {dataFormattata}, Età: {Eta})";
        }
    }
}