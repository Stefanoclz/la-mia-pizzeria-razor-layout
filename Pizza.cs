namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public string name = "";
        public string description = "";
        public string fotoLink = "";
        public decimal prezzo;
        public int id;

        public Pizza(string name, string description, string fotoLink, decimal prezzo, int id)
        {
            this.name = name;
            this.description = description;
            this.fotoLink = fotoLink;
            this.prezzo = prezzo;
            this.id = id;
        }

    }
}
