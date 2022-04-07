/**
 * Les Boucles et Itération
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

/*
    La boucle Tant que : while
*/

// Exemple de boucle while : Compter jusqu'a 10
var i = 1;
while (i <= 10) {
    console.log(`La boucle While s'est éxécutée ${i} fois.`);
    i++;// Attention aux boucles infinies
}

/*
    La boucle Faire tant que : Do...while
*/

// Exemple de boucle do...while : Compter jusqu'a 10
//i = 1;
do {
    console.log(`La boucle Do...While s'est éxécutée ${i} fois.`);
    i++;// Attention aux boucles infinies
} while (i <= 10)

/*
    La boucle Pour : For (var intération ; Condition de sortie ; incrémentation)
*/

// Exemple de boucle do...while : Compter jusqu'a 10
i = 1;
for (i = 1; i <= 10; i++) {
    console.log(`La boucle For s'est éxécutée ${i} fois.`);
}

/**
 * EXERCICE
 * A partir du tableau numérique suivant :
 * 
 * var names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];
 * 
 * 1/ Gràce à une boucle for, afficher la liste des prenoms du tableau
 * 2/ Gràce à une boucle while, afficher la liste des prenoms du tableau
 */
 var names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];

 // 1 - boucle for

for (var j = 0; j < names.length; j++) {
    console.log(names[j]);
}

// 2 - boucle while

i = 0;
while(i < names.length) {
    console.log(names[i]);
    i++;
}

/*
    La boucle Pour...dans : For...in
*/
// Parfait pour les tableaux associtifs
var contact={
    nom:"Richard",
    prenom:"Pierre",
    telephone:"0123456789",
    email:"prichard@gmail.com"
}
// Exemple de boucle for...in 
for(var key in contact){
    //console.log(key);//Permet d'afficher les clés
    //console.log(contact[key]);//Permet d'afficher les infos pour chaque clé
    console.log(key +" : "+contact[key]);//Permet d'afficher les infos pour chaque clé
}

/*
    La boucle For...of
*/
// Utilisation du tableau numerique names de l'exercice précédent
for (j = 0; j < names.length; j++) {
    console.log(`La boucle for, names contient ${names[j]}`);
}
// Exemple de boucle for...of 
for(const name of names){
    console.log(`La boucle for..of, names contient ${name}`);//var is deprecated
}