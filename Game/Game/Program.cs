
class Game
{

    
    static int WallCollum = 40;
    static int WallRow = 10;
    const int WallSizeX = 10;
    const int WallSizeY = 1;

    static int left = 0;
    static int right = 1;
    static int up = 2;
    static int down = 3;

    static int PlayerOneScore = 0;
    static int PlayerOneDirection = right;
    static int PlayerOneColumn = 0; // column
    static int PlayerOneRow = 0; // row

    static int PlayerTwoScore = 0;
    static int PlayerTwoDirection = left;
    static int PlayerTwoColumn = 0; // column
    static int PlayerTwoRow = 5; // row

    static bool[,] isUsed;

    static void Main(string[] args)
    {
        SetGameField();
        StartScreen();
        /*Map();*/
        //WINDOWS SIZE
        isUsed = new bool[Console.WindowWidth, Console.WindowHeight];

        //LOOP IN GAME
        while (true)
        {

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                ChangePlayerDirection(key);

            }

            MovePlayers();

            bool PlayerOneLooses = PlayerLoose(PlayerOneRow, PlayerOneColumn);
            bool PlayerTwoLooses = PlayerLoose(PlayerTwoRow, PlayerTwoColumn);

            //PLayer ONE Loose
            if (PlayerOneLooses)
            {
                PlayerTwoScore++;
                Console.ForegroundColor = ConsoleColor.Red;
                string txtGameOver = @"
                                        ╔══╗
                                        ║╔═╬═╗╔══╦═╗╔═╦═╦═╦═╦╦╗
                                        ║╚╗║╬╚╣║║║╩╣║╬╠╗║╔╣╩╣╔╝
                                        ╚══╩══╩╩╩╩═╝╚═╝╚═╝╚═╩╝▒▒
                                      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒";
                Console.CursorLeft = Console.BufferWidth / 4 - txtGameOver.Length / 15;
                Console.WriteLine(txtGameOver);

                Console.ForegroundColor = ConsoleColor.Green;
                string txtWinner = "====/ Le joueur deux gagne!!! /====";
                Console.CursorLeft = Console.BufferWidth / 2 - txtWinner.Length / 2;
                Console.WriteLine(txtWinner);

                Console.ForegroundColor = ConsoleColor.Yellow;
                string txtScore = "====/ Score: " + PlayerOneScore + " - " + PlayerTwoScore + " /====";
                Console.CursorLeft = Console.BufferWidth / 2 - txtScore.Length / 2;
                Console.WriteLine(txtScore);
                
                Console.WriteLine();

                ResetGame();
            }

            //PLAYER TWO LOOSE
            if (PlayerTwoLooses)
            {
                PlayerOneScore++;
                Console.ForegroundColor = ConsoleColor.Red;
                string txtGameOver = @"
                                        ╔══╗
                                        ║╔═╬═╗╔══╦═╗╔═╦═╦═╦═╦╦╗
                                        ║╚╗║╬╚╣║║║╩╣║╬╠╗║╔╣╩╣╔╝
                                        ╚══╩══╩╩╩╩═╝╚═╝╚═╝╚═╩╝▒▒
                                      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒";
                Console.CursorLeft = Console.BufferWidth / 4 - txtGameOver.Length / 15;
                Console.WriteLine(txtGameOver);

                Console.ForegroundColor = ConsoleColor.Green;
                string txtWinner = "====/ Le joueur un gagne !!! /====";
                Console.CursorLeft = Console.BufferWidth / 2 - txtWinner.Length / 2;
                Console.WriteLine(txtWinner);

                Console.ForegroundColor = ConsoleColor.Yellow;
                string txtScore = "====/ Score: " + PlayerOneScore + " - " + PlayerTwoScore + " /====";
                Console.CursorLeft = Console.BufferWidth / 2 - txtScore.Length / 2;
                Console.WriteLine(txtScore);

                Console.WriteLine();

                ResetGame();
            }

            //BOTH PLAYERS LOOSES
            if (PlayerTwoLooses && PlayerOneLooses)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                string txtGameOver = @"
                                        ╔══╗
                                        ║╔═╬═╗╔══╦═╗╔═╦═╦═╦═╦╦╗
                                        ║╚╗║╬╚╣║║║╩╣║╬╠╗║╔╣╩╣╔╝
                                        ╚══╩══╩╩╩╩═╝╚═╝╚═╝╚═╩╝▒▒
                                      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒";
                Console.CursorLeft = Console.BufferWidth / 4 - txtGameOver.Length / 15;
                Console.WriteLine(txtGameOver);

                Console.ForegroundColor = ConsoleColor.Green;
                string txtWinner = "====/ Aucun joueur ne gagnent!!! /====";
                Console.CursorLeft = Console.BufferWidth / 2 - txtWinner.Length / 2;
                Console.WriteLine(txtWinner);

                Console.ForegroundColor = ConsoleColor.Yellow;
                string txtScore = "====/ Score: " + PlayerOneScore + " - " + PlayerTwoScore + " /====";
                Console.CursorLeft = Console.BufferWidth / 2 - txtScore.Length / 2;
                Console.WriteLine(txtScore);

                Console.WriteLine();

                ResetGame();
            }

