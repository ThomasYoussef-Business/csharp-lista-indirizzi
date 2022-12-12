/*
 * Il compito è di leggere un file CSV, e salvare tutti gli indirizzi contenuti al suo interno
 * in una lista di oggetti istanziati a partire dalla classe Indirizzo.
 */

using csharp_lista_indirizzi;

string path = "C:\\Users\\thoma\\Desktop\\Desktop\\Programming\\NET Course\\repos\\csv-files\\addresses.csv";
string contenuto = "";
string[] linee;
List<Indirizzo> indirizzi = new();

using (StreamReader fileIndirizzi = File.OpenText(path)) {
    contenuto = fileIndirizzi.ReadToEnd();
}

linee = contenuto.Split('\n');

for (int i = 1; i < linee.Length; i++) {
    string linea = linee[i];
    string[] datiIndirizzo = LineaProcessata(linea);

    if (DatiValidi(datiIndirizzo)) {
        Indirizzo nuovoIndirizzo = new(datiIndirizzo);
        indirizzi.Add(nuovoIndirizzo);
    }
}

foreach (Indirizzo indirizzo in indirizzi) {
    Console.WriteLine($"{indirizzo}\n");
}


// -------------------------------------------------------------------

static bool DatiValidi(string[] datiIndirizzo) {
    return datiIndirizzo.Length == 6 &&
        !datiIndirizzo.Any(s => string.IsNullOrWhiteSpace(s));
}

static string[] LineaProcessata(string linea) {
    return linea.Split(',')
                .Select(s => s.Trim())
                .ToArray();
}