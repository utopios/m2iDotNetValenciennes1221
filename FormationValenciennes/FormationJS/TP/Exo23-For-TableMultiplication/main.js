/**
 * EXERCICE 23 - FOR - Tables de Multiplications
 */


// Déclaration variables
let affichage = "<h2>Les tables de multiplication de 1 à 10</h2>";

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Permet de faire une boucle itérative allant jusqu'à 10
for (let i = 1; i <= 10; i++)
{

    affichage+=`<div class="card"><h5>Table de <b>${i}</b> :</h5><ul> `;

    for (let j = 1; j <= 10; j++)
    {
        affichage+=`<li class="tab-25">${i} x ${j} = <b>${i*j}</b></li>`;
    }
    affichage+=`</ul></div>`;
}

// Injection du résultat dans l'element HTML .result
result.innerHTML = affichage;