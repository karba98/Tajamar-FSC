import {Component} from '@angular/core';
@Component({
    selector:'app-aleatorios',
    templateUrl:'./aleatorios.component.html',
    styleUrls:['./aleatorios.component.css']
})

export class Aleatorios{
    public numeros : Array<number>;
    constructor(){
        this.numeros=[5,3,8,4];
    }
    generarNumeros(){
        let aleat = Math.floor(Math.random()*100)+1;
        this.numeros.push(aleat);
    }
}