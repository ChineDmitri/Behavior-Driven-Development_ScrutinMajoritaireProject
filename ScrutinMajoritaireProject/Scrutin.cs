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

    private Scrutin()
    {
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
            candidat.RecevoirVoix();
        }
    }

    public Candidat ObtenirVainqueurTT()
    {
        if (estCloture)
        {
            var resultats = Resultats();
            var vainqueur = resultats.OrderByDescending(r => r.Value).FirstOrDefault().Key;

            if (resultats[vainqueur] > 50)
            {
                Console.WriteLine($"{vainqueur.Nom} est déclaré vainqueur du scrutin.");
                return vainqueur;
            }

            Console.WriteLine("Il n'y a pas de vainqueur clair. Un second tour est nécessaire.");
        }

        return null;
    }

    public List<Candidat> ObtenirVainqueurT()
    {
        if (estCloture)
        {
            var resultats = Resultats();
            var vainqueurs = resultats.OrderByDescending(r => r.Value).ToList();

            if (vainqueurs[0].Value > 50)
            {
                Console.WriteLine($"{vainqueurs[0].Key.Nom} est déclaré vainqueur du scrutin.");
                return new List<Candidat> { vainqueurs[0].Key };
            }
            else
            {
                // Check for ties for the second and third place
                if (vainqueurs.Count >= 3 && vainqueurs[1].Value == vainqueurs[2].Value)
                {
                    var tiedCandidates = vainqueurs.Skip(1).Take(2).Select(r => r.Key).ToList();
                    var earliestRegisteredCandidate = tiedCandidates.OrderBy(c => c.DateEnregistrement).First();
                    Console.WriteLine($"Il y a une égalité entre {tiedCandidates[0].Nom} et {tiedCandidates[1].Nom}. " +
                                      $"Le vainqueur du second tour est {earliestRegisteredCandidate.Nom}.");
                    return new List<Candidat> { earliestRegisteredCandidate };
                }
                else
                {
                    Console.WriteLine("Il n'y a pas de vainqueur clair. Un second tour est nécessaire.");
                    return vainqueurs.Take(2).Select(r => r.Key).ToList();
                }
            }
        }

        return new List<Candidat>();
    }

    public List<Candidat> ObtenirVainqueur()
    {
        if (estCloture)
        {
            var resultats = Resultats();
            var vainqueurs = resultats.OrderByDescending(r => r.Value).ToList();

            if (vainqueurs[0].Value > 50)
            {
                Console.WriteLine($"{vainqueurs[0].Key.Nom} est déclaré vainqueur du scrutin.");
                return new List<Candidat> { vainqueurs[0].Key };
            }
            else if (vainqueurs.Count == 2)
            {
                Console.WriteLine("Il n'y a pas de vainqueur clair. Un second tour est nécessaire.");
                return vainqueurs.Take(2).Select(r => r.Key).ToList();
            }
            else
            {
                Console.WriteLine("Il n'y a pas de vainqueur clair. Un second tour est nécessaire.");
                if (vainqueurs[1].Value == vainqueurs[2].Value)
                {
                    return new List<Candidat>
                    {
                        vainqueurs[0].Key,
                        vainqueurs[1].Key.DateEnregistrement < vainqueurs[2].Key.DateEnregistrement
                            ? vainqueurs[1].Key
                            : vainqueurs[2].Key
                    };
                }

                return vainqueurs.Take(2).Select(r => r.Key).ToList();
            }
        }

        return new List<Candidat>();
    }


    public int TotalVotes()
    {
        return Candidats.Sum(c => c.NombreDeVoix);
    }

    public Dictionary<Candidat, double> Resultats()
    {
        var totalVotes = TotalVotes();
        var resultats = new Dictionary<Candidat, double>();
        foreach (var candidat in Candidats)
        {
            double pourcentage = (double)candidat.NombreDeVoix / totalVotes * 100;
            resultats.Add(candidat, Math.Round(pourcentage, 2));
        }

        return resultats;
    }

    public void afficherResultat()
    {
        foreach (var candidat in Resultats())
        {
            Console.WriteLine($"{candidat.Key.Nom} : {candidat.Value}%");
        }
    }
}