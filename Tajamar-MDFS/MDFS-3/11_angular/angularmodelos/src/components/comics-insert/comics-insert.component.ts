import { Component, Input,Output, OnInit,EventEmitter } from '@angular/core';
import {Comic} from './../../app/models/Comic';
@Component({
  selector: 'app-comics-insert',
  templateUrl: './comics-insert.component.html',
  styleUrls: ['./comics-insert.component.css']
})
export class ComicsInsertComponent implements OnInit {

  @Input() nuevoComic:Comic;
  @Output() addComic = new EventEmitter();
  public comic :any;
  constructor() { 
    this.comic = {
      nombre:"",
      imagen:"",
      descripcion:""
    }
    
  }

  ngOnInit(): void {
  }
  setComic =()=>{
    this.addComic.emit(new Comic(this.comic.nombre,this.comic.imagen,this.comic.descripcion));
  }

}
