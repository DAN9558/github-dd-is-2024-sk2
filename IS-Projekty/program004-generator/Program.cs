string again = "a";
while(again == "a") {

            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("**** Generátor pseudonálních čísel ****");
            Console.WriteLine("******* Daniel Dubský ********");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
            } 

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
            } 
          

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
            }

            Console.WriteLine("\n\n==============");
            Console.WriteLine("Uživatelký vstup:  ");
            Console.WriteLine("Počet čísel {0}: dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==============\n\n");

            //deklarace pole
            int[]myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla:  ");

            for(int i=0; i<n; i++) {
               myArray[i] = randomNumber.Next(dm, hm+1);
               Console.WriteLine("{0}; ", myArray[i]);  
            }





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine(); 

}