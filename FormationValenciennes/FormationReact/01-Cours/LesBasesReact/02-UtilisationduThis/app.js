/**
 * Création des constantes depuis nos elements HTML
 */
const result =document.querySelector('#app');
const link =document.querySelector('#link');

// Propagation d'un evenement avec une fonction fléchée (arrow function)
link.addEventListener('click',(event)=>{
    alert(`Arrow Function, this => ${this} and event sources is : ${event}` ); //this === window
})

// Propagation d'un evenement avec une fonction fléchée (arrow function)
link.addEventListener('click', function () {
    Console.log(`ClassicFunction, this => `+this ); // this => Button (Link element)
})

// Appel de fonction depuis l'event click du boutton
function ClickFunction(){
    result.innerHTML+="<h2>C'est clické</h2>";
}

// Appel de fonction depuis l'event click du boutton avec confirmation
function ClickConfirm(){
    let response = confirm("Etes-vous sur?");
    response === true?
        result.innerHTML+="<h2>C'est Confirmé</h2>"
        :
        result.innerHTML+="<h2>Ce n'est pas Confirmé</h2>"
}
