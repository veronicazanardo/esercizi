/*Esercizio 1: Calcolo dell'area del cerchio
Dichiara una variabile double per il raggio (valore a scelta). 
Calcola e stampa l'area del cerchio usando Math.PI. 
Formatta il risultato con 2 cifre decimali */

using System.Xml.Schema;

double raggio = 10;
double area = Math.Pow(raggio, 2)* Math.PI;
Console.WriteLine($"L'area del cerchio è: {area:F2}");

/*Esercizio 2: Conversione esplicita di tipi
Leggi due numeri interi da tastiera. Dividili e stampa il risultato come numero decimale (double), 
assicurandoti che la divisione non sia intera. */

Console.WriteLine("Digita il primo numero");
string input1 = Console.ReadLine()!;
int numero1 = int.Parse(input1);

Console.WriteLine("Digita il secondo numero");
string input2 = Console.ReadLine()!;
int numero2 = int.Parse(input2);

double divisione = (double)numero1 /numero2;
Console.WriteLine($"Risultato della divisione: {divisione:F2}");

/*Esercizio 3: Classificazione di un numero
Leggi un numero intero da tastiera e stampa se è positivo, negativo o zero. 
Usa una struttura if-else if-else.
*/
Console.WriteLine("Digita un numero");
string input3 = Console.ReadLine()!;
int numero3 = int.Parse(input3);
if (numero3 > 0)
{
    Console.WriteLine($"Il numero {numero3} è positivo");
}
else if (numero3 < 0)
{
    Console.WriteLine($"Il numero {numero3} è negativo");
}
else
{
    Console.WriteLine("Il numero è 0");
}


/* Esercizio 4: Voto scolastico con switch
Leggi un voto intero da 1 a 10.
Usando switch, stampa il giudizio corrispondente:
9-10 = Ottimo, 
7-8 = Buono, 
6 = Sufficiente, 
1-5 = Insufficiente. 
Gestisci anche valori fuori range.
*/

Console.WriteLine("Inserisci il voto numerico (da 1 a 10): ");
string input4 = Console.ReadLine()!;
int numero4 = int.Parse(input4);

switch (numero4)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Insufficiente");
        break;
    case 6:
        Console.WriteLine("Sufficiente");
        break;
    case 7:
    case 8:
        Console.WriteLine("Buono");
        break;
    case 9:
    case 10:
        Console.WriteLine("Ottimo");
        break;
    default:
        Console.WriteLine("Valore non valido");
        break;
}

/*Esercizio 5: Tabellina con ciclo for
Leggi un numero intero da tastiera e stampa la sua tabellina da 1 a 10 usando un ciclo for. 
Ogni riga deve avere il formato: "N x i = risultato".
*/

Console.WriteLine("Inserisci un numero: ");
string input5 = Console.ReadLine()!;
int numero5 = int.Parse(input5);

for (int i=1; i <= 10; i++)
{
    int moltiplicazione = numero5 * i;
    Console.WriteLine($"{numero5} * {i} = {moltiplicazione}");
}

/* Esercizio 6: Somma di N numeri con while
Chiedi all'utente quanti numeri vuole sommare (N). 
Usa un ciclo while per leggere N numeri interi e stampare la loro somma e la media.
*/

Console.WriteLine("Quanti numeri vuoi sommare? ");
string input6 = Console.ReadLine()!;
int numero6 = int.Parse(input6);


int i2 = 0;
int somma = 0;
while (i2 < numero6)
{
    Console.WriteLine("Inserisci il numero: ");
    int numero7 = int.Parse(Console.ReadLine()!);
    somma += numero7;
    i2++;
}
double media = (double)somma/numero6;
Console.WriteLine($"La somma dei numeri è {somma}, mentre la media è {media}");

/*Esercizio 7: Indovina il numero
Il programma genera un numero casuale tra 1 e 100 con Random. 
L'utente ha tentativi illimitati: ad ogni tentativo il programma risponde 'Troppo alto', 'Troppo basso' o 'Esatto!'. 
Stampa infine il numero di tentativi impiegati.
*/

Random random = new();
int numeroCasuale = random.Next(1, 101); //primo incluso secondo escluso
int i3 = 0;

Console.WriteLine("Indovina il numero! Scrivine uno: ");

while(true)
{
    string input8 = Console.ReadLine()!;
    int numero8 = int.Parse(input8);

    i3++;

    if(numero8 < numeroCasuale)
    {
        Console.WriteLine("Troppo basso! Ritenta");
    }
    else if(numero8 > numeroCasuale)
    {
        Console.WriteLine("Troppo alto! Ritenta");
    }
    else
    {
        Console.WriteLine($"Esatto! Ci hai messo {i3} tentativi!");
        break;
    }
}

/*Esercizio 8: Minimo, massimo e media di un array
Crea un array di 6 interi inseriti dall'utente. 
Senza usare LINQ, trova e stampa il valore minimo, il massimo e la media dei valori.
*/
int[] array = new int[6];
int somma2 = 0;
for(int p = 0; p <6; p++)
{
    Console.WriteLine($"Inserisci il numero {p + 1}");
    array[p] = int.Parse(Console.ReadLine()!);
    somma2+= array[p];
}
double media2 = (double)somma2/6;

int min = array[0];
int max = array[0];

foreach(int m in array)
{
    if (m < min)
    {
        min = m;
    }
    if (m > max)
    {
        max = m;
    }
}
Console.WriteLine($"Il valore massimo è: {max}");
Console.WriteLine($"Il valore minimo è: {min}");
Console.WriteLine($"La media dei valori è: {media2}");

/* Esercizio 9: Filtraggio con List e LINQ
Crea una List<string> con almeno 6 nomi inseriti dall'utente.
Usando LINQ (Where e OrderBy), stampa solo i nomi con più di 4 caratteri, ordinati alfabeticamente.
*/
var nomi = new List<string>();

for(int q = 0; q <6; q++)
{
    Console.WriteLine($"Inserisci il nome {q + 1}");
    nomi.Add(Console.ReadLine()!);
}

var risultato = nomi
    .Where(q => q.Length > 4)
    .OrderBy(q => q)
    .ToList();

foreach(string t in risultato)
{
    Console.WriteLine(t);
}

/* Esercizio 10: Numero primo
Scrivi un metodo bool IsPrimo(int n) che restituisce true se n è un numero primo. 
Nel Main, leggi un numero da tastiera e stampa se è primo o no.
*/

static bool IsPrimo(int z)
{

    if(z <= 1)
    {
        return false;
    }

    for(int w = 2; w <= Math.Sqrt(z); w++)
    {
        if(z%w == 0)
        return false;
    }

    return true;
}
Console.WriteLine("Scrivi un numero e ti dico se è primo: ");
int numero9 = int.Parse(Console.ReadLine()!);
bool risultato2 = IsPrimo(numero9);
if (risultato2 == true)
{
    Console.WriteLine("è primo");
}
else
{
    Console.WriteLine("Non è primo");
}

/* Esercizio 11: Fattoriale ricorsivo
Scrivi un metodo ricorsivo long Fattoriale(int n) che calcola il fattoriale di n. 
Gestisci il caso base (n <= 1) e testa il metodo con valori inseriti dall'utente.
*/

static long Fattoriale(int x)
{
    if (x <= 1)
        return 1;

    return x * Fattoriale(x -1);
}

Console.WriteLine("Scrivi un numero e ti dico il fattoriale: ");
int c = int.Parse(Console.ReadLine()!);
long risposta3 = Fattoriale(c);
Console.WriteLine($"Il fattoriale di {c} è {risposta3}");

