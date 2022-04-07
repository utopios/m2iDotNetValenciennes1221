/**
 * Les Structures Conditionnelles
 */

/*

    L'instruction if (Si...Alors) else (Sinon...)

    if (Condition) {

    }
    else{

    }
*/

var age = prompt("Veuillez saisir votre âge :");
console.log(typeof (age));

if (age >= 18)
    console.log(`A ${age} ans, vous êtes majeur!`);
else
    console.log(`A ${age} ans, vous êtes mineur!`);



/*
    Avec Sinon Si (Nouveau test logique)
*/

compte = 00;
if (compte > 0)
    console.log(`Vous avez ${compte} €, vous êtes créditeur!`);
else if (compte == 0)
    console.log(`Vous avez ${compte} €, solde est nul!`);
else
    console.log(`Vous avez ${compte} €, vous êtes débiteur!`);

/*
    SwitchCase

    switch (expression) {
        case valeur1:
            // Instructions à exécuter lorsque le résultat
            // de l'expression correspond à valeur1
            instructions1;
            [break;]
        case valeur2:
            // Instructions à exécuter lorsque le résultat
            // de l'expression correspond à valeur2
            instructions 2;
            [break;]
        ...
        case valeurN:
            // Instructions à exécuter lorsque le résultat
            // de l'expression à valeurN
            instructionsN;
            [break;]
        [default:
            // Instructions à exécuter lorsqu'aucune des valeurs
            // ne correspond
            instructions_def;
            [break;]]
}
*/

const expr = 'Papayes';
switch (expr) {
    case 'Oranges':
        console.log('Les Oranges sont à 2.99€/kg.');
        break;
    case 'Mangues':
    case 'Papayes':
        console.log('Les Mangues et les papayes sont à 8.59€/kg.');
        break;
    default:
        console.log(`Désolé, nous sommes à court de ${expr}.`);
}





/*
    Les opérateurs de comparaison

    == signifie est égal à // Permet de vérifier que deux valeurs sont identique

    === signifie strictement égal à // Compare la valeur et le type de deux valiables

    != signifie est différent de // Permet de vérifier que la valeur de deux variables sont différentes

    !== signifie strictement différent de // Permet de vérifier si le type OU la valeur sont différents
*/

console.log(1 == 1); // vrai
console.log("1" == 1); // vrai
console.log(1 === 1); // vrai
console.log("1" === 1); // faux
console.log("1" != 1); // faux
console.log("3" !== 3); // vrai
console.log(3 !== 3); // faux
console.log(4 !== 3); // vrai

