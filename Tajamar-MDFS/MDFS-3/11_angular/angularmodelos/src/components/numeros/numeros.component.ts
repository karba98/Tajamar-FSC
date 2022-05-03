import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-numeros',
  templateUrl: './numeros.component.html',
  styleUrls: ['./numeros.component.css']
})
export class NumerosComponent implements OnInit {

  public numeros:Array<number>;
  constructor() {
    this.numeros =[];
    for (let  i=0;i<15;i++){
      this.numeros.push(Math.floor(Math.random()*99));
    }
   }

  ngOnInit(): void {
   
  }
  
}
