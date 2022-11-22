// See https://aka.ms/new-console-template for more information
/* --------------- IL LIBRO DI OGGI: <<titolo>> di <<autore>> ----------------


Informazioni generiche:
ISBN: << isbn >>
Numero delle pagine: << numeroPagine >> pagine
Peso del libro: << pesoLibro >> kg
Dimensioni del libro: << larghezza >> cm x << lunghezza >> cm x << profondita >> cm
Informazioni Amazon:
Numero di recensioni: << numeroRecensioni >> recensioni
Valutazione media: << valutazioneMedia >> stelline
Kindle disponibile: Si o No
Copertina flessibile disponibile: Si o No */

string titolo = "Clean Code: A Handbook of Agile Software Craftsmanship";
string autore = "Robert C. Martin";
int pagine = 464;
long ISBN = 9780132350884;
double peso = 0.7983226;
float larghezza = 17.78f;
float lunghezza = 23.368f;
float profondita = 2.794f;
int numeroRecensioni = 4741;
double valutazioneMedia = 4.7;
bool kindle = true;
bool copertina = true;

Console.WriteLine("--------------- IL LIBRO DI OGGI: " +titolo+"\n di "+autore+ "----------------\n");
Console.WriteLine("Informazioni Generiche: ");
Console.WriteLine("Numero di pagine:" + pagine + " pagine.");
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Peso del libro: " + peso + "kg.");
Console.WriteLine("Dimensioni del libro: "+larghezza+"cm x "+lunghezza+"cm x "+profondita+"cm");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: "+numeroRecensioni+" recensioni");
Console.WriteLine("Valutazione media: "+valutazioneMedia+" stelline");
if (kindle) Console.WriteLine("Kindle disponibile: Si");
else Console.WriteLine("Kindle disponibile: No");
if (copertina) Console.WriteLine("Copertina flessibile disponibile: Si");
else Console.WriteLine("Copertina flessibile disponibile: No");