import { Personaje } from './../../app/models/Personaje';
import { PersonajesService } from './../../app/services/personajes.service';
import { ActivatedRoute, Params } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-personajes',
  templateUrl: './personajes.component.html',
  styleUrls: ['./personajes.component.css']
})
export class PersonajesComponent implements OnInit {

  constructor(private _activatedroute:ActivatedRoute, private _service:PersonajesService) { 
    this.mostrar=[];
    this.personajes=[];
  }

  public personajes:Array<Personaje>;
  public mostrar:Array<Personaje>;
  public id :string;
  ngOnInit(): void {
    this._activatedroute.params.subscribe((params:Params)=>{
      this.id=params.id;
      console.log(this.id);
      this._service.getPersonajes().subscribe(res=>{
        this.personajes=res;
        console.log(this.personajes);

        for(let per of this.personajes){
          if(per.idSerie==parseInt(this.id)){
            this.mostrar.push(per);
          }
        }
        console.log(this.mostrar);
      });
    });
  }

}
