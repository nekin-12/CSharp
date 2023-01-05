// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

// -- Partie Enum Constantes --
// -- Q1 --
enum JourSemaine
{
    Lundi = 0,
    Mardi = 1,
    Mercredi = 2,
    Jeudi = 3,
    Vendredi = 4,
    Samedi = 5,
    Dimanche = 6
}

enum Saison
{
    printemps = 0,
    été = 1,
    automne = 2,
    hiver = 3,

}

class Menu
{
    static void Main(string[] args)
    {

        bool stateWhile = true;
        while (stateWhile)
        {
            Console.WriteLine("====/ Parite 1 /====");
            Console.WriteLine("Question 1 (p1)");
            Console.WriteLine("Question 2 (p2)");
            Console.WriteLine("Question 3 (p3)");
            Console.WriteLine("Question 4 (p4)");
            Console.WriteLine("Question 5 (p5)");
            Console.WriteLine();
            Console.WriteLine("====/ Partie Loops Array /====");
            Console.WriteLine("Question 1 (la1)");
            Console.WriteLine("Question 2 (la2)");
            Console.WriteLine("Question 3 (la3)");
            Console.WriteLine("Question 4 (la4)");
            Console.WriteLine("Question 5 (la5)");
            Console.WriteLine();
            Console.WriteLine("====/ Partie Enum Constantes /====");
            Console.WriteLine("Question 1 (ec1)");
            Console.WriteLine("Question 2 (ec2)");
            Console.WriteLine("Question 3 (ec3)");
            Console.WriteLine("Question 4 (ec4)");
            Console.WriteLine("Question 5 (ec5)");
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
                        Console.WriteLine("Veuillez rentrer un premier nombre :");
                        int num = int.Parse(Console.ReadLine());

                        int[] table = new int[] { num, num, num, num, num, num, num, num, num, num };

                        while (num < 10)
                        {
                            num = int.Parse(Console.ReadLine());

                        }
                        
                            Console.WriteLine(table);


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

                case "la3": //Question LA 3
                    Console.WriteLine();
                    try
                    {
                        string[] table = new string[5];

                        table[0] = "red";
                        table[1] = "purple";
                        table[2] = "yellow";
                        table[3] = "grey";
                        table[4] = "green";

                        List<string> list = new List<string>(table);

                        int i = 0;

                        while (i < 5)
                        {
                            Console.WriteLine("{0}", list[i]);
                            i++;
                        }

                    }
                    catch
                    {
                        
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "la4": //Question LA 4
                    Console.WriteLine();
                    try
                    {

                        double[] table = new double[] { 1.5, 2.5, 3.5, 4.5, 5.5 };
                        double somme = 0;
                        int i = 0;

                        do {
                            somme += table[i];
                            i++;
                        }while (i < table.Length);
                        Console.WriteLine("La somme est " + somme);

                    }
                    catch
                    {

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "la5": //Question LA 5
                    Console.WriteLine();
                    try
                    {
                        int[] table = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

                        for(int i = 0; i < table[i]; i++)
                        {

                            if (table[i] % 3 == 0  && table[i] % 5 == 0)
                            {
                                Console.WriteLine("{0}", table[i]); 
                            }
                           
                        }
                    }
                    catch
                    {

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                // PARTIE Loops Array END

                // PARTIE Enum Constantes START

                case "ec1": //Question EC 1
                    Console.WriteLine();
                    try
                    {
                        Console.WriteLine("Entrez un nombre entre 0 et 6 pour afficher le jour de la semaine correspondant:");
                        Console.WriteLine("lundi (0)");
                        Console.WriteLine("mardi (1)");
                        Console.WriteLine("mercredi (2)");
                        Console.WriteLine("jeudi (3)");
                        Console.WriteLine("vendredi (4)");
                        Console.WriteLine("samedi (5)");
                        Console.WriteLine("dimanche (6)");

                        int jourNumero = int.Parse(Console.ReadLine());

                        JourSemaine jour = (JourSemaine)jourNumero;
                        Console.WriteLine("Le jour de la semaine correspondant est: " + jour);

                    }
                    catch
                    {
                        Console.WriteLine("Vous n'avez pas saisi un nombre entier");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "ec2": //Question EC 2
                    Console.WriteLine();
                    try
                    {
                        const int jourAnneeMax = 365;
                        
                        Console.WriteLine("entrez votre date de naissance: ");
                        int dateNaissance = int.Parse(Console.ReadLine());
                        int jourVecu =  jourAnneeMax * dateNaissance;
                        Console.WriteLine("Voici le nombre de jour que vous avez vécu: " + jourVecu);


                    }
                    catch
                    {

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "ec3": //Question EC 3
                    Console.WriteLine();
                    try
                    {
                        const int secMax = 60;
                        Console.WriteLine("Entrez un temps en minute et seconde : ");
                        Console.WriteLine("Minute : ");
                        int min = int.Parse(Console.ReadLine());
                        Console.WriteLine("Seconde : ");
                        int sec = int.Parse(Console.ReadLine());

                        int total = min * secMax + sec;
                        Console.WriteLine("Votre temps en seconde : " + total);
                    }
                    catch
                    {

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "ec4": //Question EC 4
                    Console.WriteLine();
                    try
                    {
                        Console.WriteLine("Entrez une température en C°: ");
                        double temperature = double.Parse(Console.ReadLine());

                        string temperatureRange;
                        switch (temperature)
                        {
                            case var t when t > 30:
                                temperatureRange = " chaude " + Saison.été;
                                
                                break;
                            case var t when t > 20:
                                temperatureRange = " tiède " + Saison.automne;
                                break;
                            case var t when t > 10:
                                temperatureRange = " fraîche " + Saison.printemps;
                                break;
                            default:
                                temperatureRange = " froide " + Saison.hiver;
                                break;
                        }

                        Console.WriteLine("La température est de " + temperature + ", elle est" + temperatureRange + ".");

                    }
                    catch
                    {

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case "ec5": //Question EC 5
                    Console.WriteLine();
                    try
                    {
                     
                        const int pouceParPied = 12;

                        Console.WriteLine("Entrez votre taille en pieds et pouces:");
                        Console.WriteLine("Pieds: ");
                        int pieds = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pouces: ");
                        int pouces = int.Parse(Console.ReadLine());

                        int totalPouces = pieds * pouceParPied + pouces;
                        Console.WriteLine("Votre taille est de " + totalPouces + " pouces.");
                    }
                    catch
                    {

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                // PARTIE Enum Constantes END


                case "q":
                    default:
                        stateWhile = false;
                    break;
                    
            }
        }

    }
}
