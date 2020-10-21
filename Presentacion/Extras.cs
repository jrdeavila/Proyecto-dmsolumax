using System;

namespace Presentacion
{
    public class Extras
    {
        public static double IsNumber(string Cadena){
            double value = 0;
            try{
                Console.Write(Cadena); value = double.Parse(Console.ReadLine());
            }
            catch(Exception){
                Console.WriteLine("No es un valor numerico");
                value  = IsNumber(Cadena);
            }
            return value;
        }

        public static string Sexo(){
            string sexo = "M";
            Console.Write("Sexo = (M/F): "); sexo = Console.ReadLine();
            sexo = sexo.ToUpper();
            if(!sexo.Equals("M") && !sexo.Equals("F")){
                Console.WriteLine("Opcion invalida");
                 sexo = Sexo();
            }
            return sexo;
        }
        public static string SiNo(string Cadena){
            string siNo = "N";
            Console.Write(Cadena + "(S/N): "); siNo = Console.ReadLine();
            siNo = siNo.ToUpper();
            if(!siNo.Equals("N") && !siNo.Equals("S")){
                Console.WriteLine("Opcion invalida");
                 siNo = SiNo(Cadena);
            }
            return siNo;
        }
    }
}
