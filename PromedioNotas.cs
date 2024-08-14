using System;

public class nota
{
    static void Main ()
    {
        double n1,n2,n3,promedio;
        string linea;
        // n/ significa "newt line"
        Console.WriteLine("ingrese las tres notas del estudiante");
        Console.Write("");
        
        Console.Write("ingrese el valor de n1:");
        linea=Console.ReadLine();
        n1=double.Parse(linea);
        
        Console.Write("ingrese el valor de n2:");
        linea=Console.ReadLine();
        n2=double.Parse(linea);
        
        Console.Write("ingrese el valor de n3:");
        linea=Console.ReadLine();
        n3=double.Parse(linea);
        
        promedio=(n1+n2+n3)/3;
        
        
        if (promedio<=2.9 &&  promedio>=0)  {
            Console.WriteLine("insuficiente");
        } else  {
            if (promedio<=3.5) {
                Console.WriteLine("aceptable");
            } else {
                if (promedio<=4.5){
                    Console.WriteLine("interesante");
                } else {
                    if (promedio<=5.0){
                        Console.WriteLine("excelente");
                    }else {
                        Console.WriteLine("el numero no entra en los parametros");
                    }
                }
            }
        }
    }
}
