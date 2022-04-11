/**
 * 0 - Création d'un element REACT (JSX)
 */
const nom ="Anthony Di persio";
const elementHTML = <h2>Bonjour, {nom}</h2>;


/**
 * 1 - Creation d'un composant simple (component)
 */
function MyComposant(){
    return(
        <h2>Bonjour, {nom}</h2>
    )
}






/**
 * 0- Rendu => Avec elementHTML (JSX)
 */
ReactDOM.render(
    elementHTML,
    document.getElementById('root')
);

/**
 * 1- Rendu => Avec un composant
 */
ReactDOM.render(<MyComposant/>,document.getElementById('app') )