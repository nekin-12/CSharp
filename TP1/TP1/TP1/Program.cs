// See https://aka.ms/new-console-template for more information

int[,] Tableau1 = new int[1, 2];
int[,,] Tableau2 = new int[5, 2, 3];

// Sur l'instructionn "Tableau1" on défini le tableau avec une possibilité de 2 valeurs, alors que sur l'instruction "Tableau2" on défini le tableau avec une possibilité de 3 valeurs

int[][] Tableau4 = new int[3][];
Tableau4[0] = new int[] { 45, 2 };
Tableau4[1] = new int[] { 34, 34, 4, 67 };
Tableau4[2] = new int[] { 11, 22, 33 };

for (int i = 0; i < Tableau4.Length; i++)
{
    Console.WriteLine("Tableau4[{0}] : {1}", i, string.Join(", ", Tableau4[i]));
}

//