/**
 * 0 - Création d'un element REACT (JSX)
 */
const nom ="Anthony Di persio";
const elementHTML = <h2>Bonjour, {nom}</h2>;


/**
 * 1 - Creation d'un composant simple (component)
 */
// function MyComposant(){
//     return(
//         <h2>Bonjour, {nom}</h2>
//     )
// }


/**
 * 2 - Creation d'un composant avec Params (component)
 */
// function MyComposant({nom, prenom}){
//     return(
//         <h2>Bonjour, {nom} {prenom}</h2>
//     )
// }

/**
 * 3 - Creation d'un composant avec Params (component)
 */
const user={
    firstname:"Anthony",
    lastname:"Di Persio"
}

function formatName(user){
    // console.log("FormatName : "+user);
    return user.firstname+" "+user.lastname;    
}

 function MyComposant({user}){
    return(        
        <h2>Bonjour, {formatName(user)}</h2>
    )
}

// Avec Props
// function MyComposant(props){
//     return(        
//         <h2>Bonjour, {formatName(props.user)}</h2>
//     )
// }


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
// // 1- Rendu ReactDOM.Render() sans params
// ReactDOM.render(<MyComposant/>,document.getElementById('app') )

// // 2 - Rendu ReactDOM.Render() avec params
// ReactDOM.render(<MyComposant nom="Di Persio" prenom="Anthony"/>,document.getElementById('app') )

// 3 - Rendu ReactDOM.Render() avec params
ReactDOM.render(<MyComposant user={user}/>,document.getElementById('app') )
