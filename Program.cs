using System;
using System.Threading;

//Zadanie 1. Proszę napisać funkcję int min() która odnajduje wartość najmniejszą w tablicy int tab[]
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("Zadanie 1. Proszę napisać funkcję int min() która odnajduje wartość najmniejszą w tablicy int tab[]\n");

int[] tablica = { 55, 78, -79, 50, -36, 2, 8, -3, 7, 99, 100, -9999 };

int Min(int[] tab)
{
    int najmniejsza = tab[0];
    foreach (int liczba in tab)
    {
        if (liczba < najmniejsza)
        {
            najmniejsza = liczba;
        }
    }
    return najmniejsza;
}

int najmniejsza = Min(tablica);
Console.WriteLine("Najmniejsza wartość: " + najmniejsza);


//Zadanie 2. Proszę napisać funkcję int max() która odnajduje wartość największą w tablicy int tab[];
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("Zadanie 2. Proszę napisać funkcję int max() która odnajduje wartość największą w tablicy int tab[]\n");

int Max(int[] tab)
{
    int najwieksza = tab[0];
    foreach (int liczba in tab)
    {
        if (liczba > najwieksza)
        {
            najwieksza = liczba;
        }
    }
    return najwieksza;
}

int najwieksza = Max(tablica);
Console.WriteLine("Największa wartość: " + najwieksza);



//Zadanie 3. Proszę napisać funkcję minmax() która jednocześnie odnajduje wartość najmniejszą i największą w tablicy int tab[];
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("Zadanie 3. Proszę napisać funkcję minmax() która jednocześnie odnajduje wartość najmniejszą i największą w tablicy int tab[]\n");

(int min, int max) MinMax(int[] tab)
{
    int najmniejsza = tab[0];
    int najwieksza = tab[0];
    foreach (int liczba in tab)
    {
        if (liczba < najmniejsza)
        {
            najmniejsza = liczba;
        }

        if (liczba > najwieksza)
        {
            najwieksza = liczba;
        }
    }
    return (najmniejsza, najwieksza);
}

var (minValue, maxValue) = MinMax(tablica);
Console.WriteLine($"Najmniejsza wartość: {minValue}, Największa wartość: {maxValue}");



//Zadanie 4. 
//Proszę napisać funkcję swap która pozwoli na zamienienie ze sobą dwóch sąsiadujących elementów w tablicy np:
//1 2 3 4 5 6
//2 1 4 3 6 5
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("Zadanie 4. Proszę napisać funkcję swap która pozwoli na zamienienie ze sobą dwóch sąsiadujących elementów w tablicy np:\n" +
    "1 2 3 4 5 6" + "\n" +
    "2 1 4 3 6 5" + "\n");


int[] tablicaSwap = { 1, 2, 3, 4, 5, 6 };

