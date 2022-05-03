import { Component, OnInit } from '@angular/core';
import {PeliculasService} from './../../app/services/peliculas.service';
import{Genero} from './../../app/models/Genero';
import { Router, ActivatedRoute, Params, ParamMap } from '@angular/router';
import { Pelicula } from 'src/app/models/Pelicula';
import {Global} from './../../app/services/global'
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public peliculas:Array<Pelicula>
  constructor(private _service:PeliculasService) {
    this.peliculas=[]
   }

  ngOnInit(): void {
    this._service.getAllPelis().subscribe(response=>{
      this.peliculas=response;
      for(let peli of this.peliculas) {
        if(peli.foto=="https://servicioapipeliculas.azurewebsites.net/Images/CARTELES/por_un_pu%C3%B1ado_de_dolares.jpg"){
          peli.foto=Global.pupdd;
        }
      }
    });
  }
  ngOnChanges() {
    this.peliculas=[];
  }

}
