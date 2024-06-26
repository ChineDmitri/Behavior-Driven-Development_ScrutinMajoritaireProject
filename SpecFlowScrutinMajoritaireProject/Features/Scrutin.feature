Feature: Scrutin

    Scenario: Vérifier si le scrutin non clôturé
        Given un scrutin avec l'identifiant 1
        When je consulte l'état de clôture du scrutin
        Then le statut de clôture du scrutin devrait être false (false = non clôturé | true = clôturé)

    Scenario: Un candidat obtient plus de 50% des voix
        Given un scrutin avec l'identifiant 1
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        When vote 30 fois pour le candidat avec l'identifiant 1
        And vote 20 fois pour le candidat avec l'identifiant 2
        And je clôture le scrutin avec l'identifiant 1
        Then le vainqueur du scrutin avec l'identifiant 1 devrait être "Candidat 1" avec identifiant 1
        
    Scenario: Obtenir et afficher les résultats du scrutin
        Given un scrutin avec l'identifiant 1
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        When vote 22 fois pour le candidat avec l'identifiant 1
        And vote 1 fois pour le candidat avec l'identifiant 2
        Then les résultats du scrutin avec l'identifiant 1 devraient être "Candidat 1" avec 95.65% des voix et "Candidat 2" avec 4.35% des voix
        And afficher les resultat "Candidat 1 : 95.65%\nCandidat 2 : 4.35%\n"
        
    Scenario: Nous avons pas de candidat avec plus de 50% des voix
        Given un scrutin avec l'identifiant 1
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:02:00 PM
        And un candidat avec l'identifiant 3 et le nom "Candidat 3" et la date d'enregistrement 2022-01-01 12:03:00 PM
        When vote 25 fois pour le candidat avec l'identifiant 1
        And vote 30 fois pour le candidat avec l'identifiant 2
        And vote 25 fois pour le candidat avec l'identifiant 3
        And je clôture le scrutin avec l'identifiant 1
        Then nous avons pas de candidat avec plus de 50% des voix les candidats pour second tour sont "Candidat 2" et "Candidat 1"
