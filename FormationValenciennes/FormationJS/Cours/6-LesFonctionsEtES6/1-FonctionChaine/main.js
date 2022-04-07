/**
 * Les Fonctions en Javascript
 */



/**
  * split()
  */

var chaine = "Bonjour, comment allez-vous?";
console.log(chaine.split(''));
console.log(chaine.split(' '));
console.log(chaine.split(','));


/**
 * array.reverse()
 */
var arrayChaine = chaine.split(',').reverse();
console.log(arrayChaine);


/**
 * join()
 */

// newChaine=arrayChaine.join('-');
console.log(arrayChaine.join('-'));
console.log(arrayChaine.join(' '));
console.log(arrayChaine.join(''));