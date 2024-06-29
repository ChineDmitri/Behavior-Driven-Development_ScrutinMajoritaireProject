namespace ScrutinMajoritaireProject;

public class Scrutin
{
    public int Id { get; set; }
    public List<Candidat> Candidats { get; set; }
    public bool estCloture { get; private set; } = false;
    public bool estSecondTour { get; private set; } = false;


    public Scrutin(int id)
    {
        Id = id;
        Candidats = new List<Candidat>();
    }

    private Scrutin()
    {
    }

    public void AjouterCandidat(Candidat candidat)
    {
        Candidats.Add(candidat);
    }

    public void Voter(int candidatId)
    {
        if (estCloture)
        {
            throw new InvalidOperationException("Scrutin déjà cloturé");
        }

        var candidat = Candidats.FirstOrDefault(c => c.Id == candidatId);
        if (candidat != null)
        {
            candidat.RecevoirVoix();
        }
    }


    public List<Candidat> ObtenirVainqueur()
    {
        if (estCloture && !estSecondTour)
        {
            var resultats = ResultatsParIdCandidat();
            var vainqueurs = resultats.OrderByDescending(r => r.Value).ToList();

            if (vainqueurs[0].Value > 50)
            {
                Console.WriteLine($"{vainqueurs[0].Key.Nom} est déclaré vainqueur du scrutin.");
                return new List<Candidat> { vainqueurs[0].Key };
            }

            bool estTousGagnantsPourcentagesEgaux = vainqueurs.All(v => v.Value == vainqueurs[0].Value);
            if (estTousGagnantsPourcentagesEgaux)
            {
                Candidats = Candidats.OrderBy(
                        c => c.DateEnregistrement
                    )
                    .Take(2)
                    .ToList();
                DeclarerSecondTour();

                return Candidats;
            }

            if (vainqueurs[1].Value == vainqueurs[2].Value)
            {
                Candidats = new List<Candidat>
                {
                    vainqueurs[0].Key,
                    vainqueurs[1].Key.DateEnregistrement < vainqueurs[2].Key.DateEnregistrement
                        ? vainqueurs[1].Key
                        : vainqueurs[2].Key
                };
                DeclarerSecondTour();

                return Candidats;
            }

            DeclarerSecondTour();
            Candidats = vainqueurs.Take(2).Select(r => r.Key).ToList();
            return Candidats;
        }
        else
        {
            var resultats = ResultatsParIdCandidat();
            // var vainqueurs = resultats.OrderBy(r => r.Key.Id).ToList();

            if (Candidats[0].NombreDeVoix == Candidats[1].NombreDeVoix)
            {
                Console.WriteLine("On ne peut pas déterminer un vainqueur clair dans le second tour.");
                return Candidats;
            }

            if (Candidats[0].NombreDeVoix > Candidats[1].NombreDeVoix)
            {
                Console.WriteLine($"{Candidats[0].Nom} est déclaré vainqueur du scrutin.");
                return new List<Candidat> { Candidats[0] };
            }

            return new List<Candidat> { Candidats[1] };
        }
    }


    public int TotalVotes()
    {
        return Candidats.Sum(c => c.NombreDeVoix);
    }

    public Dictionary<Candidat, double> ResultatsParIdCandidat()
    {
        var totalVotes = TotalVotes();

        var resultats = new Dictionary<Candidat, double>();
        foreach (var candidat in Candidats.OrderBy(c => c.Id))
        {
            double pourcentage = (double)candidat.NombreDeVoix / totalVotes * 100;
            resultats.Add(candidat, Math.Round(pourcentage, 2));
        }

        return resultats;
    }

    public void Cloture()
    {
        if (!estCloture)
        {
            estCloture = true;
            afficherResultat();
        }
    }

    public void DeclarerSecondTour()
    {
        if (!estSecondTour)
        {
            Console.WriteLine("Il n'y a pas de vainqueur clair. Un second tour est nécessaire.");
            estSecondTour = true;
            estCloture = false;
            foreach (var candidat in Candidats)
            {
                candidat.RemettreVoixAZero();
            }
        }
    }

    public void afficherResultat()
    {
        if (estCloture)
        {
            foreach (var candidat in ResultatsParIdCandidat())
            {
                Console.WriteLine($"{candidat.Key.Nom} : {candidat.Value}%");
            }
        }
        else
        {
            throw new InvalidOperationException("Scrutin non cloturé");
        }
    }
}