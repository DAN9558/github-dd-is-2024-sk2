using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("******* Součet a součin celých čísel *******");
            Console.WriteLine("**************************");
            Console.WriteLine("****** Daniel Dubský *******");
            Console.WriteLine("**************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - špatná varianta
            //Console.Write("Zadejte první číslo řady: ");a
            //int first = int.Parse(Console.ReadLine());



            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}


// Výpis vstupní hodnoty
Console.Writeline("====================");
Console.WriteLine("Uživatel zadal: {0}", number);
Console.Writeline("====================\n\n");


int suma = 0;
int numberBackup = number;
int digit;

while(number >=10) {
 digit = number % 10; // % opertor mode
 number = (number - digit) / 10;  Console.WriteLine("Digit = {0}", digit);
 suma = suma + digit;
}
Console.Writeline("Digit = {0}", number);
suma = suma + number;

Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);

//Opakování programu
Console.WriteLine("Pro opakování programu stiskněte klávesu a");
again = Console.Readline();



