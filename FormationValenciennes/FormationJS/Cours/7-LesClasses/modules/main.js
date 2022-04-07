import Chien from "./js/Chien.js";
import Fleur from "./js/Fleur.js";

let medor = new Chien("Médor", "Berger Allemand");
let cosmos = new Fleur("Cosmos", "Cosmos Sulphureus");

console.log(`Battement de coeur de médor : ${medor.heartRate}`);
console.log(`Photosynthèse de cosmos : ${cosmos.photosyntese}`);
medor.Aboyer();
let etresVivants = [medor, cosmos];

for (let etre of etresVivants) {
    console.log(`-------- ${etre.nom} --------`);
    etre.Naissance();
    etre.Respiration();
    etre.Alimentation();
    etre.Mort();
    console.log(`------------------------`);
}

console.log(`Battement de coeur de médor : ${medor.heartRate}`);
console.log(`Photosynthèse de cosmos : ${cosmos.photosyntese}`);
medor.Aboyer();
console.log(medor);