/**
 *  Exercice 1 => Variables & Operateurs
 */

// Création des constante pour la récuperation des elements HTML
const result = document.querySelector('#result');

// Déclaration des variables
let prenom,
    nom,
    resultat,
    affichage;

// Ajout du titre de l'exo
affichage = "<h3>Addition de deux variables de type chaine (concaténation)</h3><br>"

// Récupration des saisies utilisateur
prenom = prompt("Saisir votre prénom : ");
affichage +=`Vous avez saisi : <b>${prenom}</b> <br>`;
nom = prompt("Saisir votre nom : ");
affichage +=`Vous avez saisi : <b>${nom}</b> <br>`;

// Concaténation du nom et du prénom
resultat = prenom + " " + nom;

// Rédaction de l'affichage du résultat
affichage += `Bonjour <b>${prenom}</b> <b>${nom}</b> , le nom complet =><b> ${resultat}</b><hr>`

// Affichage des résultats
//alert(affichage);

result.innerHTML=affichage;



