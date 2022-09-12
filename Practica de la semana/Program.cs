using System;
using System.Collections;

namespace Practica_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {

            bool repit = true;
            do
            {
                int numberStudents;
                string firstname, lastname;
                double lab1, lab2, parcial;
                ArrayList list = new ArrayList();

                Console.Write("Ingrese el numero de estudiantes que desea evaluar: ");
                numberStudents = int.Parse(Console.ReadLine());
                Console.WriteLine();

                for (int i = 0; i < numberStudents; i++)
                {
                    Console.Write("Nombres: ");
                    firstname = Console.ReadLine();
                    Console.Write("Apellidos: ");
                    lastname = Console.ReadLine();
                    Console.Write("Nota de laboratorio 1: ");
                    lab1 = double.Parse(Console.ReadLine());
                    Console.Write("Nota de laboratorio 2: ");
                    lab2 = double.Parse(Console.ReadLine());
                    Console.Write("Nota de parcial: ");
                    parcial = double.Parse(Console.ReadLine());


                    list.Add (new Students(firstname, lastname, lab1, lab2, parcial));
                    Console.WriteLine("==============================");
                    Console.WriteLine("");
                }

                foreach (Students st in list)
                {
                    Console.WriteLine("* " + st.ReturnInfo());
                    double prom = st.ReturnGrades();
                    Console.WriteLine("Su promedio de notas es: {0}", prom);
                    Console.WriteLine((prom >= 6.0) ? " Aprovado" : " Reprovado");
                }
                Console.WriteLine();

                bool question;
                do
                {
                    Console.WriteLine(" Si desea finalizar el programa escriba 'S', de lo contrario escriba 'N'");
                    string response = Console.ReadLine();
                    switch (response)
                    {
                        case "S":
                        case "s":
                            repit = true;
                            question = true;
                            break;
                        case "N":
                        case "n":
                            repit = false;
                            question = false;
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            question = true;
                            break;
                    }
                } while (question);


            } while (repit);
            Console.WriteLine("Programa finalizado");
        }


        public class Students
        {
            private string _firstname;
            private string _lastname;
            private double _lab1;
            private double _lab2;
            private double _parcial;

            public Students ( string firstname, string lastname, double lab1, double lab2, double parcial)
            {
                this._firstname = firstname;
                this._lastname = lastname;
                this._lab1 = lab1;
                this._lab1 = lab2;
                this._parcial = parcial;
            }

            public string ReturnInfo() => _firstname + " " + _lastname;

            public double ReturnGrades() => (_lab1 * .3) + (_lab2 * .3) + (_parcial * .4);
        }
    }
}
