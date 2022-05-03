import { Component, OnInit ,ViewChild,ElementRef} from '@angular/core';
import {PeliculasService} from './../../app/services/peliculas.service';
import{Genero} from './../../app/models/Genero';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { Pelicula } from 'src/app/models/Pelicula';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  public generos:Array<Genero>
  @ViewChild('titulo') titulo : ElementRef;
  constructor(private _service:PeliculasService,private router:Router) { 
    this.titulo=ElementRef.prototype;

  }

  ngOnInit(): void {
    this._service.getGeneros().subscribe(response=>{
      this.generos=response;
    },error=>{
	    console.log(error);
    });
  }
  search(){
    var title = this.titulo.nativeElement.value;
    this.router.navigate(['/',title]);
    console.log(title);
  }


}
