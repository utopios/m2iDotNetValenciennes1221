function Header(){
    return(
        <div className="header">
            <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrMhzHyzjHhP7frg5hO_jbH2eTc3XzQpzRTtXZZeTqYgSt40cvZY9t6nz-rccu7b2TEh4&usqp=CAU" alt="LogoM2i" />
            <h2>M2i Formation</h2>
        </div>
    )
}

// // V1
// function Description(){
//     return (<p>Votre formation sur mesure...</p>)
// }

function Description(){
    const text = "Votre formation sur mesure...";
    return(
        <span><i>{text.toLocaleLowerCase()}</i></span>
    )
}

function Banner(){
    return(
        <div className="banner">
            <Header/>
            <div className="description">
                <Description/>
            </div>
        </div>
    )
}

/**
 * Rendu vers le Virtual DOM (Elements parent de plusieur composants , utilisation des react.fragments)
 */
ReactDOM.render(<React.Fragment><Banner/></React.Fragment>, document.getElementById("app"));