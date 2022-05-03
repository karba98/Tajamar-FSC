import { Component, Input, OnInit } from '@angular/core';
import {Coche} from '../../app/models/coche';

@Component({
  selector: 'app-coches',
  templateUrl: './coches.component.html',
  styleUrls: ['./coches.component.css']
})
export class CochesComponent implements OnInit {
  @Input() car :Coche;
  public mensaje:string;

  ngOnInit(): void {
    this.mensaje="Apagado"
  }

  girarLlave=()=>{
    this.car.motor=!this.car.motor;
    if(this.car.motor== false){
      this.mensaje="Apagado";
      this.car.velocidad=0;
    }else{
      this.mensaje="Encendido"
    }

  }
  acelerarCoche=()=>{
    if(this.car.motor==false){
      alert('Mierda, olvidé girar llave');
    }else{
      this.car.velocidad=this.car.velocidad+this.car.aceleracion;
      if(this.car.velocidad>this.car.vmax){
        this.car.velocidad=this.car.vmax;
      }
    }
  }
}
