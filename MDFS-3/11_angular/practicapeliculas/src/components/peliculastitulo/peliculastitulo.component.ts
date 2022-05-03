import { Component, OnInit } from '@angular/core';
import {PeliculasService} from './../../app/services/peliculas.service';
import{Genero} from './../../app/models/Genero';
import { Router, ActivatedRoute, Params, ParamMap } from '@angular/router';
import { Pelicula } from 'src/app/models/Pelicula';
import {Global} from './../../app/services/global';
@Component({
  selector: 'app-peliculastitulo',
  templateUrl: './peliculastitulo.component.html',
  styleUrls: ['./peliculastitulo.component.css']
})
export class PeliculastituloComponent implements OnInit {
  public pelis :Array<Pelicula>;
  constructor(private _activeRoute:ActivatedRoute, private _service:PeliculasService) {
    this.pelis=[];
  }

  ngOnInit(): void {
    this._activeRoute.params.subscribe(( params: Params ) => {
      var title = params.titulo;
      this._service.getPeliByTitle(title).subscribe(response=>{
        this.pelis=response;
        for(let peli of this.pelis) {
          if(peli.foto=="https://servicioapipeliculas.azurewebsites.net/Images/CARTELES/por_un_pu%C3%B1ado_de_dolares.jpg"){
            peli.foto=Global.pupdd;
          }
        }
      })
    });
  }

}
