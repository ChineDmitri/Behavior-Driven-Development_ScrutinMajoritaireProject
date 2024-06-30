namespace ScrutinMajoritaireProject;

public class Candidat
{
    public int Id { get; private set; }
    public string Nom { get; private set; }
    public int NombreDeVoix { get; private set; } = 0;
    public DateTime DateEnregistrement { get; private set; }

    public void RecevoirVoix()
    {
        this.NombreDeVoix++;
    }

    public Candidat(int id, string nom, DateTime dateEnregistrement)
    {
        Id = id;
        Nom = nom;
        NombreDeVoix = 0;
        DateEnregistrement = dateEnregistrement;
    }

    public Candidat(int id, string nom)
    {
        Id = id;
        Nom = nom;
        NombreDeVoix = 0;
        DateEnregistrement = DateTime.Now;
    }

    public void RemettreVoixAZero()
    {
        NombreDeVoix = 0;
    }
}