static void Swap(int[] tab)
{
    int[] tablicaSwap = tab;

    Console.WriteLine("Przed zamianą:");
    foreach (var item in tab)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();

    for (int i = 0; i < 5; i += 2)
    {
        int temp = tablicaSwap[i];
        tablicaSwap[i] = tablicaSwap[i + 1];
        tablicaSwap[i + 1] = temp;
    }

    Console.WriteLine("Po zamianie:");
    foreach (var item in tab)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

Swap(tablicaSwap);


// Zadanie 5. Proszę napisać funkcję, która dokona transpozycji tablicy to znaczy zamieni wiersze z kolumnami:
//a b c
//d e f 
//g h i

//a d g
//b e h
//g h i
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("Zadanie 5. Proszę napisać funkcję, która dokona transpozycji tablicy to znaczy zamieni wiersze z kolumnami:\n" +
    "a b c" + "\n" +
    "d e f " + "\n" +
    "g h i" + "\n" +
    "\n" +
    "a d g" + "\n" +
    "b e h" + "\n" +
    "g h i");

int[,] macierz = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

static int[,] Transpozycja(int[,] macierz)
{
    int wiersze = 3;
    int kolumny = 3;
    int[,] wynik = new int[kolumny, wiersze];

    for (int i = 0; i < wiersze; i++)
    {
        for (int j = 0; j < kolumny; j++)
        {
            wynik[j, i] = macierz[i, j];
        }
    }
    return wynik;
}

static void WyswietlMacierz(int[,] macierz)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(macierz[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("\n");

WyswietlMacierz(macierz);
int[,] transponowana = Transpozycja(macierz);
WyswietlMacierz(transponowana);
Console.WriteLine("\n");

// Zadanie 6. Proszę napisać funkcję find_letter która poda lokalizację wszystkich wystąpień określonego znaku w tablicy przy użyciu wyszukiwania liniowego.
Console.WriteLine("Zadanie 6.Proszę napisać funkcję find_letter która poda lokalizację wszystkich wystąpień określonego znaku w tablicy przy użyciu wyszukiwania liniowego.\n");
char[] tablicaFindLetter = { 'a', 'a', 'a', 'd', 'a', 'a', 'f', 'a' };
char szukanaLitera = 'a';
static int[] FindLetter(char[] tablicaFindLetter, char szukanaLitera)
{
    int[] pozycje = new int[9];
    int liczbaWystapien = 1;

    for (int i = 0; i < 8; i++)
    {
        if (tablicaFindLetter[i] == szukanaLitera)
        {
            pozycje[liczbaWystapien] = i;
            liczbaWystapien++;
        }
    }
    pozycje[0] = liczbaWystapien - 1;
    return pozycje;
}

Console.WriteLine($"Szukana litera: {szukanaLitera}");
int[] pozycje = FindLetter(tablicaFindLetter, szukanaLitera);
Console.WriteLine("Pozycje występowania litery:");
for (int i = 0; i < pozycje[0]; i++)
{
    Console.Write(pozycje[i + 1] + " ");
}



// Zadanie 7. Proszę napisać algorytm wyszukujący binarnie liczbę w tablicy uporządkowanej malejąco lub rosnąco, funkcja powinna sama określić jak jest uporządkowana tablica
Console.WriteLine("\n");
Console.WriteLine("Zadanie 7. Proszę napisać algorytm wyszukujący binarnie liczbę w tablicy uporządkowanej malejąco lub rosnąco, funkcja powinna sama określić jak jest uporządkowana tablica\n\n");

int[] tablicaRosnaco = { 1, 3, 5, 7, 9, 11, 13, 15 };
int[] tablicaMalejaco = { 15, 13, 11, 9, 7, 5, 3, 1 };
int szukanaLiczba = 7;

static int WyszukiwanieBinarneLiczby(int[] tablica, int szukanaLiczba)
{
    bool rosnaco = TablicaRosnacaCzyMalejaca(tablica);
    int lewy = 0;
    int prawy = 6;

    while (lewy <= prawy)
    {
        int srodek = (lewy + prawy) / 2;

        if (tablica[srodek] == szukanaLiczba)
            return srodek;

        if (rosnaco)
        {
            if (tablica[srodek] < szukanaLiczba)
                lewy = srodek + 1;
            else
                prawy = srodek - 1;
        }
        else
        {
            if (tablica[srodek] > szukanaLiczba)
                lewy = srodek + 1;
            else
                prawy = srodek - 1;
        }
    }
    return -1;
}

static bool TablicaRosnacaCzyMalejaca(int[] tablica)
{
    for (int i = 0; i < 6; i++)
    {
        if (tablica[i] > tablica[i + 1])
            return false;
    }
    return true;
}


int wynikRosnaco = WyszukiwanieBinarneLiczby(tablicaRosnaco, szukanaLiczba);
Console.WriteLine("Wynik dla tablicy rosnącej: " + wynikRosnaco);

int wynikMalejaco = WyszukiwanieBinarneLiczby(tablicaMalejaco, szukanaLiczba);
Console.WriteLine("Wynik dla tablicy malejącej: " + wynikMalejaco);


// Zadanie 8. Proszę napisać funkcję, który sprawdzi czy tablica spełnia warunki bycia SUDOKU
Console.WriteLine("\n");
Console.WriteLine("Zadanie 8. Proszę napisać funkcję, który sprawdzi czy tablica spełnia warunki bycia SUDOKU\n\n");

int[,] sudokuPoprawne = {
            {1, 2, 3},
            {2, 3, 1},
            {3, 1, 2}
        };

int[,] sudokuNiepoprawne = {
            {1, 2, 3},
            {2, 3, 1},
            {3, 1, 4}
        };

static bool CzyPoprawneSudoku(int[,] plansza)
{
    for (int w = 0; w < 3; w++)
    {
        if (!SprawdzZbiorLiczb(plansza, w, true))
            return false;
    }

    for (int k = 0; k < 3; k++)
    {
        if (!SprawdzZbiorLiczb(plansza, k, false))
            return false;
    }

    return true;
}

static bool SprawdzZbiorLiczb(int[,] plansza, int indeks, bool jestWierszem)
{
    int[] wystapienia = new int[3];

    for (int i = 0; i < 3; i++)
    {
        int liczba = jestWierszem ? plansza[indeks, i] : plansza[i, indeks];

        if (liczba < 1 || liczba > 3)
            return false;

        if (liczba == 1) wystapienia[0]++;
        if (liczba == 2) wystapienia[1]++;
        if (liczba == 3) wystapienia[2]++;

        if (wystapienia[liczba - 1] > 1)
            return false;
    }
    return true;
}


Console.WriteLine("Poprawne Sudoku 3x3 = TRUE: " + CzyPoprawneSudoku(sudokuPoprawne));
Console.WriteLine("Niepoprawne Sudoku 3x3 = FALSE : " + CzyPoprawneSudoku(sudokuNiepoprawne));


// Zadanie 9. Proszę napisać program, który wyszuka tekst w łańcuchu znaków używając algorytmu naiwnego (bez .Length)
Console.WriteLine("\n");
Console.WriteLine("Zadanie 9. Proszę napisać program, który wyszuka tekst w łańcuchu znaków używając algorytmu naiwnego. \n\n");

string tekst = "ala ma kota a kot ma ale";
string wzorzec = "kot";

int[] wyniki = SzukajWzorca(tekst, wzorzec);

Console.WriteLine($"Liczba wystąpień: {wyniki[0]}");
for (int i = 1; i <= wyniki[0]; i++)
{
    Console.WriteLine($"Znaleziono wzorzec na pozycji: {wyniki[i]}");
}

static int[] SzukajWzorca(string tekst, string wzorzec)
{
    int[] pozycje = new int[100];
    int liczbaWystapien = 0;

    int dlTekstu = ObliczDlugosc(tekst);
    int dlWzorca = ObliczDlugosc(wzorzec);

    for (int i = 0; i <= dlTekstu - dlWzorca; i++)
    {
        bool znaleziono = true;
        for (int j = 0; j < dlWzorca; j++)
        {
            if (tekst[i + j] != wzorzec[j])
            {
                znaleziono = false;
                break;
            }
        }
        if (znaleziono)
        {
            pozycje[liczbaWystapien + 1] = i;
            liczbaWystapien++;
        }
    }
    pozycje[0] = liczbaWystapien;
    return pozycje;
}

static int ObliczDlugosc(string tekst)
{
    int dlugosc = 0;
    foreach (char c in tekst)
    {
        dlugosc++;
    }
    return dlugosc;
}

// Zadanie 10. Proszę napisać program realizujący grę w życie Conway'a.

Console.WriteLine("\n Zadanie 10. Proszę napisać program realizujący grę w życie Conway'a.");

Console.WriteLine("Conway's Game of Life");
Console.Write("Podaj szerokość planszy: ");
int width = int.Parse(Console.ReadLine());
Console.Write("Podaj wysokość planszy: ");
int height = int.Parse(Console.ReadLine());

ConwayLifeGame game = new ConwayLifeGame(width, height);
game.InitializeGrid();
game.Run();

class ConwayLifeGame
{
    private int width;
    private int height;
    private bool[,] grid;
    private bool[,] nextGrid;
    private bool[,] previousGrid;
    private Random random;
    private int generationCount;
    private bool gameFinished;


    public ConwayLifeGame(int width, int height)
    {
        this.width = width;
        this.height = height;
        grid = new bool[height, width];
        nextGrid = new bool[height, width];
        previousGrid = new bool[height, width];
        random = new Random();
    }

    public void InitializeGrid()
    {
        Console.WriteLine("Wybierz metodę inicjalizacji planszy:");
        Console.WriteLine("1. Ręczne wprowadzanie komórek");
        Console.WriteLine("2. Losowe wypełnienie");
        Console.Write("Twój wybór (1/2): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SetManualCells();
                break;
            case "2":
                SetRandomCells();
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór. Losowe wypełnienie domyślne.");
                SetRandomCells();
                break;
        }
    }

    private void SetManualCells()
    {
        Console.WriteLine("Podaj współrzędne początkowych komórek (x y). Wpisz 'start' aby zakończyć.");

        while (true)
        {
            Console.Write("Współrzędne (np. 5 10): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "start")
                break;

            string[] coords = input.Split(' ');

            if (coords.Length != 2)
            {
                Console.WriteLine("Nieprawidłowe współrzędne. Użyj formatu 'x y'.");
                continue;
            }

            if (int.TryParse(coords[0], out int x) && int.TryParse(coords[1], out int y))
            {
                if (x >= 0 && x < width && y >= 0 && y < height)
                {
                    grid[y, x] = true;
                    Console.WriteLine($"Komórka na pozycji [{x}, {y}] została aktywowana.");
                }
                else
                {
                    Console.WriteLine("Współrzędne poza granicami planszy!");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowe współrzędne. Wprowadź liczby.");
            }
        }
    }

    private void SetRandomCells()
    {
        Console.Write("Podaj procent zapełnienia planszy (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int percentage) && percentage >= 0 && percentage <= 100)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    grid[y, x] = random.Next(100) < percentage;
                }
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowy procent. Losowe wypełnienie domyślne 30%.");
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    grid[y, x] = random.Next(100) < 30;
                }
            }
        }
    }

    private int CountNeighbors(int x, int y)
    {
        int neighbors = 0;
        for (int dy = -1; dy <= 1; dy++)
        {
            for (int dx = -1; dx <= 1; dx++)
            {
                if (dx == 0 && dy == 0) continue;

                int newX = (x + dx + width) % width;
                int newY = (y + dy + height) % height;

                if (grid[newY, newX]) neighbors++;
            }
        }
        return neighbors;
    }

    private void UpdateGrid()
    {
        if (gameFinished) return;

        Array.Copy(grid, previousGrid, grid.Length);

        bool cellChanged = false;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                int neighbors = CountNeighbors(x, y);

                bool currentState = grid[y, x];
                if (grid[y, x])
                {
                    nextGrid[y, x] = neighbors == 2 || neighbors == 3;
                }
                else
                {
                    nextGrid[y, x] = neighbors == 3;
                }

                if (currentState != nextGrid[y, x])
                {
                    cellChanged = true;
                }
            }
        }

        bool[,] temp = grid;
        grid = nextGrid;
        nextGrid = temp;

        generationCount++;

        if (!cellChanged)
        {
            EndGame("Plansza osiągnęła stan statyczny!");
            return;
        }

        if (IsAllGridEmpty() || IsAllGridFull())
        {
            EndGame(IsAllGridEmpty()
                ? "Wszystkie komórki wymarły!"
                : "Plansza całkowicie zapełniona!");
            return;
        }
    }


    private void EndGame(string message)
    {
        gameFinished = true;
        Console.Clear();
        Console.WriteLine($"Koniec gry: {message}");
        Console.WriteLine($"Liczba pokoleń: {generationCount}");
        Thread.Sleep(2000);
    }

    private bool IsAllGridEmpty()
    {
        return grid.Cast<bool>().All(cell => !cell);
    }

    private bool IsAllGridFull()
    {
        return grid.Cast<bool>().All(cell => cell);
    }

    public void DrawGrid()
    {
        Console.Clear();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.Write(grid[y, x] ? "█" : " ");
            }
            Console.WriteLine();
        }
    }

    public void Run()
    {
        gameFinished = false;
        generationCount = 0;
        while (!gameFinished)
        {
            DrawGrid();
            UpdateGrid();

            if (!gameFinished)
            {
                Thread.Sleep(300); 
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
        }
    }
}