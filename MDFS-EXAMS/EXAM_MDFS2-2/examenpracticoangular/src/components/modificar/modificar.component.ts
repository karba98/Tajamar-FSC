import { PersonajesService } from './../../app/services/personajes.service';

import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { Serie } from 'src/app/models/Serie';
import { SeriesService } from 'src/app/services/series.service';
import { Personaje } from 'src/app/models/Personaje';

@Component({
  selector: 'app-modificar',
  templateUrl: './modificar.component.html',
  styleUrls: ['./modificar.component.css']
})
export class ModificarComponent implements OnInit {
  @ViewChild("serie") serie:ElementRef;
  @ViewChild("personaje") personaje:ElementRef;

  public series:Array<Serie>;
  public personajes:Array<Personaje>;
  constructor(private _service:SeriesService,private _servicePer:PersonajesService) { }

  insertar(){
    let idserie = this.serie.nativeElement.value;
    let idpersonaje= this.personaje.nativeElement.value;
     this._servicePer.putPersonaje(idpersonaje,idserie).subscribe(res=>{
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
    this._servicePer.getPersonajes().subscribe((res)=>{
      this.personajes=res;
      console.log(this.personajes)
    },error=>{
      console.log(error);
    });
  }

}
