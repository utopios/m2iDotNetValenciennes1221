/**
 * Les opérateurs arithmétiques
 */

// Déclaration de plusieurs variable à la volée
var nb1=10, nb2=5, resultat;

// L'addition
resultat = nb1 + nb2;
console.log(nb1+" + "+nb2+" = "+resultat);

// La soustraction
resultat = nb1 - nb2;
console.log(nb1+" - "+nb2+" = "+resultat);

// La multiplication
resultat = nb1 * nb2;
console.log(nb1+" * "+nb2+" = "+resultat);

// La division
resultat = nb1 / nb2;
console.log(nb1+" / "+nb2+" = "+resultat);

// L'opérateur modulo
resultat = nb1 % nb2;
console.log(nb1+" % "+nb2+" = "+resultat);


/**
 * Les écritures simplifiées
 */

// L'addition
nb1 = nb1 + 5
console.log("Nb1 vaut : "+nb1);
// peut s'ecrire
nb1 += 5;
console.log("Nb1 vaut : "+nb1);

// La soustraction
nb1 = nb1 - 5
console.log("Nb1 vaut : "+nb1);
// peut s'ecrire
nb1 -= 5;
console.log("Nb1 vaut : "+nb1);

// La multiplication
nb1 = nb1 * 5
console.log("Nb1 vaut : "+nb1);
// peut s'ecrire
nb1 *= 5;
console.log("Nb1 vaut : "+nb1);

// La division
nb1 = nb1 / 5
console.log("Nb1 vaut : "+nb1);
// peut s'ecrire
nb1 /= 5;
console.log("Nb1 vaut : "+nb1);


/**
 * Les opérateurs d'incrémentation et décrémentation
 */

// Incrémentation
nb1 = nb1 + 1;
// Peur se simplifier en
nb1 += 1;
// Avec l'opérateur d'incrementation
nb1++;

// Décrémentation
nb1 = nb1 - 1;
// Peur se simplifier en
nb1 -= 1;
// Avec l'opérateur d'incrementation
nb1--;

// Positionnement de l'opérateur d'incrémentation

// Affiche la valeur avant incrémentation
nb1 = 1;
console.log("nb1 = "+nb1);
console.log(nb1++);
console.log("nb1 = "+nb1);

// Affiche la valeur après incrémentation
nb1 = 1;
console.log("nb1 = "+nb1);
console.log(++nb1);
console.log("nb1 = "+nb1);