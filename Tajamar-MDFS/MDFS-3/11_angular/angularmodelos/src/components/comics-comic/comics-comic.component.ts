import { Component,Output,Input, OnInit, EventEmitter } from '@angular/core';
import { Comic } from 'src/app/models/Comic';
@Component({
  selector: 'app-comics-comic',
  templateUrl: './comics-comic.component.html',
  styleUrls: ['./comics-comic.component.css']
})
export class ComicsComicComponent implements OnInit {

  @Input() comic:Comic;
  @Output() addFav = new EventEmitter();
  @Output() delete=new EventEmitter();
  constructor() { }


  ngOnInit(): void {
  }
  favorito = ()=>{
    this.addFav.emit(this.comic);
  }
  eliminar = ()=>{
    this.delete.emit(this.comic);
  }

}
