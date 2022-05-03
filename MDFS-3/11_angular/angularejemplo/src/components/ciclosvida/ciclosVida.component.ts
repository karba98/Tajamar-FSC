import {
    Component, 
    OnInit, 
    DoCheck
} from '@angular/core';

@Component({
    selector:'app-ciclosvida',
    templateUrl:'./ciclosvida.component.html',
})

export class CiclosVida implements OnInit,DoCheck {

    public mensaje :string;
    constructor (){
        console.log("construido ciclosvida");
        this.mensaje="Bienvenido a Angular";
    }

    clickBoton (){
        if(this.mensaje=="Bienvenido Raúl"){
            this.mensaje="Bienvenido a Angular"
        }else{
            this.mensaje="Bienvenido Raúl";
        }

    }
    //:void es lo que devolveria
    ngOnInit():void{
        console.log("Metodo onInit");
    }
    ngDoCheck(){
        console.log("Esto es docheck");
    }


}