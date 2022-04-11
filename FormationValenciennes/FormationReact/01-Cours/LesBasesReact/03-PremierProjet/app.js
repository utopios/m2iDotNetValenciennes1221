function Header(){
    return(
        <div className="header">
            <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrMhzHyzjHhP7frg5hO_jbH2eTc3XzQpzRTtXZZeTqYgSt40cvZY9t6nz-rccu7b2TEh4&usqp=CAU" alt="LogoM2i" />
            <h2>M2i Formation</h2>
        </div>
    )
}


/**
 * Rendu vers le Virtual DOM (Elements parent de plussieur composants , utilisation des react.fragments)
 */
ReactDOM.render(<Header/>, document.getElementById("app"));