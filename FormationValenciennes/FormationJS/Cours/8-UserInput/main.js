const inputNom = document.querySelector('#nom');
const inputPrenom = document.querySelector('#prenom');
const result = document.querySelector('#result');

let message="";

Valider = () => {
    
    alert(inputPrenom.value +" "+ inputNom.value)
    result.innerHTML = `<h3>Vous avez saisi : ${inputNom.value}  ${inputPrenom.value}</h3>`;
}






