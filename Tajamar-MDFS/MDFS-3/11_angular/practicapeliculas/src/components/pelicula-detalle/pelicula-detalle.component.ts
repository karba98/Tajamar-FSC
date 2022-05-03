import { Component, OnInit } from '@angular/core';

import { ActivatedRoute, Params } from '@angular/router';
import {Pelicula} from './../../app/models/Pelicula';
import {PeliculasService} from './../../app/services/peliculas.service'
import {Global} from './../../app/services/global';
@Component({
  selector: 'app-pelicula-detalle',
  templateUrl: './pelicula-detalle.component.html',
  styleUrls: ['./pelicula-detalle.component.css']
})
export class PeliculaDetalleComponent implements OnInit {

  public peli:Pelicula;
  constructor(private _activeRoute: ActivatedRoute,
    private _service :PeliculasService) { }

  ngOnInit(): void {
    this._activeRoute.params.subscribe(( params: Params ) => {
      var id = params.id;
      this.getPeli(id);
    });
  }
  getPeli(id:string){
    this._service.getPeli(id).subscribe(response=>{
      this.peli=response;
      if(this.peli.foto=="https://servicioapipeliculas.azurewebsites.net/Images/CARTELES/por_un_pu%C3%B1ado_de_dolares.jpg"){
          this.peli.foto=Global.pupdd;
        }
    });
  }

}
