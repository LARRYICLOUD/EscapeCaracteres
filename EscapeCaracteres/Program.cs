﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Secuencia de caracteres

            //Secuencia de escape "Nueva Linea" \n
            // \t hace lo que haria la tecla tabulacion
            //\r retorno de carro

            Console.WriteLine("YO SOY UN PROGRAMADOR\n Y EXPERTO EN REDES EXCELENTE\n Y RECONOCIDO");
            Console.WriteLine("Así es la vida,\t así de irónica,\r\nunos llevan a cuesta la cruz que otro debe cargar." +
                "\r\nAsí es la vida; así de lógica,\r\ncada quien tiene alguna historia que hablar o callar,\r\nasí es la vida, así...................");

            // Secuencia de escape"\a" Sonido de alerta

            Console.WriteLine("Presiona cualquier tecla para confirmar: ");
            Console.ReadKey();
            Console.WriteLine("\n\a ¡Aviso! Esta accion no puede cancelarse");

            Console.ReadKey();

            //Secuencia de escape "Retorno de carro" /r regresara el cursor al inicio
            //y sobreescribira los caracteres
            Console.WriteLine("1234567\r89");

            //Secuencia de escape de "retroceso" \b
            Console.WriteLine("1234567\b89");

            //Secuencia de escape Comilla doble   \"
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO: \n\" yo soy un programador y experto en redes reconocido.\"");

            Console.WriteLine("El tipo char se caracteriza por estar encerrado entre comillas simples, ejemplo: char caracter = \'c\'");

            //Secuencia de escape "Barra diagonal inversa" \\
            Console.WriteLine("El archivo se encuentra en la ruta: C:\\Windows\\Fonts");


            



        }
    }
}
