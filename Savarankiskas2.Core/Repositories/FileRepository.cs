using Savarankiskas2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2.Core.Repositories
{
    public class FileRepository
    {
        private string _fileLocation;

        public FileRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
        }

        public List<Knyga> GautiKnygas()
        {
            List<Knyga> knygos = new List<Knyga>();
            using (StreamReader sr = new StreamReader(_fileLocation))
            {
                while (!sr.EndOfStream)
                {
                    string eilute = sr.ReadLine();
                    if (string.IsNullOrEmpty(eilute))
                    {
                        break;
                    }
                    string[] reiksmes = eilute.Split(',');
                    knygos.Add(new Knyga(int.Parse(reiksmes[0]), reiksmes[1], reiksmes[2], int.Parse(reiksmes[3]), reiksmes[4]));
                }
            }
            return knygos;
        }
    }
}
