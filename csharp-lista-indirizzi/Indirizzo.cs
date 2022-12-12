namespace csharp_lista_indirizzi {
    public class Indirizzo {
        // PROPRIETÀ
        public string Nome { get; protected init; }
        public string Cognome { get; protected init; }
        public string Strada { get; protected init; }
        public string Citta { get; protected init; }
        public string Provincia { get; protected init; }
        public string ZIP { get; protected init; }

        // COSTRUTTORI
        public Indirizzo(string nome, string cognome, string strada, string citta, string provincia, string zip) {
            Nome = StringaNonVuota(nome);
            Cognome = StringaNonVuota(cognome);
            Strada = StringaNonVuota(strada);
            Citta = StringaNonVuota(citta);
            Provincia = StringaNonVuota(provincia);
            ZIP = StringaNonVuota(zip);
        }

        // METODI PUBBLICI
        public override string ToString() {
            return $@"Città: {Citta} ({Provincia})
Strada: {Strada}
ZIP: {ZIP}
Abitante: {Nome} {Cognome}";
        }

        // METODI PRIVATI
        protected static string StringaNonVuota(string stringa) {
            return string.IsNullOrWhiteSpace(stringa) ? stringa : throw new ArgumentNullException(nameof(stringa));
        }
    }
}
