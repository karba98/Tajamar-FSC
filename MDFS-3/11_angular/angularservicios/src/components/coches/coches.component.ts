import { Component, OnInit } from '@angular/core';
import {CocheService} from './../../app/services/Coches.service';
import {Coche} from './../../app/models/Coche';
@Component({
  selector: 'app-coches',
  templateUrl: './coches.component.html',
  styleUrls: ['./coches.component.css'],
  providers:[CocheService]
})
export class CochesComponent implements OnInit {

  public coches:Array<Coche>;
  constructor(private _service:CocheService) { }

  ngOnInit(): void {
    this._service.getCoches().subscribe(response=>{
      this.coches=response;
      console.log(this.coches)
    },error=>{
      console.log("Error");
    })
  }

}
