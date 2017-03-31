﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TP1 {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("Nombre de salarié: {0}", Salarie.NombreSalarie);
      Salarie s1 = new Salarie("Moh", 2, 1, 0, 100.0D);

      GC.Collect();
      GC.WaitForPendingFinalizers();

      Salarie s2 = new Salarie("Mo", 2, 1, 0, 100.0D);
      Console.WriteLine("Nombre de salarié: {0}", Salarie.NombreSalarie);
     
      Console.WriteLine(s1.Equals(2));
      Console.WriteLine("-------------- Commercial ------------");
      Commercial c1 = new Commercial("MohCommercial", 2, 1, 0, 100.0D, 15);
      Console.WriteLine(c1.ToString());

      Salarie s3 = new Salarie("AAA", 2, 1, 0, 100.0D);
      Salarie s4 = new Salarie("AB", 2, 1, 0, 100.0D);
      Console.WriteLine("Comparaison des salariés: {0} ", s4.CompareTo(s3));

           
    }

    public static void Fun() {
      Salarie s = new Salarie("Moh", 2, 1, 0, 100.0D);
      Console.WriteLine("Nombre de salarié: {0}", Salarie.NombreSalarie);

    }
  }
}
