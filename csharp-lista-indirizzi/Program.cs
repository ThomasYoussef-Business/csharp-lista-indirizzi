/*
 * Il compito è di leggere un file CSV, e salvare tutti gli indirizzi contenuti al suo interno
 * in una lista di oggetti istanziati a partire dalla classe Indirizzo.
 */

using csharp_lista_indirizzi;

string path = "C:\\Users\\thoma\\Desktop\\Desktop\\Programming\\NET Course\\repos\\csv-files\\addresses.csv";
string contenuto = "";
string[] linee;
List<Indirizzo> indirizzi = new();
StreamReader fileIndirizzi;

if (!File.Exists(path)) {
    throw new FileNotFoundException($"Il file {path} specificato non esiste!", path);
}

fileIndirizzi = File.OpenText(path);
contenuto = fileIndirizzi.ReadToEnd();
linee = contenuto.Split('\n');
fileIndirizzi.Close();

for (int i = 1; i < linee.Length; i++) {
    string[] datiIndirizzo = linee[i].Split(',');
    if (DatiValidi(datiIndirizzo)) {
        Indirizzo nuovoIndirizzo = new(datiIndirizzo);
        indirizzi.Add(nuovoIndirizzo);
    }
}

foreach (Indirizzo indirizzo in indirizzi) {
    Console.WriteLine($"{indirizzo}\n");
}

static bool DatiValidi(string[] datiIndirizzo) {
    return datiIndirizzo.Length == 6 &&
        !datiIndirizzo.Any(s => string.IsNullOrWhiteSpace(s));
}