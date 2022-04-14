## Install React project from CLI NPX
npx create-react-app@latest <projectName>

## Procedure (New)
1/ npx create-react-app <nomProjet>

2/ cd <nomProjet>

3/ npm start

## Procedure (Old)
1/ npx create-react-app <nomProjet>

2/ cd <nomProjet>

3/ npm install --save-dev web-vitals

4/ npm start

## Plug-In VS React
Simple React snippets
Reactjs code snippets

## Install React Dev Tools pour Chrome
https://chrome.google.com/webstore/detail/react-developer-tools/fmkadmapgofadopljbjfkapdkoienihi

# Dans settings.json, rajouter pour les emet React :

"emmet.includeLanguages": { "javascript": "javascriptreact" }, "emmet.triggerExpansionOnTab": true

# Installation de react-router-dom
npm install react-router-dom

## install Bootstrap
$ npm install react-bootstrap bootstrap@5.1.3

## The following line can be included in your src/index.js or App.js file
import 'bootstrap/dist/css/bootstrap.min.css';

####
## Install Fontawesome
####

# Installer tous en une seule fois
npm i -S @fortawesome/fontawesome-svg-core @fortawesome/react-fontawesome @fortawesome/free-regular-svg-icons @fortawesome/free-solid-svg-icons @fortawesome/free-brands-svg-icons

# Exécutez la commande suivante pour installer les paquets de base :
npm i -S @fortawesome/fontawesome-svg-core @fortawesome/react-fontawesome
# regular icons
npm i -S @fortawesome/free-regular-svg-icons
# solid icons
npm i -S @fortawesome/free-solid-svg-icons
# brand icons
npm i -S @fortawesome/free-brands-svg-icons

## Import Fontawesome
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
# Import solid 
import { faHome } from "@fortawesome/free-solid-svg-icons";
# Import Regular
import { faHome } from "@fortawesome/free-regular-svg-icons";
# Import brand
import { faHome } from "@fortawesome/free-brand-svg-icons";

## Use Font Awesome
<FontAwesomeIcon icon={faHome} style={{ color: 'rgb(40, 44, 52)',fontSize:'25px' }} />
