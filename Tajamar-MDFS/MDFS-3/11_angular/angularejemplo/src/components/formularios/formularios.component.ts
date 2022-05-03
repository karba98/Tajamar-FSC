import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-formularios',
  templateUrl: './formularios.component.html',
  styleUrls: ['./formularios.component.css']
})
export class FormulariosComponent implements OnInit {

  //modelo a enlazar con formulario
  public user :any;
  public mensaje : string;
  constructor() { 
    this.user = {
      nombre:"",
      apellidos:"",
      edad:0
    }
    this.mensaje= "";
  }

  ngOnInit(): void {
  }
  recibirDatos ():void{
    this.mensaje="datos recibidos";
    console.log(this.user);
  }

}
