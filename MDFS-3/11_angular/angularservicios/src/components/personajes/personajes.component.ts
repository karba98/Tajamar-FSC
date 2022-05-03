import { Component, OnInit } from '@angular/core';
import {PersonajeService} from './../../app/services/personaje.service';
import {Personaje} from './../../app/models/Personaje';
@Component({
  selector: 'app-personajes',
  templateUrl: './personajes.component.html',
  styleUrls: ['./personajes.component.css'],
  providers:[PersonajeService]
})
export class PersonajesComponent implements OnInit {
  public personajes:Array<Personaje>;

  constructor(private _personajeService : PersonajeService) { }

  ngOnInit(): void {
    this.personajes=this._personajeService.getPersonajes();
    console.log(this.personajes);
    
  }

}
