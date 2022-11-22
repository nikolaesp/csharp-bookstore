// See https://aka.ms/new-console-template for more information
/* 
 * 
BONUS:
Per chi di voi che se la sente può poi modificare questo programma, creando un nuovo progetto BONUS
dove può cimentarsi nel rendere le variabili non più “hardcoded” nel codice e provare invece a chiedere 
le informazioni del libro direttamente all’utente tramite l’input della console.
Ricordatevi poi di cambiare il progetto principale con l'opzione set as startup project facendo destra mouse
sul progetto che volete eseguire.
 */
Console.WriteLine("Titlo: ");
string titolo = Console.ReadLine();
Console.WriteLine("Autore: ");
string autore = Console.ReadLine();
Console.WriteLine("Pagine: ");
int pagine = int.Parse(Console.ReadLine());
Console.WriteLine("ISBN: ");
long ISBN = long.Parse(Console.ReadLine());
Console.WriteLine("Peso: ");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("Larghezza: ");
double larghezza = double.Parse(Console.ReadLine());
Console.WriteLine("Lunghezza: ");
double lunghezza = double.Parse(Console.ReadLine());
Console.WriteLine("Profondita: ");
double profondita = double.Parse(Console.ReadLine());
Console.WriteLine("Numero di recensioni: ");
int numeroRecensioni = int.Parse(Console.ReadLine());
Console.WriteLine("Valutazione media: ");
double valutazioneMedia = double.Parse(Console.ReadLine());
bool kindle;
string ink;
Console.WriteLine("Kindle Y o N ?");
ink = Console.ReadLine();
if(ink == "y")
{
    kindle= true;
}
else
{
        kindle= false;
}

bool copertina;
Console.WriteLine("Copertina Y o N ?");
ink = Console.ReadLine();
if(ink == "y") { copertina= true; }
else
{
        copertina= false;
}

Console.WriteLine("--------------- IL LIBRO DI OGGI: " + titolo + "\n di " + autore + "----------------\n");
Console.WriteLine("Informazioni Generiche: ");
Console.WriteLine("Numero di pagine:" + pagine + " pagine.");
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Peso del libro: " + peso + "kg.");
Console.WriteLine("Dimensioni del libro: " + larghezza + "cm x " + lunghezza + "cm x " + profondita + "cm");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioni + " recensioni");
Console.WriteLine("Valutazione media: " + valutazioneMedia + " stelline");
if (kindle) Console.WriteLine("Kindle disponibile: Si");
else Console.WriteLine("Kindle disponibile: No");
if (copertina) Console.WriteLine("Copertina flessibile disponibile: Si");
else Console.WriteLine("Copertina flessibile disponibile: No");