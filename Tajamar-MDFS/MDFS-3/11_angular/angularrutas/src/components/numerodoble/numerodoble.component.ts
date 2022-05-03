import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router,Params} from '@angular/router';

@Component({
  selector: 'app-numerodoble',
  templateUrl: './numerodoble.component.html',
  styleUrls: ['./numerodoble.component.css']
})
export class NumerodobleComponent implements OnInit {

  private doble:number;
  private num:number;
  //ACTIVATERPOUTE Y ROUTER PARA RECIBIR LOS PARAMETROS
  constructor(
    private _activateRoute:ActivatedRoute, 
    //CON ROUTE PODEMOS MOVERNOS POR NUESTRA APP
    private _route:Router) {

   }

   //NOS SUBSCRIBIMOS AL PARAMETRO PARA RECIBIRLO, COMO UNA PROMESA
  ngOnInit(): void {
    this._activateRoute.params.subscribe((params:Params)=>{
      if(params.numero!= null){
        this.num=parseInt(params.numero);
        this.doble = this.num*2;
      }
      else{
          console.log(params);
      }
    });
  }
  irACine =()=>{
    this._route.navigate(["/cine"]);
  }

}
