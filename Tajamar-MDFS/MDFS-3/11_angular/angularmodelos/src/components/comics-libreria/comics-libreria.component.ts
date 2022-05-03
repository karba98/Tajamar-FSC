import { Component, OnInit } from '@angular/core';
import { ComicsComicComponent} from './../comics-comic/comics-comic.component';
import {Comic} from './../../app/models/Comic'
import { ComponentFixture } from '@angular/core/testing';

@Component({
  selector: 'app-comics-libreria',
  templateUrl: './comics-libreria.component.html',
  styleUrls: ['./comics-libreria.component.css']
})
export class ComicsLibreriaComponent implements OnInit {

  public comics :Array<Comic>
  public favorito:Comic;
  constructor() { }
  
  ngOnInit(): void {
    this.favorito=null;
    this.comics = [
            new Comic(
              "Spiderman",
              "https://images-na.ssl-images-amazon.com/images/I/61AYfL5069L.jpg",
              "Hombre araña"
            ),
            new Comic(
              "Wolverine",
              "https://i.etsystatic.com/9340224/r/il/42f0e1/1667448004/il_570xN.1667448004_sqy0.jpg",
              "Lobezno"
            ),
            new Comic(
              "Guardianes de la Galaxia",
              "https://cdn.normacomics.com/media/catalog/product/cache/1/thumbnail/9df78eab33525d08d6e5fb8d27136e95/g/u/guardianes_galaxia_guadianes_infinito.jpg",
              "Yo soy Groot"
            )
          ];
      
  }
  addFav=(comic)=>{
    console.log(comic.nombre);
    this.favorito=comic;
  }
  delete =(event)=>{
    for(let i=0;i<this.comics.length;i++){
      if(this.comics[i].nombre==event.nombre){
        this.comics.splice(i,1);
      }
    }
  }
  addComic =(comic)=>{
    console.log(comic);
    this.comics.push(
      new Comic(
        comic.nombre,
        comic.imagen,
        comic.descripcion
      )
    );
  }

}
