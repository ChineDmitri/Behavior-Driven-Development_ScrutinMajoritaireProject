using System.Text;
using FluentAssertions;
using ScrutinMajoritaireProject;
using Assert = Xunit.Assert;

namespace SpecFlowScrutinMajoritaireProject.Steps;

[Binding]
public class ScrutinStepDifinitions
{
    private Scrutin _scrutin;
    private bool _estCloture;
    private Candidat _vainqueur;

    [Given(@"créer un scrutin avec l'identifiant (.*) est en premier tour")]
    public void GivenUnScrutinAvecLidentifiant(int idScrutin)
    {
        _scrutin = new Scrutin(idScrutin);
        _scrutin.Id.Should().Be(idScrutin);
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

        Dictionary<Candidat, double> resultats = _scrutin.ResultatsParIdCandidat();

        var candidat1Obj = _scrutin.Candidats.FirstOrDefault(c => c.Nom == nomCandidat1);
        var candidat2Obj = _scrutin.Candidats.FirstOrDefault(c => c.Nom == nomCandidat2);

        resultats[candidat1Obj].Should().Be(pCandidat1);
        resultats[candidat2Obj].Should().Be(pCandidat2);
    }


    [Then(
        @"nous avons pas de candidat avec plus de 50% des voix les candidats pour second tour sont ""(.*)"" et ""(.*)""")]
    public void ThenNousAvonsPasDeCandidatAvecPlusDeDesVoixLesCandidatsPourSecondTourSontEt(
        string nomCandidat1,
        string nomCandidat2)
    {
        List<Candidat> vainqueur = _scrutin.ObtenirVainqueur();

        vainqueur.FirstOrDefault(v => v.Nom == nomCandidat1)
            .Should()
            .NotBeNull()
            .And
            .Match<Candidat>(c => c.Nom == nomCandidat1);
        vainqueur.FirstOrDefault(v => v.Nom == nomCandidat2)
            .Should()
            .NotBeNull()
            .And
            .Match<Candidat>(c => c.Nom == nomCandidat2);
    }

    [Given(@"un scrutin avec l'identifiant (.*) est en second tour")]
    public void GivenUnScrutinAvecLidentifiantEstEnSecondTour(int idScrutin)
    {
        _scrutin.Id.Should().Be(idScrutin);
        _scrutin.estSecondTour.Should().Be(true);
    }

    [When(@"afficher les resultat ""(.*)""")]
    public void ThenAfficherLesResultat(String expected)
    {
        Console.Clear();
        StringWriter output = new StringWriter();
        Console.SetOut(output);

        _scrutin.afficherResultat();

        Console.Clear();

        string actualOutput = output.ToString().Replace("\n", "\\n");
        string expectedResult = expected.Replace("\n", "\\n");

        byte[] expectedBytes = Encoding.UTF8.GetBytes(expectedResult);
        byte[] actualBytes = Encoding.UTF8.GetBytes(actualOutput);

        Assert.Equal(expectedResult, actualOutput);
        Assert.Equal(expectedBytes, actualBytes);
    }

    [Given(@"il existe que deux candidats pour le second tour ""(.*)"" avec id (.*) et ""(.*)"" avec id (.*)")]
    public void GivenIlExisteQueDeuxCandidatsPourLeSecondTourEt(
        string candidat1,
        int idCandidat1,
        string candidat2,
        int idCandidat2
    )
    {
        _scrutin.Candidats.Count.Should().Be(2);
        _scrutin.Candidats.FirstOrDefault(e => e.Nom == candidat1)
            .Should()
            .NotBeNull()
            .And
            .Match<Candidat>(c => c.Id == idCandidat1);
        _scrutin.Candidats.FirstOrDefault(e => e.Nom == candidat2)
            .Should()
            .NotBeNull()
            .And
            .Match<Candidat>(c => c.Id == idCandidat2);
    }

    [Then(@"le candidat avec l'identifiant (.*) a gagné le scrutin avec (.*) des voix")]
    public void ThenLeCandidatAvecLidentifiantAGagneLeScrutinAvecDesVoix(int idVainqueur, int nbVoix)
    {
        List<Candidat> vainqueur = _scrutin.ObtenirVainqueur();
        vainqueur.Count.Should().Be(1);
        vainqueur[0].Id.Should().Be(idVainqueur);
        vainqueur[0].NombreDeVoix.Should().Be(nbVoix);
    }

    [Then(@"nous avons une égalité entre les deux candidats ""(.*)"" et ""(.*)""")]
    public void ThenNousAvonsUneEgaliteEntreLesDeuxCandidatsEt(string nomCandidat1, string nomCandidat2)
    {
        List<Candidat> vainqueur = _scrutin.ObtenirVainqueur();
        vainqueur.Count.Should().Be(2);
        vainqueur.FirstOrDefault(v => v.Nom == nomCandidat1)
            .Should()
            .NotBeNull()
            .And
            .Match<Candidat>(c => c.Nom == nomCandidat1);
        vainqueur.FirstOrDefault(v => v.Nom == nomCandidat2)
            .Should()
            .NotBeNull()
            .And
            .Match<Candidat>(c => c.Nom == nomCandidat2);
        vainqueur[0].NombreDeVoix.Should().Be(vainqueur[1].NombreDeVoix);
    }

    [Then(@"obtient une erreur ""(.*)"" lorque vote (.*) fois pour le candidat avec l'identifiant (.*)")]
    public void ThenObtienUneErreurVoteFoisPourLeCandidatAvecLidentifiant(
        string actuelMsgError,
        int nombreDeVotes,
        int idCandidat
    )
    {
        for (int i = 0; i < nombreDeVotes; i++)
        {
            Exception e = Assert.Throws<InvalidOperationException>(
                () => _scrutin.Voter(idCandidat)
            );

            Assert.Equal(e.Message, actuelMsgError);
        }
    }
}