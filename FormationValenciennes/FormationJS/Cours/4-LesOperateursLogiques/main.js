

/**
 * Les Opérateurs logiques
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

/*
    L'opérateur logique && = ET
*/

// Exemple de vérification si un nombre se situe dans un range de valeurs
var resultat;
var nb = Number(prompt("Veuillez saisir un nombre entre 1 et 3"));
if ((nb >= 1) && (nb <= 3)) {
    resultat=`Le nombre ${nb} est bien supérieur ou égal à 1 ET inférieur ou égal à 3.`;
}
else{
    resultat=`Le nombre ${nb} n'est pas supérieur ou égal à 1 ET inférieur ou égal à 3.`;
}
console.log(resultat);
result.innerHTML=resultat;


/*
    L'opérateur logique || = OU
*/

// Exemple de vérification si un nombre est inférieur à 1 ou supérieur à 3
resultat;
nb = Number(prompt("Veuillez saisir un nombre strictement inférieur à 1 ou supérieur à 3"));
if ((nb < 1) || (nb > 3)) {
    resultat=`Le nombre ${nb} est bien inférieur à 1 OU supérieur à 3.`;
}
else{
    resultat=`Le nombre ${nb} n'est bien pas inférieur à 1 OU supérieur à 3.`;
    
}
console.log(resultat);
result.innerHTML+="<br>"+resultat;

/*
    L'opérateur logique ! = Non (Contraire de)
*/

// Exemple de vérification si un nombre est inférieur à 1 ou supérieur à 3
var pause = false;

if (!pause) {
    resultat=`Ce n'est pas l'heure de la pause...`;    
}
else{
    resultat=`C'est l'heure de la pause!`;    
}
console.log(resultat);
result.innerHTML+="<br>"+resultat;