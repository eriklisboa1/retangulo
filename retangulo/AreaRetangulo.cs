using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace retangulo
{
    public class AreaRetangulo
    {
       public double Largura;
       public double Altura;

        public double Area()
        {
               return Largura * Altura;
        }

        public double Perimetro()
        {
            return (2 * Largura) + (2 * Altura);
        }
        public double Diagonal()
        {
            double cal = (Largura * Largura) + (Altura * Altura);
            return Math.Sqrt(cal);
                
        }
         
        public override string ToString()
        {
            return "Area = " + Area().ToString("F2", CultureInfo.InvariantCulture)
               + "\nPerimetro = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
               + "\nDiagonal = " + Diagonal();
        }
    }
}
