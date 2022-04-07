/**
 * Les nouveautés de l'ES6 (Implémentation de la spécification ECMA6)
 */

/**
 * let
 * 
 * Jusqu'à présent nous utilisions var pour déclarer les variables
 * Maintenant nous utiliserons let, voyons pourquoi.
 */

console.log("---------- Nouveauté ES6 ----------");
console.log("---------- Mot clé let => remplace var ----------");

// On demande d'afficher les variables avant leur déclaration
console.log(prenomVar); // Hoisting (remontée déclaration variable)=> Pour le navigateur, la variable existe, elle est non initialisée
//console.log(nomLet); // Provoque une erreur, variable non déclarée

var prenomVar = "Richard"; // undefine
let nomLet = "Gear"; // provoque une erreur


/**
 * const
 * 
 * Pour déclarer une constante
 */

const nbMax = 128;
console.log("nbMax vaut : " + nbMax / 2);
//nbMax=129; // Provoque une erreur => Assignement constant variable

const fruits = ["pomme"];
//fruits = ["Abricots","Poire"];// Provoque une erreur => Assignement constant variable

fruits.push("Abricots", "Poire"); // Ici const garantit la structure de l'objet (tableau numérique ici)
console.table(fruits);


/**
 * Les nouvelles méthodes apportées par l'ES6 :
 * 
 * .forEach
 * .map()
 * .find()
 * .filter()
 * 
 */
console.log("---------- Les nouvelles Méthodes ES6 ----------");

// Déclaration d'un tableau de légumes (2 dimensions)

const vegetable = [
    {
        code: 1,
        name: "Carotte",
        price: 1.99
    },
    {
        code: 2,
        name: "Poivron Vert",
        price: 4.99
    },
    {
        code: 3,
        name: "Poivron Rouge",
        price: 4.99
    },
    {
        code: 4,
        name: "Haricot Vert",
        price: 3.89
    },
    {
        code: 5,
        name: "Courgette",
        price: 2.5
    }
];

console.table(vegetable);

// .Foreach
console.log("\n---------- Parcours du tableau Vegetables avec .foreach(vegetable) ----------");
// Proche du for...of
vegetable.forEach(function (vegetable) {
    console.log(vegetable.name);
});
console.log("\n---------- Parcours du tableau Vegetables avec .foreach(vegetable,index) ----------");

vegetable.forEach(function (vegetable, index) {
    console.log((index + 1) + " : " + vegetable.name);
});


// .map()
console.log("\n---------- Parcours du tableau Vegetables avec .map(function(){}) ----------");

const listVegetables = vegetable.map(function (vegetable) {
    return vegetable.name;
});
console.table(listVegetables); // Map retourne un nouveau tableau (indexé...)

// .find() => Retourne le premier élément
console.log("\n---------- Parcours du tableau Vegetables avec .find('Poivron') ----------");

const poivron = vegetable.find(function (vegetable) {
    return vegetable.name.includes("Poivron");
})

console.log(poivron);

// .filter() => retourne un tableaux contenant les n occurences
const poivrons = vegetable.filter(function (vegetable) {
    return vegetable.name.includes("Poivron");
})

console.table(poivrons);

/**
 * Les litéraux de gabarit
 * 
 * Nouvelle possibilité de concaténer les variables dans les
 * chaines de caractère à l'aide du nouveau caractère de templating " ` " => backtic (accent grave)
 */
console.log("\n---------- Les litéraux de gabarit ----------");

let prenom = "jean";
let nom = "valjean";

console.log("Bonjour " + prenom + " " + nom);
console.log(`Bonjour ${prenom} ${nom}, tu vas bien?`);

/**
 * Destructuring
 * 
 * Accès simplifié aux élément d'un tableau, d'un objet
 */
console.log("\n---------- Destructuring ----------\n");

// AVEC DES TABLEAUX
const tabNum = [1, 2, 3];
console.table(tabNum);
// En ES5
// const a = tabNum[0];
// const b = tabNum[1];

// // En ES6 avec le destructuring nous pouvons l'ecrire :
 const [a, b] = tabNum;
 console.log(a);
 console.log(b);

// Autre exemple avec un tableau associatif
const user = {
    firstname: "Jean",
    lastname: "Dupond",
    age: 35,
    active: false
};

