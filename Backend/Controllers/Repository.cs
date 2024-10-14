namespace Backend.Controllers
{
    public class Repository
    {
        public static List<PersonaDatos> persona = new List<PersonaDatos> { 
        new PersonaDatos()
        {
            id = 1,
            age = new DateTime(1994,08,03),
            name = "Felix Mauricio Palacios"
        },
        new PersonaDatos()
        {
            id = 2,
            age = new DateTime(1998,09,03),
            name = "Mauricio Palacios"
        },
        new PersonaDatos()
        {
            id = 3,
            age = new DateTime(1998,10,03),
            name = "Palacios"
        }

        };
    }
}

public class PersonaDatos
{
    public int id { get; set; }
    public string name { get; set; }
    public DateTime age { get; set; }

}
