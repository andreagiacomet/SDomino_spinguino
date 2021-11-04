using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaPinguino.DataProvider
{
    public class FileHandler
    {
        public (string,string,IEnumerable<string>) FileSeparator(string ordine)
        {
            string[] oggetto = ordine.Split(';');
            string basi = oggetto[0];
            string impasto = oggetto[1];
            IEnumerable<string> aggiunte = oggetto[2].Split(',');

            return (basi, impasto, aggiunte);
        }
    }
}
