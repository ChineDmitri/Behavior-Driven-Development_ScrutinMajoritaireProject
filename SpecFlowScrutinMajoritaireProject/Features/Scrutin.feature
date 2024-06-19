Feature: Scrutin

    Scenario: Vérifier si le scrutin non clôturé
        Given un scrutin avec l'identifiant 1
        When je consulte l'état de clôture du scrutin
        Then le statut de clôture du scrutin devrait être false (false = non clôturé | true = clôturé)

    Scenario: Un candidat obtient plus de 50% des voix
        Given un scrutin avec l'identifiant 1
        And un candidat avec l'identifiant 1 et le nom "Candidat 1"
        And un candidat avec l'identifiant 2 et le nom "Candidat 2"
        When vote 30 fois pour le candidat avec l'identifiant 1
        And vote 20 fois pour le candidat avec l'identifiant 2
        And je clôture le scrutin avec l'identifiant 1
        Then le vainqueur du scrutin avec l'identifiant 1 devrait être "Candidat 1" avec identifiant 1