

export default class EtreVivant{
    constructor(nom,type){
        this.nom=nom;
        this.type=type;
    }

    Naissance(){
        console.log("Tous les êtres vivants naissent...");
    }
    Mort(){
        console.log("Tous les êtres vivants meurent...");
    }
    Respiration(){
        console.log("Tous les êtres vivants respirent... à leur manière!");
    }
    Alimentation(){
        console.log("Tous les êtres vivants s'alimentent... à leur manière!");
    }
}