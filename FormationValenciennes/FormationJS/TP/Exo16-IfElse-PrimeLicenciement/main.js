/**
 * Exercice16 - IfElse - Prime de licenciement
 */
// Déclaration variable
let indemnite = 0;

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Récupération et stockage des saisie utilisateur
let salaire = prompt("Veuillez saisir le dernier salaire :");
let anciennete = prompt("Veuillez saisir l'ancienneté' :");
let age = prompt("Veuillez saisir l'age du salarié' :");

// Etablissement Structure If() pour calculer le montant de la prime
// Prime liée à l'encienneté
if (anciennete >= 1 && anciennete <= 10) {
    indemnite += anciennete * salaire / 2;
}
if (anciennete > 10) {
    indemnite += 10 * salaire / 2;
    indemnite += (anciennete - 10) * salaire;
}
// Calcul de la primeliée à l'age
if (anciennete >= 1 && age > 45) {
    indemnite += (age < 50) ? 2 * salaire : 5 * salaire;
}


// Injection du résultat dans l'element HTML .result
result.innerHTML = `Le montant de l'indemnité pour un salarié ayant un salaire de <b>${salaire}€</b> et <b>${age} ans</b>, avec <b>${anciennete}</b> années d'ancienneté s'élève à <b>${indemnite}€</b>`;