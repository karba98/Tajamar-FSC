import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-padrecontador',
  templateUrl: './padrecontador.component.html',
  styleUrls: ['./padrecontador.component.css']
})
export class PadrecontadorComponent implements OnInit {

  public numeros:Array<number>;
  public mensaje:string;
  constructor() { 
    this.mensaje="Ningun contador Hijo pulsado";
    this.numeros=[5,9,10,20,30,40];
  }

  setIncreamentando =(event)=>{
    //event sera un numero, pero puede ser un json (event{nombre:nombre, apellido:apellido...})
    console.log("Soy metodo de padre");
    this.mensaje="Contador incrementando: "+event;
  }
  ngOnInit(): void {
  }

}
