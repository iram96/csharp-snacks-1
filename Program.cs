﻿// See https://aka.ms/new-console-template for more information
/* using System.Text;

var word1 = "sjasfafaflalfa";
var word2 = "jksksafadalfk";

//costruisco una stringa di mille a
string milleA = new string('a', 1000);

//concatenare molte stringhe (stringBuilder)

string lungA = new string('a', 1000);
string lungB = new string('a', 1000);

StringBuilder sb = new StringBuilder();


//nei numeri reali la distanza tra la prima el'ultima cifra significativa
// non può superare le 16 posiziomi decimali

Console.WriteLine(Math.BitIncrement(1.0)); // => 1,000000000000002
Console.WriteLine(Math.BitDecrement(1.0)); // => 0,999999999999998

//Operatore modulo: il resto della divisione intera
Console.WriteLine(20 % 6); // 2

//Array

//inizializzazione vettore
string[] vec1 = new string[] { "uno", "due", "tre", "quattro" };

//METODI IMPORTANTI:
// MAP & REDUCE

//MAP:
//applica una funzione a tutti gli elemtni della sequenza e ottiene
//una sequenza simile di apori dimensioni riempita con i risultati della funzione

//!!! può essere eseguita in parallelo senza perdere significatività
//non conosco l'ordine in la cui la funzione viene applicata ai singoli elementi


//REDUCE
//Applica in sequenza (iterativamente) una funzione a tutti gli elementi di una sequenza
//e torna il risultato finale della funzione
//La funzione si aspetta due parametri:
//- l'elemento corrente
//- il risultato dell'operazione precedente

*/

var len = "alfhakshdkahjs".Length; //Equivalente a int len....
//Costruire una stringa lunga 1000 caratteri a
string millea = new string('a', 1000);
//Qundo dovete concatenare molte stringhe,
//allora utilizzate StringBuilder, è molto più veloce
//StringBuilder sb = new StringBuilder();
string lunga = new string('a', 1000);
string lungb = new string('b', 1000);
string lungab = lunga + lungb + millea;
foreach (char c in lungab.Distinct<char>())
{
    Console.WriteLine(c);
}
//Operatore modulo
//Il software chiede all’utente di inserire un
//numero. Se il numero inserito è pari, stampa
//il numero, se è dispari, stampa il numero successivo.
int num = -20;
Console.WriteLine(Math.Abs(num));
Console.WriteLine(Math.BitIncrement(12.0));  // => 12,000000000000002
Console.WriteLine(Math.BitDecrement(12.0));  // => 11,999999999999998
Console.WriteLine(Math.BitIncrement(-1.0));  // => -1,0000000000000002
Console.WriteLine(Math.BitDecrement(-1.0));  // => -0,9999999999999999
Console.WriteLine(Math.BitIncrement(0.0));  // => 5E-324 => 5  * 10^-324 => 0.0(324 volte)5
Console.WriteLine(Math.BitDecrement(0.0));  // => -5E-324=> -5 * 10^-324
Console.WriteLine(Math.BitIncrement(1.0));  // => 1,0000000000000002
Console.WriteLine(Math.BitDecrement(1.0));  // => 0,9999999999999999
//nei numeri reali la distanza tra la prima e l'ultima
//cifra significativa non può superare le 16 posizioni decimali
//Operatore modulo: il resto della divisione intera
Console.WriteLine(20 % 6); //2
//Array in csharp
//Crea un array di numeri interi e fai la somma di tutti gli
//elementi che sono in posizione dispari.
//array di caratteri
char[] vc;
//array di interi
int[] vi;
//array di bool
bool[] vb;
//array di reali
double[] vd;
//Array di stringhe
string[] vs;
//Array di array !!! ma sempre di qualcosa
int[][] vii;
//Esempio[] vesempio;
//!!!In tutti i linguaggi abbiamo due
//funzioni/metodi/operatori estremamente importanti e utili
//Questi sono: map e reduce
//map?? applica una funzione a tutti gli
//elementi di una sequenza e ottiene una sequenza di pari dimensioni
//riempita con i risultati della funzione
//!!!!map può essere eseguita in "PARALLELO" senza perdere di significatività
//non conoscete l'ordine in cui la funzione viene applicata
//ai singoli elementi della sequenza
//NB: la funzione applicata si aspetta un solo parametro, l'elemento corrente
//Reduce!! applica "iterativamente" una funzione a tutti gli elementi di
//una sequenza e torna il risultato finale della funzione
//la funzione applicata si aspetta DUE parametri: l'lemeneto corrente e il risultato
//dell'applicazione precedente
//Fatto sulle liste, ad esempio
/*(1 2 3 4 5 6 7 8 9 10) e applico il + con la reduce =>
 * prima chiamata   (+ 1 2) => 3
 * seconda chiamata (+ 3 3) => 6
 * terza chiamata   (+ 4 6) => 10
 * quarta chiamata  (+ 5 10) => 15
 * ...
 * */
