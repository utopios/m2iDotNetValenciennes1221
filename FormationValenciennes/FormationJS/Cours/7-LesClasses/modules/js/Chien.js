import Mammifere from "./Mammifere.js";


export default class Chien extends Mammifere{
    
    Alimentation(){
        console.log("Je me nourris de croquetes...Et d'os à moelle");
    }
    Respiration(){
        console.log("Inspiration...Expiration...J'ai des poumons");
    }
    Aboyer(){
        if(this.heartRate)
            console.log("Wouaf!");
        else
            console.log("Je ne peux pas... je ne suis plus...");
    }
}