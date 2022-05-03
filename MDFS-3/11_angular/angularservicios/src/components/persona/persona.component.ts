import { Component, OnInit } from '@angular/core';
import {PersonaService} from './../../app/services/persona.service';
import {Persona} from './../../app/models/Persona';
@Component({
  selector: 'app-persona',
  templateUrl: './persona.component.html',
  styleUrls: ['./persona.component.css'],
  providers:[PersonaService]
})
export class PersonaComponent implements OnInit {

  public personas:Array<Persona>;
  constructor(private _service:PersonaService) { }

  ngOnInit(): void {
    //ES UNA PROMESA ASINCRONA
    this.personas=[];
    this._service.getPersonas().subscribe(response =>{
      this.personas=response;
      console.log(this.personas);
    },error=>{
      console.log("Error en la peticion")
    });
  }

}