            isUsed[PlayerOneColumn, PlayerOneRow] = true;
            isUsed[PlayerTwoColumn, PlayerTwoRow] = true;

            WriteOnPosition(PlayerOneColumn, PlayerOneRow, '*', ConsoleColor.Blue);
            WriteOnPosition(PlayerTwoColumn, PlayerTwoRow, '*', ConsoleColor.Red);

            
            Thread.Sleep(100);

        }
    }

    //MAP (Obstacle)
    static void Map()
    {

        //Size
        for (int x = 0; x <= WallSizeX; x++)
            {
             
            for (int y = 0; y <= WallSizeY; y++)
            {
                string txtWall = "▒▒";
                Console.Write(txtWall, ConsoleColor.White);
                //Position
                Console.SetCursorPosition(WallCollum, WallRow);
                Console.CursorLeft = Console.BufferWidth / 4 - txtWall.Length / 2;
            }
            
            Console.Write('\n');
           
        }

    }


    //HOME SCREEN
    static void StartScreen()
    {
        for(int i = 0; i < 100; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("▒");
            Thread.Sleep(10);
        }
        for (int t = 0; t < 1; t++)
        {
            Console.SetCursorPosition(0, t);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
                            ▒▒▒▒▒████████░▒▒█████░▒▒▒▒████░▒▒▒██░▒▒██░▒▒▒▒▒▒▒
                            ▒▒▒▒▒▒▒▒██░░░▒▒▒██░▒██░▒▒██░▒██░▒▒████░██░▒▒▒▒▒▒▒
                            ▒▒▒▒▒▒▒▒██░▒▒▒▒▒████░░▒▒▒██░▒██░▒▒██░████░▒▒▒▒▒▒▒
                            ▒▒▒▒▒▒▒▒██░▒▒▒▒▒██░░██░▒▒▒████░▒▒▒██░▒▒██░▒▒▒▒▒▒▒
                            ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            
            Thread.Sleep(500);
        }

        MainMenu();
        Console.Clear();

    }

    static void MainMenu()
    {
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        string txtMainMenu = "====/ Menu principal /====";
        Console.CursorLeft = Console.BufferWidth / 2 - txtMainMenu.Length / 2;
        Console.WriteLine(txtMainMenu);

        Console.WriteLine();
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        string txtStartGame = "1. Jouer";
        Console.CursorLeft = Console.BufferWidth / 2 - txtStartGame.Length / 2;
        Console.WriteLine(txtStartGame);

        Console.ForegroundColor = ConsoleColor.Yellow;
        string txtControl = "2. Control";
        Console.CursorLeft = Console.BufferWidth / 2 - txtControl.Length / 2;
        Console.WriteLine(txtControl);

        string txtQuit = "3. Quitter";
        Console.CursorLeft = Console.BufferWidth / 2 - txtQuit.Length / 2;
        Console.WriteLine(txtQuit);

        string mainMenu = Console.ReadLine();
        switch (mainMenu)
        {
            case "1":
                StartGame();
                break;
            
                //CONTROL
            case "2":
                Console.Clear();

                for (int i = 0; i < 100; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("▒");
                    Thread.Sleep(10);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                string playerControlTitle = "Controle du joueur:";
                Console.CursorLeft = Console.BufferWidth / 2 - playerControlTitle.Length / 2;
                Console.WriteLine(playerControlTitle);
                
                Console.WriteLine();

                string playerControlUp = "Z - Haut";
                Console.CursorLeft = Console.BufferWidth / 2 - playerControlUp.Length / 2;
                Console.WriteLine(playerControlUp);

                string playerControlLeft = "Q - Gauche";
                Console.CursorLeft = Console.BufferWidth / 2 - playerControlLeft.Length / 2;
                Console.WriteLine(playerControlLeft);

                string playerControlDown = "S - Bas";
                Console.CursorLeft = Console.BufferWidth / 2 - playerControlDown.Length / 2;
                Console.WriteLine(playerControlDown);

                string playerControlRight = "D - Droite";
                Console.CursorLeft = Console.BufferWidth / 2 - playerControlRight.Length / 2;
                Console.WriteLine(playerControlRight);

                Console.WriteLine();

                string backToMain = "1. Retourner au menu principal";
                Console.CursorLeft = Console.BufferWidth / 2 - backToMain.Length / 2;
                Console.WriteLine(backToMain);

                string controlMenu = Console.ReadLine();
                switch (controlMenu)
                    {
                    case ("1"):
                        Console.Clear();
                        StartScreen();
                        break;
                    }
                break;

            case "3":
                Console.Clear();
                Environment.Exit(1);// exit
                break;
        }
    }

    static void StartGame()
    {
        isUsed = new bool[Console.WindowWidth, Console.WindowHeight];
        SetGameField();
        PlayerOneDirection = right;
       
        //Console.Clear();
        MovePlayers();
    }

    //RESET GAME
    static void ResetGame()
    {
        isUsed = new bool[Console.WindowWidth, Console.WindowHeight];
        SetGameField();
        PlayerOneDirection = right;

        string backToMain = "1. Recommencer la partie";
        Console.CursorLeft = Console.BufferWidth / 2 - backToMain.Length / 2;
        Console.WriteLine(backToMain);
        string quitGame = "2. Retourner au menu principal";
        Console.CursorLeft = Console.BufferWidth / 2 - quitGame.Length / 2;
        Console.WriteLine(quitGame);

        string resetMenu = Console.ReadLine();
        switch (resetMenu)
        {
            case "1":
                StartGame();
                break;
            case "2":
                Console.Clear();
                StartScreen();
                break;
        }
        Console.Clear();
        MovePlayers();
    }


    //LOOSE GAME
    static bool PlayerLoose(int row, int col)
    {
        if (row < 0)
        {
            return true;
        }
        if (col < 0)
        {
            return true;
        }
        if (row >= Console.WindowHeight)
        {
            return true;
        }
        if (col >= Console.WindowWidth)
        {
            return true;
        }


        if (isUsed[col, row])
        {
            return true;
        }


        return false;
    }


    //PARAMETER
    static void SetGameField()
    {
        Console.WindowHeight = 30;
        Console.BufferHeight = 30;

        Console.WindowWidth = 100;
        Console.BufferWidth = 100;


        PlayerOneColumn = 0;
        PlayerOneRow = Console.WindowHeight / 2;

        PlayerTwoColumn = Console.WindowWidth - 1;
        PlayerTwoRow = Console.WindowHeight / 2;

    }

    //SET CONTROL PLAYER
    static void MovePlayers()
    {
        //PLAYER ONE
        if (PlayerOneDirection == right)
        {
            PlayerOneColumn++;
        }
        if (PlayerOneDirection == left)
        {
            PlayerOneColumn--;
        }
        if (PlayerOneDirection == up)
        {
            PlayerOneRow--;
        }
        if (PlayerOneDirection == down)
        {
            PlayerOneRow++;
        }

        //PLAYER TWO
        if (PlayerTwoDirection == right)
        {
            PlayerTwoColumn++;
        }
        if (PlayerTwoDirection == left)
        {
            PlayerTwoColumn--;
        }
        if (PlayerTwoDirection == up)
        {
            PlayerTwoRow--;
        }
        if (PlayerTwoDirection == down)
        {
            PlayerTwoRow++;
        }

    }

    //WRITE POSITION
    static void WriteOnPosition(int x, int y, char ch, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(x, y);
        Console.Write(ch);
    }

    //SET KEY CONTROL PLAYER
    static void ChangePlayerDirection(ConsoleKeyInfo key)
    {
        //PLAYER ONE
        if (key.Key == ConsoleKey.Z && PlayerOneDirection != down)
        {
            PlayerOneDirection = up;
        }
        if (key.Key == ConsoleKey.Q && PlayerOneDirection != right)
        {
            PlayerOneDirection = left;
        }
        if (key.Key == ConsoleKey.D && PlayerOneDirection != left)
        {
            PlayerOneDirection = right;
        }
        if (key.Key == ConsoleKey.S && PlayerOneDirection != up)
        {
            PlayerOneDirection = down;
        }

        //PLAYER TWO
        if (key.Key == ConsoleKey.UpArrow && PlayerTwoDirection != down)
        {
            PlayerTwoDirection = up;
        }
        if (key.Key == ConsoleKey.LeftArrow && PlayerTwoDirection != right)
        {
            PlayerTwoDirection = left;
        }
        if (key.Key == ConsoleKey.RightArrow && PlayerTwoDirection != left)
        {
            PlayerTwoDirection = right;
        }
        if (key.Key == ConsoleKey.DownArrow && PlayerTwoDirection != up)
        {
            PlayerTwoDirection = down;
        }

    }
}

