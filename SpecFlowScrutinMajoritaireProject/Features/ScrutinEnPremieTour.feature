Feature: ScrutinEnPremieTour

    Scenario: Vérifier si le scrutin non clôturé
        Given créer un scrutin avec l'identifiant 1 est en premier tour
        When je consulte l'état de clôture du scrutin
        Then le statut de clôture du scrutin devrait être false (false = non clôturé | true = clôturé)

    Scenario: Obtenir et afficher les résultats du scrutin en premier tour
        Given créer un scrutin avec l'identifiant 1 est en premier tour
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        When vote 22 fois pour le candidat avec l'identifiant 1
        And vote 1 fois pour le candidat avec l'identifiant 2
        And je clôture le scrutin avec l'identifiant 1
        And afficher les resultat "Candidat 1 : 22 voix (95.65%)\nCandidat 2 : 1 voix (4.35%)\n"
        Then les résultats du scrutin avec l'identifiant 1 devraient être "Candidat 1" avec 95.65% des voix et "Candidat 2" avec 4.35% des voix
        And le vainqueur du scrutin avec l'identifiant 1 devrait être "Candidat 1" avec identifiant 1

    Scenario: Un candidat obtient plus de 50% des voix
        Given créer un scrutin avec l'identifiant 1 est en premier tour
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        When vote 30 fois pour le candidat avec l'identifiant 1
        And vote 20 fois pour le candidat avec l'identifiant 2
        And je clôture le scrutin avec l'identifiant 1
        # affichager de console fontion que sur test unique
        # And afficher les resultat "Candidat 1 : 30 voix (60%)\nCandidat 2 : 20 voix (40%)\n"
        Then le vainqueur du scrutin avec l'identifiant 1 devrait être "Candidat 1" avec identifiant 1

    Scenario: Nous avons pas de candidat avec plus de 50% des voix, egalité entre 2eme et 3eme est gérée avec la date d'enregistrement
        Given créer un scrutin avec l'identifiant 1 est en premier tour
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:02:00 PM
        And un candidat avec l'identifiant 3 et le nom "Candidat 3" et la date d'enregistrement 2022-01-01 12:03:00 PM
        When vote 25 fois pour le candidat avec l'identifiant 1
        And vote 30 fois pour le candidat avec l'identifiant 2
        And vote 25 fois pour le candidat avec l'identifiant 3
        And je clôture le scrutin avec l'identifiant 1
        # affichager de console fontion que sur test unique
        # And afficher les resultat "Candidat 1 : 25 voix (31.25%)\nCandidat 2 : 30 voix (37.5%)\nCandidat 3 : 25 voix (31.25%)\n"
        Then nous avons pas de candidat avec plus de 50% des voix les candidats pour second tour sont "Candidat 1" et "Candidat 2"

    Scenario: Nous avons 4 candidats avec le même nombre de voix
        Given créer un scrutin avec l'identifiant 1 est en premier tour
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:05:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        And un candidat avec l'identifiant 3 et le nom "Candidat 3" et la date d'enregistrement 2022-01-01 12:02:00 PM
        And un candidat avec l'identifiant 4 et le nom "Candidat 4" et la date d'enregistrement 2022-01-01 12:03:00 PM
        When vote 20 fois pour le candidat avec l'identifiant 1
        And vote 20 fois pour le candidat avec l'identifiant 2
        And vote 20 fois pour le candidat avec l'identifiant 3
        And vote 20 fois pour le candidat avec l'identifiant 4
        And je clôture le scrutin avec l'identifiant 1
        # affichager de console fontion que sur test unique
        # And afficher les resultat "Candidat 1 : 20 voix (25%)\nCandidat 2 : 20 voix (25%)\nCandidat 3 : 20 voix (25%)\nCandidat 4 : 20 voix (25%)\n"
        Then nous avons pas de candidat avec plus de 50% des voix les candidats pour second tour sont "Candidat 2" et "Candidat 3"

    Scenario: Voter pour un candidat lorque scrutin est clôturé
        Given créer un scrutin avec l'identifiant 1 est en premier tour
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        When vote 11 fois pour le candidat avec l'identifiant 1
        And vote 11 fois pour le candidat avec l'identifiant 2
        And je clôture le scrutin avec l'identifiant 1
        Then obtient une erreur "Scrutin déjà cloturé" lorque vote 11 fois pour le candidat avec l'identifiant 2
        
        
    Scenario: Obtenir les resultat lorsque scrutin est non clôturé
        Given créer un scrutin avec l'identifiant 1 est en premier tour
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        When vote 22 fois pour le candidat avec l'identifiant 1
        And vote 1 fois pour le candidat avec l'identifiant 2
        Then obtient une erreur "Scrutin non cloturé" lorque je demande les résultats du scrutin avec l'identifiant 1
        
    Scenario: Obtenir les resultat lorsque scrutin avec aucun vote
        Given créer un scrutin avec l'identifiant 1 est en premier tour
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        When je clôture le scrutin avec l'identifiant 1
        Then obtient une erreur "Aucun vote n'a été enregistré." lorque je demande les résultats du scrutin avec l'identifiant 1