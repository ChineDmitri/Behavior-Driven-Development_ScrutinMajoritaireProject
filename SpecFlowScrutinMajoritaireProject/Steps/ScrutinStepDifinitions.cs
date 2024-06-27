using System.Text;
using FluentAssertions;
using ScrutinMajoritaireProject;
using Xunit;

namespace SpecFlowScrutinMajoritaireProject.Steps;

[Binding]
public class ScrutinStepDifinitions
{
    private Scrutin _scrutin;
    private bool _estCloture;
    private Candidat _vainqueur;

    [Given(@"un scrutin avec l'identifiant (.*) est en premier tour")]
    public void GivenUnScrutinAvecLidentifiant(int idScrutin)
    {
        _scrutin = new Scrutin(idScrutin);
        _scrutin.estSecondTour.Should().Be(false);
    }

    [When(@"je consulte l'état de clôture du scrutin")]
    public void WhenJeConsulteLetatDeClotureDuScrutin()
    {
        _estCloture = _scrutin.estCloture;
    }

    [Then(@"le statut de clôture du scrutin devrait être (.*) \(false = non clôturé \| true = clôturé\)")]
    public void ThenLeStatutDeClotureDuScrutinDevraitEtreFalseFalseNonClotureTrueCloture(bool statutDeCloture)
    {
        this._estCloture.Should().Be(statutDeCloture);
    }

    [Given(@"un candidat avec l'identifiant (.*) et le nom ""(.*)"" et la date d'enregistrement (.*)")]
    public void GivenUnCandidatAvecLidentifiantEtLeNom(int idCandidat, string nomCandidat, String dateEnregistrement)
    {
        var candidat = new Candidat(idCandidat, nomCandidat, DateTime.Parse(dateEnregistrement));
        _scrutin.AjouterCandidat(candidat);
    }

    [When(@"vote (.*) fois pour le candidat avec l'identifiant (.*)")]
    public void WhenJeVoteFoisPourLeCandidatAvecLidentifiant(int nombreDeVotes, int idCandidat)
    {
        for (int i = 0; i < nombreDeVotes; i++)
        {
            _scrutin.Voter(idCandidat);
        }
    }

    [When(@"je clôture le scrutin avec l'identifiant (.*)")]
    public void WhenJeClotureLeScrutinAvecLidentifiant(int idScrutin)
    {
        _scrutin.Cloture();
        _scrutin.estCloture.Should().Be(true);
    }

    [Then(@"le vainqueur du scrutin avec l'identifiant (.*) devrait être ""(.*)"" avec identifiant (.*)")]
    public void ThenLeVainqueurDuScrutinAvecLidentifiantDevraitEtre(int idScrutin, string nomCandidat, int idCandidat)
    {
        List<Candidat> _vainqueur = _scrutin.ObtenirVainqueur();
        _vainqueur.Count.Should().Be(1);
        _vainqueur[0].Nom.Should().Be(nomCandidat);
        _vainqueur[0].Id.Should().Be(idCandidat);
    }

    [Then(
        @"les résultats du scrutin avec l'identifiant (.*) devraient être ""(.*)"" avec (.*)% des voix et ""(.*)"" avec (.*)% des voix")]
    public void ThenLesResultatsDuScrutinAvecLidentifiantDevraientEtreAvecDesVoixEtAvecDesVoix(
        int idScrutin,
        string nomCandidat1, double pCandidat1,
        string nomCandidat2, double pCandidat2)
    {
        _scrutin.Candidats.Count.Should().Be(2);

        Dictionary<Candidat, double> resultats = _scrutin.Resultats();

        var candidat1Obj = _scrutin.Candidats.FirstOrDefault(c => c.Nom == nomCandidat1);
        var candidat2Obj = _scrutin.Candidats.FirstOrDefault(c => c.Nom == nomCandidat2);

        resultats[candidat1Obj].Should().Be(pCandidat1);
        resultats[candidat2Obj].Should().Be(pCandidat2);
    }

    [Then(@"afficher les resultat ""(.*)""")]
    public void ThenAfficherLesResultat(String expectedResult)
    {
        StringWriter output = new StringWriter();
        Console.SetOut(output);
        _scrutin.afficherResultat();

        string actualOutput = output.ToString().Replace("\n", "\\n");
        expectedResult = expectedResult.Replace("\n", "\\n");

        byte[] expectedBytes = Encoding.UTF8.GetBytes(expectedResult);
        byte[] actualBytes = Encoding.UTF8.GetBytes(actualOutput);

        Assert.Equal(expectedResult, actualOutput);
    }

    [Then(
        @"nous avons pas de candidat avec plus de 50% des voix les candidats pour second tour sont ""(.*)"" et ""(.*)""")]
    public void ThenNousAvonsPasDeCandidatAvecPlusDeDesVoixLesCandidatsPourSecondTourSontEt(
        string nomCandidat1,
        string nomCandidat2)
    {
        List<Candidat>? _vainqueur = _scrutin.ObtenirVainqueur();
        _vainqueur.Count.Should().Be(2);
        _vainqueur[0].Nom.Should().Be(nomCandidat1);
        _vainqueur[1].Nom.Should().Be(nomCandidat2);
    }

    [Given(@"un scrutin avec l'identifiant (.*) est en second tour")]
    public void GivenUnScrutinAvecLidentifiantEstEnSecondTour(int p0)
    {
        // ScenarioContext.StepIsPending();
        // _scrutin.estSecondTour.Should().Be(true);
        _scrutin.estSecondTour.Should().Be(true);
    }
}