// AVEC DES OBJETS
// En ES5
//var firstname = user.firstname;
//var lastname = user.lastname;

// En ES6 avec le destructuring
const { firstname, lastname } = user;
console.log(`Avec destructuring de l'objet user : ${firstname} ${lastname}`);


// AVEC DES FONCTIONS
// // Fonction sans destructuring
// function getFullName(user){
//     return `${user.firstname} ${user.lastname}`;
// }
// console.log("Sans destructuring de méthode getFullName() : "+getFullName(user));

// fonction avec destructuring
function getFullName({ firstname, lastname }) {
    return `${firstname} ${lastname}`;
}
console.log("Avec destructuring de méthode getFullName() : " + getFullName(user));


/**
 * LES FONCTIONS FLECHEES --> Arrow Function
 * 
 * Pour écrire une fonction fléchée nous allons utiliser un opérateur
 * que l'on appelle fat arrow =>
 */
console.log("\n---------- Arrow Function ----------\n");

// Cas 1
// Sans paramètres
let test = function () {
    return "Toto";
}
// Equivalent à
test = () => {
    return "Toto";
}
// Simplification seulement si la fonction ne fait qu'un return
test = () => "Toto";
console.log(test);

// CAS 2
// Avec paramètres
let test2 = function (vegetable) {
    return vegetable.name;
}
// Equivalent à
test2 = (vegetable) => {
    return vegetable.name;
}
// Simplification seulement si la fonction ne fait qu'un return
test2 = (vegetable) => vegetable.name;
console.log(test2);

// CAS 3
// Avec au moins deux paramètres
let test3 = function (firstname, lastname) {
    return `${firstname} ${lastname}`;
}
// Equivalent à
test3 = (firstname, lastname) => {
    return `${firstname} ${lastname}`;
}
// Simplification seulement si la fonction ne fait qu'un return
test3 = (firstname, lastname) => `${firstname} ${lastname}`;

console.log(test3);

/**
 * rest operator
 * 
 * ...
 */
console.log("\n---------- rest Operator ----------\n");

//let haricot = vegetable[3]; // crée une réfernece au tableau car la copie n'en est pas vraiment une

let haricot = { ...vegetable[3] }; // une vrai copie car on vient de recréer le tableau associatif (objet) et donc dans ce cas pas de référence

console.log(haricot);
console.log(vegetable[3]);
console.table(vegetable);

haricot.price = 2.99;

console.log(haricot);
console.log(vegetable[3]); // Haricot à modifier le tableau car c'est une référence au tableau
console.table(vegetable);



// Autre exemple avec destructuring
const tabNum2 = [1, 2, 3];
console.table(tabNum2);
// En ES5
// var a = tabNum[0];
// var b = tabNum[1];

// En ES6 avec le destructuring nous pouvons l'ecrire :
const [c, ...d] = tabNum2;
console.log(c);
console.log(d);


/**
 * Valeurs par défaut pour les paramètres d'une fonction
 */
console.log("\n---------- Valeur par defaut ----------\n");

function Carre(nb = 10) {
    return nb * nb;
}

console.log(Carre(5)); // 25
console.log("Default params : " + Carre()); // 100


/**
 * Classes
 * 
 * L'ES6 introduit les classes
 */
console.log("\n---------- Création d'une Class Personne (création de type) ----------\n");

class Personne {

    // c'est le moule permettant de réaliser des objets Developpeur
    constructor(firstname, lastname) {
        this.firstname = firstname;
        this.lastname = lastname;
    }

    getFullName() {
        return `${this.firstname} ${this.lastname}`;
    }
}

let personne1 = new Personne("George", "Clinton"); //Fais appel au constructeur
console.log(personne1.firstname);
console.log(personne1.getFullName());

/**
 * L'Héritage en Javascript
 * 
 * Comment procéder ? le mot clé extends suivi du nom de la classe que l'on veut hériter
 * 
 */

class Cadre extends Personne {

    // Ajouter le constructeur pour ajouter des propriétés
    constructor(firstname, lastname,job="Cadre") {
        super(firstname,lastname);
        this.job = job;
    }
    getJob() {
        return "Cadre";
    }

    display() {
        return `${super.getFullName()} - ${this.job}`;
    }
}

let cadre1 = new Cadre("Emmanuel", "Macron", "CEO");
console.log(cadre1.display());

