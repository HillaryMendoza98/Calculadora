

using System;

class Calculadora
{
    static void Main()
    {
        
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

      
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

       
        Console.WriteLine("Seleccione una operación: (+, -, *, /)");
        char operacion = Console.ReadLine()[0]; // Lee la primera letra ingresada por el usuario

        // Variable para almacenar el resultado de la operación
        double resultado = 0;

        // Evalúa la operación seleccionada por el usuario
        switch (operacion)
        {
            case '+':
                resultado = num1 + num2; // Suma
                break;
            case '-':
                resultado = num1 - num2; // Resta
                break;
            case '*':
                resultado = num1 * num2; // Multiplicación
                break;
            case '/':
                // Verifica que el segundo número no sea 0 antes de realizar la división
                if (num2 != 0)
                    resultado = num1 / num2; // División
                else
                    Console.WriteLine("No se puede dividir entre 0."); // Muestra un mensaje de error
                break;
            default:
                Console.WriteLine("Operación no válida."); // Mensaje para operaciones no reconocidas
                break;
        }

        // Si no se intentó dividir entre 0, muestra el resultado
        if (num2 != 0 || operacion != '/')
            Console.WriteLine($"El resultado de la operación es: {resultado}");
    }
}
