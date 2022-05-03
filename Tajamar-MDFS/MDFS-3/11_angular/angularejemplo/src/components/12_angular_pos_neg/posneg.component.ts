import {Component} from '@angular/core';
@Component({
    selector:'app-posneg',
    templateUrl:'./posneg.component.html',
    styleUrls:['./posneg.component.css']
})

export class Posneg {
    public numeros:Array<number>
    constructor(){
        this.numeros=[1,2,3];
    }
    generateNum (){
        let num = Math.floor(Math.random()*10);
        this.numeros.push(num);
    }
}