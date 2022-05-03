import { Component, OnInit } from '@angular/core';
import {Coche} from './../../app/models/coche';
@Component({
  selector: 'app-concesionario',
  templateUrl: './concesionario.component.html',
  styleUrls: ['./concesionario.component.css']
})
export class ConcesionarioComponent implements OnInit {

  public coches :Array<Coche>
  constructor() {
    this.coches = [
      new Coche('Audi','R8',0,350,50,false),
      new Coche('Audi','A6',0,370,40,false),
      new Coche('Seat','Ibiza',0,450,60,false),
      new Coche('Mercedes','Benz',0,500,30,false),
    ]
   }

  ngOnInit(): void {
  }

}
