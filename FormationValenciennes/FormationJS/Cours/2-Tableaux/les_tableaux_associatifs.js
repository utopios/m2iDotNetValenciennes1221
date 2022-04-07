/**
 * Les tableaux Associatifs
 */

// Déclaration d'un tableau associatif
var personne = {
    nom:"Dupont",
    prenom:"Jean",
    age:25
};

// Affichage du tableau personne
console.table(personne);
// Affichage de la valeur à la clé prenom
console.log(personne.prenom);
// Affichage de la valeur à la clé nom
console.log(personne["nom"]);