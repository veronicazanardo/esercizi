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

