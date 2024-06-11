namespace ScrutinMajoritaireProject;

public class Candidat
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public int NombreDeVoix { get; set; }

    public Candidat(int id, string nom)
    {
        Id = id;
        Nom = nom;
        NombreDeVoix = 0;
    }
}