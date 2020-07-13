using System;

namespace Prueba_votacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            // variables para saber los totales de los candidatos.
            int C1 = 0;
            int C2 = 0;
            int C3 = 0;
            int C4 = 0;
            int votos;
            int votos_random;
            double totales;
            double CA1, CA2, CA3, CA4;


            // MENU
            Console.WriteLine("Bienvenidos a las votaciones presidenciales 2020.");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("             Candidatos  a la Presidencia en este periodo electoral:                |");
            Console.WriteLine("------------------------------------------------------------------------------------|");
            Console.WriteLine("         Partido Politico                                   |      Candidato        |");
            Console.WriteLine("---------------------------------------------------------- -|-----------------------|");
            Console.WriteLine("1. PPSEP partido por superacion en programacion.(17/07/96)  | Luis Eduardo Taveras  |");
            Console.WriteLine("2. PPSDN partido por la salvacion de la nota.   (22/03/93)  | Angel Alberto Pichardo|");
            Console.WriteLine("3. PAV  partido anti vagos .                    (21/04/93)  | Francis Sosa Abreu    |");
            Console.WriteLine("4. UEDM Union Estudiantil de Miguel Moreta      (15/01/94)  | Rafael Nicolas Breton |");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("                                RESULTADOS                       |");
            Console.WriteLine("-----------------------------------------------------------------|");
            Console.WriteLine(" Lugar   |   Candidato           | Votos   |Porcientos en voto   |");




            /*                        NOTA :
             *!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
             como los votos son aleatorios no puse que el usuario ingresara su votos si no que  lo hice directo
             !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            */


            // MANDATOS PARA LOS VOTOS ( bucle con random)
            for (votos = 0; votos <= 1000; votos++)
            {
                Random rnd = new Random();
                votos_random = rnd.Next(1, 5);

                // CONDICIONES PARA SABER LOS RESULTADOS 
                if (votos_random == 1)
                {
                    C1++;
                }
                if (votos_random == 2)
                {
                    C2++;
                }
                if (votos_random == 3)
                {
                    C3++;
                }
                if (votos_random == 4)
                {
                    C4++;
                }
            }
            totales = C1 + C2 + C3 + C4;
            // porcientos de los candidatos 
            CA1 = (C1 / totales) * 100;
            CA2 = (C2 / totales) * 100;
            CA3 = (C3 / totales) * 100;
            CA4 = (C4 / totales) * 100;

            //condiciones para el orden de los candidatos. 
            //Primer Lugar Luis Eduardo Taveras
            if (C1 > C2 && C1 > C3 && C1 > C4)
            {
                Console.WriteLine("1er lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                if (C2 > C3 && C2 > C4)
                {
                    Console.WriteLine("2do lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");

                    if (C3 > C4)
                    {
                        Console.WriteLine("3er lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                        Console.WriteLine("4to lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");

                    }

                    if (C4 > C3)
                    {
                        Console.WriteLine("3er lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");

                        Console.WriteLine("4to lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");


                    }
                }

                if (C3 > C2 && C3 > C4)
                {
                    Console.WriteLine("2do lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                    if (C2 > C4)
                    {
                        Console.WriteLine("3er lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                        Console.WriteLine("4to lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                    }
                    if (C4 > C2)
                    {
                        Console.WriteLine("3er lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                        Console.WriteLine("4to lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                    }
                }
                if (C4 > C2 && C4 > C3)
                {
                    Console.WriteLine("2do lugar| Rafael Nicolas Breton |" + C4 + " votos| " + "un " + CA4 + "% |");
                    if (C2 > C3)
                    {
                        Console.WriteLine("3er lugar| Angel Alberto Pichardo|" + C2 + " votos| " + "un " + CA2 + "% |");
                        Console.WriteLine("4to lugar| Francis Sosa Abreu    |" + C3 + " votos| " + "un " + CA1 + "% |");
                    }
                    if (C3 > C2)
                    {
                        Console.WriteLine("3er lugar| Francis Sosa Abreu    |" + C3 + " votos| " + "un " + CA3 + "% |");
                        Console.WriteLine("4to lugar| Angel Alberto Pichardo|" + C2 + " votos| " + "un " + CA2 + "% |");
                    }
                }
            }

            // Primer Lugar Angel Alberto
            if (C2 > C1 && C2 > C3 && C2 > C4)
            {
                Console.WriteLine("1er lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                if (C1 > C3 && C1 > C4)
                {
                    Console.WriteLine("2do lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                    if (C3 > C4)
                    {
                        Console.WriteLine("3er lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                        Console.WriteLine("4to lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                    }
                    if (C4 > C3)
                    {
                        Console.WriteLine("3er lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                        Console.WriteLine("4to lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                    }
                }
                if (C3 > C1 && C3 > C4)
                {
                    Console.WriteLine("2do lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                    if (C1 > C4)
                    {
                        Console.WriteLine("3er lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                        Console.WriteLine("4to lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                    }
                    if (C4 > C1)
                    {
                        Console.WriteLine("3er lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                        Console.WriteLine("4to lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                    }
                }
                if (C4 > C3 && C4 > C1)
                {
                    Console.WriteLine("2do lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                    if (C1 > C3)
                    {
                        Console.WriteLine("3er lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                        Console.WriteLine("4to lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                    }

                    if (C3 > C1)
                    {
                        Console.WriteLine("3er lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                        Console.WriteLine("4to lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                    }

                }
            }

            //Primer Lugar Francis Sosa
            if (C3 > C2 && C3 > C1 && C3 > C4)
            {
                Console.WriteLine("1er lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                if (C1 > C2 && C1 > C4)
                {
                    Console.WriteLine("2do lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                    if (C2 > C4)
                    {
                        Console.WriteLine("3er lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                        Console.WriteLine("4to lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                    }
                    if (C4 > C2)
                    {
                        Console.WriteLine("3er lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                        Console.WriteLine("4to lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                    }
                }
                if (C2 > C1 && C2 > C4)
                {
                    Console.WriteLine("2do lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                    if (C1 > C4)
                    {
                        Console.WriteLine("3er lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                        Console.WriteLine("4to lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                    }
                    if (C4 > C1)
                    {
                        Console.WriteLine("3er lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                        Console.WriteLine("4to lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                    }
                }
                if (C4 > C2 && C4 > C1)
                {
                    Console.WriteLine("2do lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                    if (C1 > C2)
                    {
                        Console.WriteLine("3er lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                        Console.WriteLine("4to lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                    }
                    if (C2 > C1)
                    {
                        Console.WriteLine("3er lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                        Console.WriteLine("4to lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                    }
                }
            }

            //Primer Lugar Rafael Nicola Breton
            if (C4 > C2 && C4 > C3 && C4 > C1)
            {
                Console.WriteLine("1er lugar| Rafael Nicolas Breton |" + C4 + " votos| " + CA4 + "% |");
                if (C1 > C2 && C1 > C3)
                {
                    Console.WriteLine("2do lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                    if (C2 > C3)
                    {
                        Console.WriteLine("3er lugar| Angel Alberto Pichardo | " + C2 + " votos| " + CA2 + "% |");
                        Console.WriteLine("4to lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                    }
                    if (C3 > C2)
                    {
                        Console.WriteLine("3er lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                        Console.WriteLine("4to lugar| Angel Alberto Pichardo|" + C2 + " votos| " + CA2 + "% |");
                    }

                }

                if (C2 > C1 && C2 > C3)
                {
                    Console.WriteLine("2do lugar| Angel Alberto Pichardo | " + C2 + " votos| " + CA2 + "% |");
                    if (C1 > C3)
                    {
                        Console.WriteLine("3er lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                        Console.WriteLine("4to lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                    }
                    if (C3 > C1)
                    {
                        Console.WriteLine("3er lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                        Console.WriteLine("4to lugar| Luis Eduardo Taveras  | " + C2 + " votos| " + CA2 + "% |");
                    }
                }

                if (C3 > C2 && C3 > C1)
                {
                    Console.WriteLine("2do lugar| Francis Sosa Abreu    |" + C3 + " votos| " + CA3 + "% |");
                    if (C1 > C2)
                    {
                        Console.WriteLine("3er lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                        Console.WriteLine("4to lugar| Angel Alberto Pichardo | " + C2 + " votos| " + CA2 + "% |");
                    }
                    if (C2 > C1)
                    {
                        Console.WriteLine("3er lugar| Angel Alberto Pichardo | " + C2 + " votos| " + CA2 + "% |");
                        Console.WriteLine("4to lugar| Luis Eduardo Taveras  |" + C1 + " votos| " + CA1 + "% |");
                    }
                }
            }
            Console.WriteLine("-----------------------------------------------------------------|");
            Console.WriteLine("");
        }
    }
}
