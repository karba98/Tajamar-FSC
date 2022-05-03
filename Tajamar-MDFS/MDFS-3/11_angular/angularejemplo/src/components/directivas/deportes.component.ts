import {Component} from '@angular/core';
@Component({
    selector:'app-deportes',
    templateUrl:'./deportes.component.html'
})

export class Deportes {
    public sports : Array<string>
    constructor(){
        this.sports=["futbol","padel","tenis","golf",
        "petanca","tiro","arco","curling"];
    }
}