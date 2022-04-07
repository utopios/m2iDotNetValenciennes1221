/**
 * Les tableaux numériques (car on accède à une case par sa position/index)
 */

// Déclaration d'un tableau numérique (2 façons de faire)
var monTableau= [];
var monTableau = new Array();

// Affecter une valeur à un tableau numérique
monTableau[0] = "Pomme"; // Affectation de Pomme en position 0 du tableau

monTableau[1] = "Poire"; // Affectation de Poire en position 1 du tableau

// Afficher le contenu d'un tableau numérique
console.table(monTableau);

// Affichage d'une valeurs à un index
console.log(monTableau[0]);
console.log(monTableau[1]);

// Déclaration et affectation de valeur en même temps
var legumes=["Carotte","Choux","Haricot"];
// Equivaut à : var legumes = new Array("Carotte","Choux","Haricot");

// Réafecter une valeur dans le tableau
console.log(legumes[2]);
legumes[2]="Epinard";
console.log(legumes[2]);

// récuprérer la taille d'un tableau
console.log(legumes.length);

// Ajouter un ou plusieurs éléments à un tableau
legumes.push("Courgette");
console.log(legumes.length);
legumes.push("Potiron","Aubergines");
console.log(legumes.length);
console.table(legumes);

// Retirer le dernier élément d'un tableau [pop]
legumes.pop();
console.table(legumes);

// Retirer le premier element d'un tableau [shift()]
legumes.shift();
console.table(legumes);

// On rajouter des éléments pour faire des doublons
legumes.push("Courgette");
console.log(legumes.length);
legumes.push("Potiron","Aubergines");
console.log(legumes.length);
console.table(legumes);

// Retirer un ou plusieurs éléments d'un tableau à un index donné [splice(index,nb)]
legumes.splice(2,2);
console.table(legumes);

// Ajouter des éléments à une position donnée [splice(index, nb, value)}
legumes.splice(2,0,"Concombre");
console.table(legumes);