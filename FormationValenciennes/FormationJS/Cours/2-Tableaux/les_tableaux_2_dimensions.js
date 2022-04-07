/**
 * Les tableaux à 2 dimensions
 */

// Déclaration de deux tableaux numériques
var legumes = ["Poireaux", "Concombre", "Epinard"];
var fruits = new Array("Raisin", "Bananes","Abricot");

// Affichage des deux tableaux
console.table(legumes);
console.table(fruits);

// Création d'un tableau à deux diemnsion depuis les deux tableaux numériques
var primeur = new Array(legumes,fruits);

// Affichage du tableau à deux dimension
console.table(primeur);

// Affichage de Poireaux 
console.log(primeur[0][0]);
// Affichage de Abricot
console.log(primeur[1][2]);

var zoo = [
    {
        pseudo:"Simba",
        espece:"Lion",
        contient:"Afrique"
    },
    {
        pseudo:"Tony",
        espece:"Kangourou",
        contient:"Océanie"
    }
];

// Afficher dans la console le pseudo du Lion et du Kangoroo (Avec une concaténation) 
console.table(zoo);
console.log("Venez découvrir dans notre zoo "+zoo[0].pseudo+" et "+zoo[1].pseudo);
