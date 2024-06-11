using FluentAssertions;
using ScrutinMajoritaireProject;

namespace SpecFlowScrutinMajoritaireProject.Steps;

[Binding]
public class ScrutinStepDifinitions
{
    
    private Scrutin _scrutin;
    private bool _estCloture;
    private Candidat _vainqueur;

    [Given(@"un scrutin avec l'identifiant (.*)")]
    public void GivenUnScrutinAvecLidentifiant(int idScrutin)
    {
        _scrutin = new Scrutin(idScrutin);
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

    [Given(@"un candidat avec l'identifiant (.*) et le nom ""(.*)""")]
    public void GivenUnCandidatAvecLidentifiantEtLeNom(int idCandidat, string nomCandidat)
    {
        var candidat = new Candidat(idCandidat, nomCandidat);
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
        _scrutin.estCloture = true;
        _vainqueur = _scrutin.ObtenirVainqueur();
    }

    [Then(@"le vainqueur du scrutin avec l'identifiant (.*) devrait être ""(.*)"" avec identifiant (.*)")]
    public void ThenLeVainqueurDuScrutinAvecLidentifiantDevraitEtre(int idScrutin, string nomCandidat, int idCandidat)
    {
        _vainqueur.Nom.Should().Be(nomCandidat);
        _vainqueur.Id.Should().Be(idCandidat);
    }
}