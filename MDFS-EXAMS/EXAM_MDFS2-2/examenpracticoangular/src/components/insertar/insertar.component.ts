import { PersonajesService } from './../../app/services/personajes.service';

import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { Serie } from 'src/app/models/Serie';
import { SeriesService } from 'src/app/services/series.service';

@Component({
  selector: 'app-insertar',
  templateUrl: './insertar.component.html',
  styleUrls: ['./insertar.component.css']
})
export class InsertarComponent implements OnInit {
  @ViewChild("serie") serie:ElementRef;
  @ViewChild("imagen") imagen:ElementRef;
  @ViewChild("nombre") nombre:ElementRef;
  public series:Array<Serie>;
  constructor(private _service:SeriesService,private _servicePer:PersonajesService) { }

  insertar(){
    let idserie = this.serie.nativeElement.value;
    let img = this.imagen.nativeElement.value;
    let nom = this.nombre.nativeElement.value;

    let personaje ={
      "idPersonaje":0,
      "nombre":nom,
      "imagen":img,
      "idSerie":parseInt(idserie)
    }
    console.log(personaje);
    this._servicePer.postPersonaje(personaje).subscribe(res=>{
      console.log(res);
    });



  }
  ngOnInit(): void {
    this._service.getSeries().subscribe((res)=>{
      this.series=res;
      console.log(this.series)
    },error=>{
      console.log(error);
    });
  }

}
