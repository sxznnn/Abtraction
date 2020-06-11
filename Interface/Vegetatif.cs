using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Abtraction.Interface
{
    public class Vegetatif : IReproduksi
    {
        public void BerkembangBiak()
        {
            Console.WriteLine("Vegetatif adalah merupakan perkembangbiakan yang dilakukan tumbuhan tanpa adanya peleburan antar dua sel gamet dari jantan dan betina");
        }
    }
}
