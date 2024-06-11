namespace ScrutinMajoritaireProject;

public class Scrutin
{
    public int Id { get; set; }
    public List<Candidat> Candidats { get; set; }
    public bool estCloture { get; set; } = false;

    public Scrutin(int id)
    {
        Id = id;
        Candidats = new List<Candidat>();
    }

    public void AjouterCandidat(Candidat candidat)
    {
        Candidats.Add(candidat);
    }

    public void Voter(int candidatId)
    {
        var candidat = Candidats.FirstOrDefault(c => c.Id == candidatId);
        if (candidat != null)
        {
            candidat.NombreDeVoix++;
        }
    }

    public Candidat ObtenirVainqueur()
    {
        if (estCloture)
        {
            return Candidats.OrderByDescending(c => c.NombreDeVoix).FirstOrDefault();
        }

        return null;
    }
}