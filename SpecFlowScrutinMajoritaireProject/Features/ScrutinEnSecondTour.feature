Feature: ScrutinEnSecondTour

    Background:
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
        Then nous avons pas de candidat avec plus de 50% des voix les candidats pour second tour sont "Candidat 2" et "Candidat 1"

    Scenario: Un candidat obtient plus de 50% des voix en second tour
        Given un scrutin avec l'identifiant 1 est en second tour
        And il existe que deux candidats pour le second tour "Candidat 2" avec id 2 et "Candidat 1" avec id 1
        When vote 25 fois pour le candidat avec l'identifiant 1
        And vote 30 fois pour le candidat avec l'identifiant 2
        And je clôture le scrutin avec l'identifiant 1
        # affichager de console fontion que sur test unique
        # And afficher les resultat "Candidat 1 : 25 voix (45.45%)\nCandidat 2 : 30 voix (54.55%)\n"
        Then le candidat avec l'identifiant 2 a gagné le scrutin avec 30 des voix

    Scenario: Deux candidats ont le même nombre de voix en second tour
        Given un scrutin avec l'identifiant 1 est en second tour
        And il existe que deux candidats pour le second tour "Candidat 2" avec id 2 et "Candidat 1" avec id 1
        When vote 25 fois pour le candidat avec l'identifiant 1
        And vote 25 fois pour le candidat avec l'identifiant 2
        And je clôture le scrutin avec l'identifiant 1
        # affichager de console fontion que sur test unique
        # And afficher les resultat "Candidat 1 : 25 voix (50%)\nCandidat 2 : 25 voix (50%)\n"
        Then nous avons une égalité entre les deux candidats "Candidat 2" et "Candidat 1"