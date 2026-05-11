/*Esercizio 1: Calcolo dell'area del cerchio
Dichiara una variabile double per il raggio (valore a scelta). 
Calcola e stampa l'area del cerchio usando Math.PI. 
Formatta il risultato con 2 cifre decimali */

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