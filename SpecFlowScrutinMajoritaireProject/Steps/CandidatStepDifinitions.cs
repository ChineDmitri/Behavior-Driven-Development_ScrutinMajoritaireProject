using FluentAssertions;
using ScrutinMajoritaireProject;
using Xunit;

namespace SpecFlowScrutinMajoritaireProject;

[Binding]
public class CandidatStepDifinitions
{
    public List<Candidat> _candidats = new List<Candidat>();

    [Given(@"je n'ai aucun candidat")]
    public void GivenJeNaiAucunCandidat()
    {
        _candidats.Should().BeEmpty();
    }

    [When(@"j'ajoute un candidat avec les informations suivantes :")]
    public void WhenJidentifiantEtLeNom(Table table)
    {
        foreach (var row in table.Rows)
        {
            int id = int.Parse(row["Id"]);
            string nom = row["Nom"];
            var candidat = new Candidat(id, nom);
            candidat.Id.Should().Be(id);
            candidat.Nom.Should().Be(nom);

            _candidats.Append(candidat);
        }
    }

    [Then(@"le candidat avec l'identifiant (.*) devrait avoir le nom ""(.*)""")]
    public void ThenLeCandidatAvecLidentifiantDevraitAvoirLeNom(int id, string nom)
    {
        var candidat = _candidats.FirstOrDefault(c => c.Id == id);
        if (candidat != null)
        {
            candidat.Nom.Should().BeEquivalentTo(nom);
        }
    }


    [Given(@"j'ai un candidat avec l'identifiant (.*) et le nom ""(.*)""")]
    public void GivenJidentifiantEtLeNom(int id, string nom)
    {
        var candidat = new Candidat(id, nom);
        _candidats.Add(candidat);
    }

    [When(@"je vote le candidat avec l'identifiant (.*)")]
    public void WhenJeVoteLeCandidatAvecLidentifiant(int id)
    {
        var candidat = _candidats.FirstOrDefault(c => c.Id == id);
        if (candidat != null)
        {
            candidat.RecevoirVoix();
        }
    }

    [Then(@"j'ai incrimenté le nombre de vote du candidat avec l'identifiant (.*)")]
    public void ThenIncrimenteVoix(int id)
    {
        var candidat = _candidats.FirstOrDefault(c => c.Id == id);
        if (candidat != null)
        {
            candidat.NombreDeVoix.Should().BeGreaterThan(0);
        }
    }
}