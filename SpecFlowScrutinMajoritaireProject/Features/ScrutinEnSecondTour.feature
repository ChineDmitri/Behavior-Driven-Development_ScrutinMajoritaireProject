Feature: ScrutinEnSecondTour

    Background:
        Given un scrutin avec l'identifiant 1 est en premier tour
        And un candidat avec l'identifiant 1 et le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And un candidat avec l'identifiant 2 et le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:02:00 PM
        And un candidat avec l'identifiant 3 et le nom "Candidat 3" et la date d'enregistrement 2022-01-01 12:03:00 PM
        When vote 25 fois pour le candidat avec l'identifiant 1
        And vote 30 fois pour le candidat avec l'identifiant 2
        And vote 25 fois pour le candidat avec l'identifiant 3
        And je clôture le scrutin avec l'identifiant 1
        Then nous avons pas de candidat avec plus de 50% des voix les candidats pour second tour sont "Candidat 2" et "Candidat 1"

    Scenario: Obtenir et afficher les résultats du scrutin en second tour
        Given un scrutin avec l'identifiant 1 est en second tour