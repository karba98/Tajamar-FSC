import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-sumar-numeros',
  templateUrl: './sumar-numeros.component.html',
  styleUrls: ['./sumar-numeros.component.css']
})
export class SumarNumerosComponent implements OnInit {

  @ViewChild("caja1") caja1:ElementRef;
  @ViewChild("caja2") caja2:ElementRef;

  public resultado:number;
  constructor() { 
    this.resultado=0
  }

  ngOnInit(): void {
  }
  sumar =()=>{
    let n1= parseInt(this.caja1.nativeElement.value);
    let n2= parseInt(this.caja2.nativeElement.value);

    this.resultado = n1+n2;
  }

}
