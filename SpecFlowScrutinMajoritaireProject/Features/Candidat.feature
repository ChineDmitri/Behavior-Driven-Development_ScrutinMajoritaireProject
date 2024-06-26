Feature: Candidat

    Scenario: Créer un candidat
        Given je n'ai aucun candidat
        When j'ajoute un candidat avec les informations suivantes :
          | Id | Nom        | DateEnregistrement     |
          | 1  | Candidat 1 | 2022-01-01 12:00:00 PM |
          | 2  | Candidat 2 | 2022-01-01 12:01:00 PM |
          | 3  | Candidat 3 | 2022-01-01 12:02:00 PM |
        Then le candidat avec l'identifiant 1 devrait avoir le nom "Candidat 1" et la date d'enregistrement 2022-01-01 12:00:00 PM
        And le candidat avec l'identifiant 2 devrait avoir le nom "Candidat 2" et la date d'enregistrement 2022-01-01 12:01:00 PM
        And le candidat avec l'identifiant 3 devrait avoir le nom "Candidat 3" et la date d'enregistrement 2022-01-01 12:02:00 PM

    Scenario: Recevoir un vote pour le candidat
        Given j'ai un candidat avec l'identifiant 1 et le nom "Candidat 1"
        When je vote le candidat avec l'identifiant 1
        Then j'ai incrimenté le nombre de vote du candidat avec l'identifiant 1