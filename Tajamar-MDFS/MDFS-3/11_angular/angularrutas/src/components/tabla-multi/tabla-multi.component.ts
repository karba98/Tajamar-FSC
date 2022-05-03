import { Component, OnInit,ViewChild,ElementRef } from '@angular/core';

@Component({
  selector: 'app-tabla-multi',
  templateUrl: './tabla-multi.component.html',
  styleUrls: ['./tabla-multi.component.css']
})
export class TablaMultiComponent implements OnInit {

  @ViewChild("cajaNum") caja:ElementRef;
  public results : Array<number>
  public numero :number;
  constructor() { 
    this.results= [];
  }

  ngOnInit(): void {
  }
  createTable=()=>{
    this.results = [];
    this.numero = parseInt(this.caja.nativeElement.value);
    for (let i=0;i<11;i++){
      this.results.push(this.numero*i);
    }
    console.log(this.results);
  }
}
