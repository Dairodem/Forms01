using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Forms01
{
    public class User
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public User(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
    }
}
