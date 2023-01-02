// See https://aka.ms/new-console-template for more information

//Question 1


class AskFindBiggerNumber
{
    static void Main(string[] args){
        try{
            Console.WriteLine("Veuillez rentrer un premier nombre:");
                int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez rentrer un premier nombre:");
                int n2 = int.Parse(Console.ReadLine());
            
            if (n1 > n2){
                Console.WriteLine(n1 + " est le plus grand nombre");
            }
            else{
                Console.WriteLine(n2 + " est le plus grand nombre");
            }

            }

        catch{
            Console.WriteLine("Vous n'avez pas saisi un nombre entier");
        }
        
    }

}


//Question 2

//Question 3

//Question 4


