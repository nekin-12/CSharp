// See https://aka.ms/new-console-template for more information

//Question 1
/*class AskFindBiggerNumber
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Veuillez rentrer un premier nombre:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez rentrer un premier nombre:");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " est le plus grand nombre");
            }
            else
            {
                Console.WriteLine(n2 + " est le plus grand nombre");
            }

        }

        catch
        {
            Console.WriteLine("Vous n'avez pas saisi un nombre entier");
        }

    }

}*/


//Question 2
/*class AskExamResult
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Veuillez rentrer votre resultat d'examen:");
            int result = int.Parse(Console.ReadLine());

            if (result > 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }

        catch
        {
            Console.WriteLine("Vous n'avez pas saisi un nombre entier");
        }

    }

}
*/

//Question 3


//Question 4



using System.ComponentModel.DataAnnotations.Schema;

class Menu
{

    static void Main(string[] args)
    {

        bool stateWhile = true;
        while (stateWhile)
        {
            Console.WriteLine("==== Parite 1 ====");
            Console.WriteLine("Question 1 (p1)");
            Console.WriteLine("Question 2 (p2)");
            Console.WriteLine("Question 3 (p3)");
            Console.WriteLine("Question 4 (p4)");
            Console.WriteLine("Question 5 (p5)");
            Console.WriteLine();
            Console.WriteLine("==== Parite Loops Array ====");
            Console.WriteLine("Question 1 (la1)");
            Console.WriteLine("Question 2 (la2)");
            Console.WriteLine("Question 3 (la3)");
            Console.WriteLine("Question 4 (la4)");
            Console.WriteLine("Question 5 (la5)");
            Console.WriteLine();
            Console.WriteLine("Exit (q)");
            Console.WriteLine();

            string menu = Console.ReadLine();

            switch (menu)
            {

                // PARTIE 1 START 
                case "p1": //Question 1
                    Console.WriteLine();
                try{
                    Console.WriteLine("Veuillez rentrer un premier nombre:");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Veuillez rentrer un premier nombre:");
                    int n2 = int.Parse(Console.ReadLine());

                    if (n1 > n2){
                        Console.WriteLine();
                        Console.WriteLine(n1 + " est le plus grand nombre");
                    }else{
                        Console.WriteLine();
                        Console.WriteLine(n2 + " est le plus grand nombre");
                    }
                }catch{
                        Console.WriteLine("Vous n'avez pas saisi un nombre entier");
                }

                Console.WriteLine();
                break;

                case "p2": //Question 2
                    Console.WriteLine();
                try{
                    Console.WriteLine("Veuillez rentrer votre resultat d'examen:");
                    int result = int.Parse(Console.ReadLine());
                        if (result > 60){
                            Console.WriteLine();
                            Console.WriteLine("Pass");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Fail");
                        }

                    }

                    catch{
                        Console.WriteLine("Vous n'avez pas saisi un nombre entier");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "p3": //Question 3
                    Console.WriteLine();
                    try{
                        Random rand = new Random();
                        int number = rand.Next(0, 100); //returns random number between 0-99

                        bool find = false;
                        while(!find){

                            Console.WriteLine("Veuillez rentrer un nombre entre 1 et 100:");
                            int userNumber = int.Parse(Console.ReadLine());

                            if (userNumber == number) {
                                find = true;
                                Console.WriteLine("Correct!");
                            }else{
                                Console.WriteLine("Incorrect, try again");
                            }
                        }

                    }
                    catch{
                        Console.WriteLine("Vous n'avez pas saisi un nombre entier");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "p4": //Question 4
                    Console.WriteLine();
                    try{
                        Console.WriteLine("Veuillez rentrer un nombre :");
                        int userMultiple = int.Parse(Console.ReadLine());

                        Console.WriteLine("Voici la table de multiplication de {0}", userMultiple, "jusqu'à 12.");

                        for (int i = 1; i <= 12; i++) {
                            Console.WriteLine("{0} x {1} = {2}",userMultiple, i, userMultiple * i);
                        }

                    }
                    catch{
                        Console.WriteLine("Vous n'avez pas saisi un nombre entier");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "p5": //Question 5
                    Console.WriteLine();
                    try {

                        int unResult = 0;

                        bool continuInput = true;

                        do
                        {
                            Console.WriteLine("Veuillez rentrer un premier nombre :");
                            int un1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Veuillez rentrer un deuxieme nombre :");
                            int un2 = int.Parse(Console.ReadLine());
                            unResult = un1 * un2;
                            Console.WriteLine("Resultat de {0} x {1} = {2}", un1, un2, unResult);

                            if (unResult >= 1000)
                            {
                                continuInput = false;
                            }
                            else
                            {
                                Console.WriteLine("Le résultat est inférieur à 1000, veuillez continuer");
                            }

                        } while (continuInput);

                    }
                    catch
                    {
                        Console.WriteLine("Vous n'avez pas saisi un nombre entier");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                // PARTIE 1 END 


                // PARTIE Loops Array START

                case "la1": //Question LA 1
                    Console.WriteLine();
                    try
                    {
                        int[] table = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        for (int i = 0; i < table.Length; i++)
                        {
                            Console.WriteLine(table[i]);
                        }
                        
                    }
                    catch
                    {
                        Console.WriteLine("Vous n'avez pas saisi un nombre entier");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "la2": //Question LA 2
                    Console.WriteLine();
                    try
                    {

                        int[] table = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        foreach (int element in table)
                        {
                            Console.Write($"{element} ");
                        }
                    }
                    catch
                    {
                        
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "la3": //Question LA 2
                    Console.WriteLine();
                    try
                    {


                    }
                    catch
                    {
                        Console.WriteLine("Vous n'avez pas saisi un nombre entier");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                // PARTIE Loops Array END


                case "q":
                default:
                    stateWhile = false;
                    break;
                    
            }
        }

    }
}
