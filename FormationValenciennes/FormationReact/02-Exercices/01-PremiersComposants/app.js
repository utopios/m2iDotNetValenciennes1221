function Header() {
    return (
        <div className="header">
            <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrMhzHyzjHhP7frg5hO_jbH2eTc3XzQpzRTtXZZeTqYgSt40cvZY9t6nz-rccu7b2TEh4&usqp=CAU" alt="LogoM2i" />
            <h2>M2i Formation</h2>
        </div>
    )
}

function Description() {
    const text = "Votre formation sur mesure...";
    return (
        <span><i>{text.toLocaleLowerCase()}</i></span>
    )
}

function LeftComponent() {
    return (
        <div className="left">
            <h2>LEFT</h2>
        </div>
    )
}

function CenterComponent() {
    return (
        <div id="center">
            <h2 className="TitreH2">Le composant au centre</h2>
            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Beatae quibusdam asperiores vitae totam dolor accusantium mollitia nam minus cum saepe exercitationem tempore vel sit, perspiciatis suscipit ex in sed quisquam?</p>
            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Beatae quibusdam asperiores vitae totam dolor accusantium mollitia nam minus cum saepe exercitationem tempore vel sit, perspiciatis suscipit ex in sed quisquam?</p>
            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Beatae quibusdam asperiores vitae totam dolor accusantium mollitia nam minus cum saepe exercitationem tempore vel sit, perspiciatis suscipit ex in sed quisquam?</p>
        </div>
    )
}

function RightComponent() {
    return (
        <div className="right">
            <h2>RIGHT</h2>
        </div>
    )
}

function Footer() {
    return (
        <div className="footer">
            <p>Ma premiere page perso générée par react - Copyright@2022 - <a href="mailto:anthony@utopios.net">Me contacter</a></p>
        </div>
    )
}

function Page() {
    return (
        <div className="container-fluid">
            <div className="banner">
                <Header />
                <div className="description">
                    <Description />
                </div>
            </div>

            <div className="row no-gutters">
                <div className="col-2">
                    <LeftComponent />
                </div>
                <div className="col-8">
                    <CenterComponent />
                </div>
                <div className="col-2">
                    <RightComponent />
                </div>
            </div>

            <div className="footer">
                <Footer />
            </div>
        </div>
    )
}

/**
 * Rendu vers le Virtual DOM (Elements parent de plusieur composants , utilisation des react.fragments)
 */
ReactDOM.render(<React.Fragment><Page /></React.Fragment>, document.getElementById("app"));