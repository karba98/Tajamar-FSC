import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import {Pelicula} from './../../app/models/Pelicula';
import {PeliculasService} from './../../app/services/peliculas.service'
import {Global} from './../../app/services/global'

@Component({
  selector: 'app-peliculas',
  templateUrl: './peliculas.component.html',
  styleUrls: ['./peliculas.component.css']
})
export class PeliculasComponent implements OnInit {

  public peliculas :Array<Pelicula>
  constructor(private _activeRoute: ActivatedRoute,
    private _service :PeliculasService) {
      this.peliculas=[];
     }

  ngOnInit(): void {
    this._activeRoute.params.subscribe(( params: Params ) => {
      var id = params.genero;
      this.getPelis(id);
    });
  }
  getPelis (id){
    this._service.getPeliculas(id).subscribe(response=>{
      this.peliculas=response;
      for(let peli of this.peliculas) {
        if(peli.foto=="https://servicioapipeliculas.azurewebsites.net/Images/CARTELES/por_un_pu%C3%B1ado_de_dolares.jpg"){
          peli.foto=Global.pupdd;
        }
      }
    });
  }

}
