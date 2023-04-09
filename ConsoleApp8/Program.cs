using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Llamamos la instancia de las funciones:
                Librarys.Functions function = new Librarys.Functions();

                Console.Title = "Prime Cinema";
                string accion, accion_user;
                Console.Write("\n\t\t\t\t\t\t Primer uso Prime Cinema");
                Console.Write("\n");
                Console.Write("\n\t\t\t\t\t\t Qué acción dese realizar: ");
                function.Opciones();
                Console.Write("\n\n\t\t\t Opción: ");
                accion_user = Console.ReadLine().ToString();
                switch (accion_user)
                {
                    case "1":

                        do
                        {
                            Console.Clear();
                            // Registro del primer user
                            int cant_user;
                            Console.Write("\n\t\t Ingrese la cantidad de usuarios a registrar: ");
                            cant_user = int.Parse(Console.ReadLine());
                            string[] usuario = new string[cant_user];
                            string[] nombre = new string[cant_user];
                            string[] password = new string[cant_user];
                            int[] documento = new int[cant_user];
                            string[] correo = new string[cant_user];
                            int[] telefono = new int[cant_user];

                            string usuario_1;

                            Console.Clear();
                            Console.Write("\n\t\t\t\t\t\t Proyecto - Prime Cinema");
                            for (int a = 0; a < usuario.Length; a++)
                            {
                                Console.Write("\n\n\t\t Ingresa el nombre del usuario " + (a + 1) + " : ");
                                usuario[a] = Console.ReadLine();
                                for (int b = 0; b < nombre.Length; b++)
                                {
                                    Console.Write("\n\t\t Ingresa el tu nombre completo: ");
                                    usuario_1 = Console.ReadLine().ToString();
                                    for (int c = 0; c < password.Length; c++)
                                    {
                                        Console.Write("\n\t\t Ingresa la contraseña para el usuario: " + (c + 1) + " : ");
                                        password[c] = Console.ReadLine();
                                        for (int d = 0; d < documento.Length; d++)
                                        {
                                            Console.Write("\n\t\t Ingresa tu número de DUI: ");
                                            documento[d] = int.Parse(Console.ReadLine());
                                            for (int e = 0; e < correo.Length; e++)
                                            {
                                                Console.Write("\n\t\t Ingresa tu correo electrónico: ");
                                                correo[e] = Console.ReadLine();
                                                for (int f = 0; f < telefono.Length; f++)
                                                {
                                                    Console.Write("\n\t\t Ingresa tu número telefónico: ");
                                                    telefono[f] = int.Parse(Console.ReadLine());
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            Console.Clear();
                            Console.Write("\n\t\t\t\t\t\t Login Prime Cinema");
                            Console.Write("\n");

                            int contador = 0;
                            string user = "", password_user = "";
                            Boolean eval = false;
                            do
                            {
                                Console.Write("\n\t\t Ingrese el nombre de su Usuario : ");
                                user = Console.ReadLine().ToString();
                                Console.Write("\n\t\t Ingrese la contraseña de su Usuario : ");
                                password_user = Console.ReadLine().ToString();
                                if (function.SearchUser(usuario, user) && function.SearchPasswrod(password, password_user))
                                {
                                    eval = true;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\n\t\t\t\t El usuario no está registrado, o su contraseña es incorrecta!");
                                    Console.Write("\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    contador++;
                                    eval = false;
                                }

                            } while (eval == false && contador < 3);
                            // Verificamos la existencia del usuario
                            if (eval)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n\t\t\t\t\t\t\t Acceso conseguido");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\t\t\t\t\t\t Acceso Denegado!");
                                Console.ForegroundColor = ConsoleColor.White;
                                contador++;
                            }

                            Console.Write("\n\t Desea realizar otr a acción: ");
                            accion = Console.ReadLine().ToString();
                        } while (accion == "Si");

                        break;
                    case "2":

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write("" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
