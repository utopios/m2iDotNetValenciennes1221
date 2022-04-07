/**
 * Les Fonctions en Javascript
 */

/** FONCTIONS NATIVES
 * // Afficher une alert à l'utilisateur (alert())
        alert("Coucou toi!");

   // Demander une saisie à l'utilisateur (prompt())
        var firstname = prompt("Quel est votre prénom ?");

        console.log(`Votre prénom est ${firstname}.`); // Affichage du prénom saisie
 */

/**
  * LES FONCTIONS NON NATIVES (USER)
  */

// Fonction sans paramètres
function hello(){
    // Lors de l'appel à cette fonction, les instruction ci-dessous seront exécutées
    console.log("Hello World");
}
// Appel à la fonction Hello()
hello();


// Fonction avec paramètres
function helloParams(firstname){
    // Affichage de la concatélantion dans la console
    console.log(`Hello ${firstname}!`);
}
// Appel à la fonction helloParams()
helloParams("jean");
var firstname = prompt("Quel est votre prénom ?");
helloParams(firstname);


// Fonction avec paramètres et un retour
function helloReturn(firstname){
    // Création d'une variable string et stockage concaténation text + variable
    var helloDisplay = `Hello ${firstname}!`;
    // Notre fonction retourne la variable helloDisplay au programme appellant
    return helloDisplay;
}
// Appel à la fonction helloParams()
var display = helloReturn("Jean-Eude");
console.log(display);
console.log(helloReturn("Jean-Eude"));
firstname = prompt("Quel est votre prénom ?");
display = helloReturn(firstname);
console.log(helloReturn(firstname));