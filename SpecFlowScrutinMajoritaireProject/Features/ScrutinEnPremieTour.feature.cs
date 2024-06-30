﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowScrutinMajoritaireProject.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ScrutinEnPremieTourFeature : object, Xunit.IClassFixture<ScrutinEnPremieTourFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ScrutinEnPremieTour.feature"
#line hidden
        
        public ScrutinEnPremieTourFeature(ScrutinEnPremieTourFeature.FixtureData fixtureData, SpecFlowScrutinMajoritaireProject_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ScrutinEnPremieTour", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Vérifier si le scrutin non clôturé")]
        [Xunit.TraitAttribute("FeatureTitle", "ScrutinEnPremieTour")]
        [Xunit.TraitAttribute("Description", "Vérifier si le scrutin non clôturé")]
        public virtual void VerifierSiLeScrutinNonCloture()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Vérifier si le scrutin non clôturé", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 3
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
        testRunner.Given("créer un scrutin avec l\'identifiant 1 est en premier tour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
        testRunner.When("je consulte l\'état de clôture du scrutin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 6
        testRunner.Then("le statut de clôture du scrutin devrait être false (false = non clôturé | true = " +
                        "clôturé)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Obtenir et afficher les résultats du scrutin en premier tour")]
        [Xunit.TraitAttribute("FeatureTitle", "ScrutinEnPremieTour")]
        [Xunit.TraitAttribute("Description", "Obtenir et afficher les résultats du scrutin en premier tour")]
        public virtual void ObtenirEtAfficherLesResultatsDuScrutinEnPremierTour()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Obtenir et afficher les résultats du scrutin en premier tour", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
        testRunner.Given("créer un scrutin avec l\'identifiant 1 est en premier tour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
        testRunner.And("un candidat avec l\'identifiant 1 et le nom \"Candidat 1\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:00:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
        testRunner.And("un candidat avec l\'identifiant 2 et le nom \"Candidat 2\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:01:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
        testRunner.When("vote 22 fois pour le candidat avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
        testRunner.And("vote 1 fois pour le candidat avec l\'identifiant 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
        testRunner.And("je clôture le scrutin avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
        testRunner.And("afficher les resultat \"Candidat 1 : 22 voix (95.65%)\\nCandidat 2 : 1 voix (4.35%)" +
                        "\\n\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
        testRunner.Then("les résultats du scrutin avec l\'identifiant 1 devraient être \"Candidat 1\" avec 95" +
                        ".65% des voix et \"Candidat 2\" avec 4.35% des voix", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
        testRunner.And("le vainqueur du scrutin avec l\'identifiant 1 devrait être \"Candidat 1\" avec ident" +
                        "ifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Un candidat obtient plus de 50% des voix")]
        [Xunit.TraitAttribute("FeatureTitle", "ScrutinEnPremieTour")]
        [Xunit.TraitAttribute("Description", "Un candidat obtient plus de 50% des voix")]
        public virtual void UnCandidatObtientPlusDe50DesVoix()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Un candidat obtient plus de 50% des voix", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 19
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
        testRunner.Given("créer un scrutin avec l\'identifiant 1 est en premier tour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
        testRunner.And("un candidat avec l\'identifiant 1 et le nom \"Candidat 1\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:00:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
        testRunner.And("un candidat avec l\'identifiant 2 et le nom \"Candidat 2\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:01:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
        testRunner.When("vote 30 fois pour le candidat avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
        testRunner.And("vote 20 fois pour le candidat avec l\'identifiant 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
        testRunner.And("je clôture le scrutin avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
        testRunner.Then("le vainqueur du scrutin avec l\'identifiant 1 devrait être \"Candidat 1\" avec ident" +
                        "ifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Nous avons pas de candidat avec plus de 50% des voix, egalité entre 2eme et 3eme " +
            "est gérée avec la date d\'enregistrement")]
        [Xunit.TraitAttribute("FeatureTitle", "ScrutinEnPremieTour")]
        [Xunit.TraitAttribute("Description", "Nous avons pas de candidat avec plus de 50% des voix, egalité entre 2eme et 3eme " +
            "est gérée avec la date d\'enregistrement")]
        public virtual void NousAvonsPasDeCandidatAvecPlusDe50DesVoixEgaliteEntre2EmeEt3EmeEstGereeAvecLaDateDenregistrement()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nous avons pas de candidat avec plus de 50% des voix, egalité entre 2eme et 3eme " +
                    "est gérée avec la date d\'enregistrement", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 31
        testRunner.Given("créer un scrutin avec l\'identifiant 1 est en premier tour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
        testRunner.And("un candidat avec l\'identifiant 1 et le nom \"Candidat 1\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:00:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
        testRunner.And("un candidat avec l\'identifiant 2 et le nom \"Candidat 2\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:02:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
        testRunner.And("un candidat avec l\'identifiant 3 et le nom \"Candidat 3\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:03:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
        testRunner.When("vote 25 fois pour le candidat avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
        testRunner.And("vote 30 fois pour le candidat avec l\'identifiant 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
        testRunner.And("vote 25 fois pour le candidat avec l\'identifiant 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
        testRunner.And("je clôture le scrutin avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
        testRunner.Then("nous avons pas de candidat avec plus de 50% des voix les candidats pour second to" +
                        "ur sont \"Candidat 1\" et \"Candidat 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Nous avons 4 candidats avec le même nombre de voix")]
        [Xunit.TraitAttribute("FeatureTitle", "ScrutinEnPremieTour")]
        [Xunit.TraitAttribute("Description", "Nous avons 4 candidats avec le même nombre de voix")]
        public virtual void NousAvons4CandidatsAvecLeMemeNombreDeVoix()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nous avons 4 candidats avec le même nombre de voix", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 43
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 44
        testRunner.Given("créer un scrutin avec l\'identifiant 1 est en premier tour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 45
        testRunner.And("un candidat avec l\'identifiant 1 et le nom \"Candidat 1\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:05:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
        testRunner.And("un candidat avec l\'identifiant 2 et le nom \"Candidat 2\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:01:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
        testRunner.And("un candidat avec l\'identifiant 3 et le nom \"Candidat 3\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:02:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
        testRunner.And("un candidat avec l\'identifiant 4 et le nom \"Candidat 4\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:03:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
        testRunner.When("vote 20 fois pour le candidat avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
        testRunner.And("vote 20 fois pour le candidat avec l\'identifiant 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
        testRunner.And("vote 20 fois pour le candidat avec l\'identifiant 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
        testRunner.And("vote 20 fois pour le candidat avec l\'identifiant 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
        testRunner.And("je clôture le scrutin avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
        testRunner.Then("nous avons pas de candidat avec plus de 50% des voix les candidats pour second to" +
                        "ur sont \"Candidat 2\" et \"Candidat 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Voter pour un candidat lorque scrutin est clôturé")]
        [Xunit.TraitAttribute("FeatureTitle", "ScrutinEnPremieTour")]
        [Xunit.TraitAttribute("Description", "Voter pour un candidat lorque scrutin est clôturé")]
        public virtual void VoterPourUnCandidatLorqueScrutinEstCloture()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Voter pour un candidat lorque scrutin est clôturé", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 58
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 59
        testRunner.Given("créer un scrutin avec l\'identifiant 1 est en premier tour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 60
        testRunner.And("un candidat avec l\'identifiant 1 et le nom \"Candidat 1\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:00:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
        testRunner.And("un candidat avec l\'identifiant 2 et le nom \"Candidat 2\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:01:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
        testRunner.When("vote 11 fois pour le candidat avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
        testRunner.And("vote 11 fois pour le candidat avec l\'identifiant 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
        testRunner.And("je clôture le scrutin avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
        testRunner.Then("obtient une erreur \"Scrutin déjà cloturé\" lorque vote 11 fois pour le candidat av" +
                        "ec l\'identifiant 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Obtenir les resultat lorsque scrutin est non clôturé")]
        [Xunit.TraitAttribute("FeatureTitle", "ScrutinEnPremieTour")]
        [Xunit.TraitAttribute("Description", "Obtenir les resultat lorsque scrutin est non clôturé")]
        public virtual void ObtenirLesResultatLorsqueScrutinEstNonCloture()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Obtenir les resultat lorsque scrutin est non clôturé", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 68
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 69
        testRunner.Given("créer un scrutin avec l\'identifiant 1 est en premier tour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 70
        testRunner.And("un candidat avec l\'identifiant 1 et le nom \"Candidat 1\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:00:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
        testRunner.And("un candidat avec l\'identifiant 2 et le nom \"Candidat 2\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:01:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
        testRunner.When("vote 22 fois pour le candidat avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
        testRunner.And("vote 1 fois pour le candidat avec l\'identifiant 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
        testRunner.Then("obtient une erreur \"Scrutin non cloturé\" lorque je demande les résultats du scrut" +
                        "in avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Obtenir les resultat lorsque scrutin avec aucun vote")]
        [Xunit.TraitAttribute("FeatureTitle", "ScrutinEnPremieTour")]
        [Xunit.TraitAttribute("Description", "Obtenir les resultat lorsque scrutin avec aucun vote")]
        public virtual void ObtenirLesResultatLorsqueScrutinAvecAucunVote()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Obtenir les resultat lorsque scrutin avec aucun vote", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 76
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 77
        testRunner.Given("créer un scrutin avec l\'identifiant 1 est en premier tour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 78
        testRunner.And("un candidat avec l\'identifiant 1 et le nom \"Candidat 1\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:00:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
        testRunner.And("un candidat avec l\'identifiant 2 et le nom \"Candidat 2\" et la date d\'enregistreme" +
                        "nt 2022-01-01 12:01:00 PM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
        testRunner.When("je clôture le scrutin avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
        testRunner.Then("obtient une erreur \"Aucun vote n\'a été enregistré.\" lorque je demande les résulta" +
                        "ts du scrutin avec l\'identifiant 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ScrutinEnPremieTourFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ScrutinEnPremieTourFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