/*Architetture di esecuzione delle CPU/GPU
 * Intel pentium: multiple instructions multiple data MIMD => in genere multithreading
 * Apple m1: MIMD
 * Nvidia 3080/geforce => SIMD Single intruction multiple data => Parallelismo ?
 * esempio: calcolo matriciale
 *  (2 3 4)        (1 2 3)    per ogni coppia di elementi (em1, em2) => applica +
 *  (7 6 1)    +   (4 5 6)  =
 *  (0 9 1)        (5 4 3)
 *
 * */
//un esempiio di inizializzazione di un vettore
string[] vs1 = new string[] { "uno", "due", "tre", "quattro" };
//vs1.Aggregate  => public static TResult Aggregate<TSource,TAccumulate,TResult>
//(this System.Collections.Generic.IEnumerable<TSource> source, TAccumulate seed,
//Func<TAccumulate,TSource,TAccumulate> func, Func<TAccumulate,TResult> resultSelector);
//voglio contare quante stringhe ci sono nel vettore
Console.WriteLine(vs1.Aggregate(0, (old, current) => old + 1));
//Voglio contare la lunghezza totale delle stringhe nel vettore
Console.WriteLine(vs1.Aggregate(0, (old, current) => old + current.Length));
//Voglio trovare la stringa più lunga
Console.WriteLine(vs1.Aggregate("",
    (old, current) => (old.Length >= current.Length) ? old : current));
//if then else sulla stessa riga
var a = (1 == 2) ? "uguale" : "diverso";
//expr. logica  ? caso true   : caso false;
//La formulazione lambda in C# corrisponde a:
/*
 * (old, current)          => old + current.Length
 * parametri di chiamata      Corpo della funzione, ultima istruzione è il return (implicito)
  int somma(old, current) {
     return old+current;
  }
 * */
//Lo utilizzo come se fosse la find: cerco "pippo"
Console.WriteLine(vs1.Aggregate(false,
    (old, current) => old ? true :
                        (("pippo".CompareTo(current) == 0) ? true : false)));
List<int> li = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(li.Aggregate(0, (old, current) => old + current));
int[] arr = new int[] { 3, 5, 7, 1, 2, 0, 9, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6 };
//Stampa la somma di tutti gli elementi che sono in posizione dispari
//Esempio 1
int totale = 0;
for (int i = 0; i < arr.Length; i++)
    if ((i % 2) != 0)
        totale = totale + arr[i];
//Esempio 2
int totale1 = 0;
for (int i = 1; i < arr.Length; i += 2)
    totale1 = totale1 + arr[i];
//Stampa la somma di tutti gli elementi dispari
int totale2 = 0;
for (int i = 0; i < arr.Length; i++)
    if ((arr[i] % 2) != 0)
        totale2 = totale2 + arr[i];
//Con la aggregate
arr.Aggregate(0, (int prec, int current) =>
{
    if ((current % 2) != 0)
        return prec + current;
    else
        return prec;
});
//Scopriamo in che ordine opera la aggregate
string[] vs3 = new string[] { "uno", "due", "tre" };
vs3.Aggregate("", (string old, string current) =>
{
    Console.WriteLine(current);
    return "";
});
//Stampa "uno" "due" "tre". L'ordine della aggregate è dal primo all'ultimo della sequenza!
//Ancora
//Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array,
//fino a quando la somma degli elementi è minore di 50.
//!!Sostituiamo la richiesta all'utente con numeri casuali
//noi non abbiamo gli array dinamici, quindi lo iniziamo come lista
List<int> listOfInt = new List<int>();
int somma = 0;
Random rng = new Random();
while (true)
{
    int n1 = rng.Next(0, 10);
    if ((somma + n1) > 50)
        break;
    somma += n1;
    listOfInt.Add(n1);
}
var vret = listOfInt.ToArray();
foreach (int i in vret)
    Console.Write("{0} ", i);
Console.WriteLine();

//Dato un vettore di interi con numeri casuali calcolare la mdeia dei valori
//il vettore deve contenere 10k elementi

int[] vett = new int[10000];
double sommaArr = 0.0;

for (int i = 0; i < vett.Length; i++)
{
    vett[i] = rng.Next(0, 100);
    sommaArr += vett[i];


}

double media = sommaArr / vett.Length;
Console.WriteLine("La media è {0}", media);