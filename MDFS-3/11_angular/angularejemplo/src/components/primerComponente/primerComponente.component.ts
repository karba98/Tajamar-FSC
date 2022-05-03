import {Component} from '@angular/core';

//DECLARAMOS COMPONENTE Y ESTRUCTURA DE ARCHIVOS
//ADEMAS DE SU NOMBRE

@Component({
    //NOMBRE DEL COMPONENTE PARA LA APP
    selector:'app-primercomponente',
    //PLANTILLA PARA EL COMPONENTE
    templateUrl:"./primerComponente.component.html"
})

//CLASE PARA SU DECLARACION EN APP.MODULE.JS
export class PrimerComponente{
    //declaramos una variable
    public nombre:string;
    public anio:number;

    //La peimera vex que entra en el componente tenemos un constructor
    constructor(){
        console.log('creando mi primer componente');
        //con this accedemos a las propiedades
        this.nombre="Raúl Castro";
        this.anio= 2020;
    }
}