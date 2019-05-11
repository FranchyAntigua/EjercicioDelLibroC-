using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCap1_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("  \n \n ----------- Menu-------------- \n \n");
            Console.WriteLine("Pulse 1 para los ejercicios del capitulo 1 ");
            Console.WriteLine("Pulse 2 para los ejercicios 1 del capitulo 2  ");
            Console.WriteLine("Pulse 3 para los ejercicios 3 del capitulo 2 ");
            Console.WriteLine("Pulse 4 para los ejercicios 4 del capitulo 2 ");
            Console.WriteLine("Pulse 5 para los ejercicios 5 del capitulo 2 ");
            Console.WriteLine("Pulse 6 para los ejercicios  1 del capitulo 3 ");
            Console.WriteLine("Pulse 7 para los ejercicios 4 del capitulo 3 ");
            Console.WriteLine("Pulse 8 para los ejercicios 5 del capitulo 3 ");
            Console.WriteLine("Pulse 9 para los ejercicios 1 del capitulo 4 ");
            Console.WriteLine("Pulse 10 para los ejercicios  2 del capitulo 4 ");
            Console.WriteLine("Pulse 11 para los ejercicios 5 del capitulo 4 ");


            int caseSwitch = 1;         
            caseSwitch = int.Parse(Console.ReadLine());

            
          
            
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Nombre: Franchy Antigua");
                    Console.WriteLine("Direccion: Tenares");
                    Console.WriteLine("Ocupacion: Estudiante");
                    Console.WriteLine("Correo Electronico: Franchyft95@gmail.com");
                    Console.WriteLine("Telefono: 809-587-8345");
                    Console.WriteLine("Celular: 849-356-1290");
                    Console.ReadLine();
                    break;
                case 2: // cap.2 ejercicio 1 
                    double lados, valor, per;
                    Console.WriteLine("Este programa sirve para calcular el Perímetro de cualquier polígono regular...");
                    Console.WriteLine("\nDigite la cantidad de lados de su Polígono: ");
                    lados = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite el valor de uno de los lados: ");
                    valor = Convert.ToSingle(Console.ReadLine());
                    per = lados * valor;
                    Console.WriteLine("\nEl Perímetro de su Polígono es: " + per);
                    Console.ReadLine();
                    break;
                case 3: //Capitulo2  ejercicio 3
                    int n;
                    double r;
                    Console.WriteLine("Dijete los grados celcius: ");
                    n = int.Parse(Console.ReadLine());
                    r = n - 32 / 18;
                    Console.WriteLine("El resultados es: " + r);
                    Console.ReadLine();
                    Console.WriteLine("Case 2");

                    break;
                case 4://Capitulo2  ejercicio 4
                    double cent, fah;
                    Console.WriteLine("Este programa transforma de Grados Centígrados a Grados Fahrenheit...");
                    Console.WriteLine("\nDigite la cantidad de grados Centígrados que desea convertir:");
                    cent = Convert.ToSingle(Console.ReadLine());
                    fah = ((cent * 9) / 5) + 32;
                    Console.WriteLine("La cantidad de grados centígrados que convirtió es igual a: {0} Fahrenheit", fah);
                    break;
                case 5://Capitulo2  ejercicio 5

                    double dolCamb, eurCamb, dol, eur, resD, resE;
                    Console.WriteLine("Este programa convierte entre Dólares y Euros...");
                    Console.WriteLine("Digite tipo de cambio del día para el Dólar: ");
                    dolCamb = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite tipo de cambio del día para el Euro: ");
                    eurCamb = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("\nDigite la cantidad de Dólares que desea convertir a Euros: ");
                    dol = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite la cantidad de Euros que desea convertir a Dólares: ");
                    eur = Convert.ToSingle(Console.ReadLine());
                    resE = dol * dolCamb;
                    Console.WriteLine("\n\nLa cantidad de Dólares que convirtió es igual a: {0} Euros", resE);
                    resD = eur * eurCamb;
                    Console.WriteLine("La cantidad de Euros que convirtió es igual a: {0} Dólares", resD);
                    Console.WriteLine("\n\nLas tasas de cambio utilizadas fueron: \n{0} Para Dólares\n{1} Para Euros", dolCamb, eurCamb);
                    break;
                case 6://cap 3 ejercicio 1
                    int numero;
                    Console.WriteLine("Este programa dice si un número es par o impar...");
                    Console.WriteLine("\nDigite un número:");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (numero % 2 == 0)
                        Console.WriteLine("El número {0} es Par", numero);
                    else
                        Console.WriteLine("El número {0} es Impar", numero);

                    break;

                case 7://cap 3 ejercicio 4
                    int j;

                    Console.WriteLine("Dijite del 1 al 7 ");
                    j = int.Parse(Console.ReadLine());
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("Domingo");
                            break;
                        case 2:
                            Console.WriteLine("Lunes");
                            break;
                        case 3:
                            Console.WriteLine("Martes");
                            break;
                        case 4:
                            Console.WriteLine("Miercoles");
                            break;
                        case 5:
                            Console.WriteLine("Jueves");
                            break;
                        case 6:
                            Console.WriteLine("Viernes");
                            break;
                        case 7:
                            Console.WriteLine("Sabado");
                            break;
                    }
                    Console.ReadLine();
                    break;

                case 8://cap 3 ejercicio 5
                    int m;
                    int b, h, p;
                    Console.WriteLine("Opciones 1)Area 2)Perimetro");
                    m = int.Parse(Console.ReadLine());
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("Digite la base");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite la altura");
                            h = int.Parse(Console.ReadLine());
                            p = b * h / 2;
                            Console.Write("El resultado: " + p);
                            break;
                        case 2:
                            Console.WriteLine("Dijite la base");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Dijite la altura");
                            h = int.Parse(Console.ReadLine());
                            p = b * h;
                            Console.WriteLine("El resultado es:" + p);
                            break;
                    }
                    break;
                    
                case 9: ///Cap 4 ejercicio  1 
                    int nro, num;
                    Console.WriteLine("Este programa muestra la Tabla de Multiplicar del 1 al 10 de cualquier número...");
                    Console.WriteLine("\nDigite el número del cual desea saber su Tabla de Multiplicar: ");
                    nro = Convert.ToInt32(Console.ReadLine());
                    num = nro;
                    for (int i = 1; i <= 10; i++)
                    {
                        nro *= i;
                        Console.WriteLine("{0} * {1} = {2}", num, i, nro);
                        nro = num;
                    }
                    break;
                case 10: ///Cap 4 ejercicio  2
                    int numer, e, numeros;
                    Console.WriteLine("Este programa calcula el resultado de un número elevado a cualquier potencia...");
                    Console.WriteLine("\nDigite el número que desea elevar o base: ");
                    numer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nDigite el exponente al cual desea elevar su base: ");
                    e = Convert.ToInt32(Console.ReadLine());
                    numeros = numer;
                    Console.Write("El resultado es igual a: ");
                    for (int i = 1; i < e; i++)
                        numer = numer * numeros;
                    Console.Write("{0}", numer);
                    break;
                case 11:///Cap 4 ejercicio  5
                    int cant, c, edad, prom;
                    int mayor = 0;
                    int menor = 987;
                    int sum = 0;
                    Console.WriteLine("Este programa calcula el promedio de edad de un grupo de personas y dice cuál es la de edad más grande y cuál es la más joven....");
                    Console.WriteLine("\nDigite la cantidad de personas a ingresar edad: ");
                    cant = Convert.ToInt32(Console.ReadLine());
                    c = cant;
                    do
                    {
                        Console.WriteLine("Digite la edad de la persona:");
                        edad = Convert.ToInt32(Console.ReadLine());
                        sum += edad;
                        if (edad < menor)
                            menor = edad;
                        if (edad > mayor)
                            mayor = edad;
                        cant--;
                    } while (cant > 0);
                    prom = sum / c;
                    Console.WriteLine("\nEl Promedio de las Edades es igual a: {0} años \nLa Edad Mayor es: {1} años \nLa Edad Menor es: {2} años", prom, mayor, menor);

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.ReadLine();

        }
    }
}
