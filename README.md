# TP2 – Implémentation avec BDD à partir d’une User story : Calculer le Résultat d’un Scrutin Majoritaire

## Description

Ce projet permet de déterminer le vainqueur d'un scrutin majoritaire. Il calcule les résultats des votes et gère deux tours de scrutin si nécessaire. Le but est de fournir spécifications écrites en Gherkin.

## Fonctionnalités

- Calcul des résultats d'un scrutin majoritaire.
- Affichage du nombre de votes pour chaque candidat et du pourcentage correspondant.
- Gestion d'un deuxième tour si aucun candidat n'obtient plus de 50% des voix au premier tour.
- Détermination du vainqueur au deuxième tour ou indication d'une égalité.

## Critères d'acceptation

1. Pour obtenir un vainqueur, le scrutin doit être clôturé
2. Si un candidat obtient > 50% des voix, il est déclaré vainqueur du scrutin
3. On veut pouvoir afficher le nombre de votes pour chaque candidat et le pourcentage correspondant à la clôture du scrutin.
4. Si aucun candidat n'a plus de 50%, alors on garde les 2 candidats correspondants aux meilleurs pourcentages et il y aura un deuxième tour de scrutin
5. Il ne peut y avoir que deux tours de scrutins maximums
6. Sur le dernier tour de scrutin, le vainqueur est le candidat ayant le pourcentage de vote le plus élevé
7. Si on a une égalité sur un dernier tour, on ne peut pas déterminer de vainqueur

## Critères manquants
Vous aurez surement remarqué qu’ils manquent certains critères d’acceptances
pour pouvoir gérer tous les cas d’utilisations :
- **Gestion des égalités sur le 2ème et 3ème candidat sur un premier tour**
- **Gestion du vote blanc**

### Gestion des Égalités
En cas d'égalité entre le deuxième et le troisième candidat au premier tour, l'ordre d'enregistrement des candidats est pris en compte. Le candidat enregistré en premier aura une priorité plus haute et sera retenu pour le deuxième tour.
Si tous les candidats ont le même pourcentage de voix, l'ordre d'enregistrement est également pris en compte pour déterminer les deux candidat pour deuxème tour.

### Gestion du Vote Blanc
Les votes blancs ne sont pas comptabilisés et on déclanche exeption : *Aucun vote n'a été enregistré*.

