/**
 * Exercice17 - IfElse - Calcul Impôts
 */
// Déclaration variables
var revenus = 0,
    nbAdulte = 0,
    nbEnfants = 0,
    nbParts = 0,
    revenuIMpossable = 0,
    montantImpot = 0;

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Récupération et stockage des saisie utilisateur
var revenus = Number(prompt("Veuillez saisir le montant total des revenus du foyer :"));
var nbAdulte = Number(prompt("Veuillez saisir le nombre d'alulte(s) :"));
var nbEnfants = Number(prompt("Veuillez saisir le nombre d'enfant(s):"));

// Calcul du nombre de parts du foyer            
if (nbEnfants <= 2)
    nbParts = nbAdulte + nbEnfants * 0.5;
else
    nbParts = nbAdulte + nbEnfants - 1;

// Sugar Syntaxe (ternaire) pour le Calcul du nombre de parts
//nbParts = nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;



// Etablissement Structure If() pour calculer le montant de l'impôt
revenuImposable = revenus / nbParts;

if (revenuImposable >= 10226 && revenuImposable <= 26070)
    montantImpot = Math.round((revenuImposable - 10226) * 0.11);
else if (revenuImposable >= 26071 && revenuImposable <= 74545)
    montantImpot = Math.round((revenuImposable - 26071) * 0.3 + ((26071-10226) * 0.11));
else if (revenuImposable >= 74546 && revenuImposable <= 160336)
    montantImpot = Math.round((revenuImposable - 74546) * 0.41 + ((26071-10226) * 0.11) + ((74546 -26071) * 0.3));
else if (revenuImposable >= 160337)
    montantImpot = Math.round((revenuImposable - 160336) * 0.45 + ((26071-10226) * 0.11) + ((74546 -26071) * 0.3) + ((160336-74546) * 0.41));

// // Sugar Syntaxe
// if (revenuImposable > 10064) {
//     montantImpot += (revenuImposable > 25659) ? ((revenuImposable > 73369) ? ((revenuImposable > 157806) ?
//         ((revenuImposable - 157806) * 0.45) + ((157806 - 73369) * 0.41) + ((73369 - 25659) * 0.3) + ((25659 - 10064) * 0.11)
//         : ((revenuImposable - 73369) * 0.41) + ((73369 - 25659) * 0.3) + ((25659 - 10064) * 0.11))
//         : ((revenuImposable - 25659) * 0.3) + ((25659 - 10064) * 0.11))
//         : (revenuImposable - 10064) * 0.11;
// }

montantImpot = montantImpot * nbParts;

// Injection du résultat dans l'element HTML .result
result.innerHTML = `Le montant de l'impôt sur le revenu pour un foyer composé de <b>${nbAdulte} adulte(s)</b> et
                    de <b>${nbEnfants} enfant(s)</b>, avec un revenu fiscal de <b>${revenus}€</b> 
                    s'élève à <b>${montantImpot}€</b>`;