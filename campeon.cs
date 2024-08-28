/******************************************************************************

Autor:       Steven Ruiz - Simon Gallego - Samuel Castaño - Jeronimo Pulgarin 
             Juan Jose Tapasco - David Becerra

Fecha:       21-08-2024

Descripcion: Programa que genera unos corredores y cumple ciertos criterios
*******************************************************************************/
using System;

class CloseMenu
{
    static void Main()
    { 
        Random random = new Random();
        for (int i = 1; i <= 7; i++)
        {
            int Posicion = random.Next(1,8);

            if (Posicion == 1)
            {
                Console.WriteLine("eres el campeon señor uno");
            }

            else if (Posicion == 3)
            {
                Console.WriteLine("el pueblo esta contigo tres");
            }
        }
    }
}
