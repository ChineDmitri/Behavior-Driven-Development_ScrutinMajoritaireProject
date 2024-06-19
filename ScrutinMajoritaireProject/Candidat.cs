namespace ScrutinMajoritaireProject;

public class Candidat
{
    public int Id { get; private set; }
    public string Nom { get; private set; }
    public int NombreDeVoix { get; private set; }

    public void RecevoirVoix()
    {
        this.NombreDeVoix++;
    }

    public Candidat(int id, string nom)
    {
        Id = id;
        Nom = nom;
        NombreDeVoix = 0;
    }
}