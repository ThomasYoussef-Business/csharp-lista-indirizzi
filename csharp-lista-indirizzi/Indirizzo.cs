namespace csharp_lista_indirizzi {
    public class Indirizzo {
        // ATTRIBUTI


        // PROPRIETÀ
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Strada { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string ZIP { get; set; }

        // COSTRUTTORI
        public Indirizzo(string nome, string cognome, string strada, string citta, string provincia, string zip) {
            Nome = nome;
            Cognome = cognome;
            Strada = strada;
            Citta = citta;
            Provincia = provincia;
            ZIP = zip;
        }


        // METODI PUBBLICI


        // METODI PRIVATI

    }
}
