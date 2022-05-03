import { Component, Input, Output, OnInit, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-hijocontador',
  templateUrl: './hijocontador.component.html',
  styleUrls: ['./hijocontador.component.css']
})
export class HijocontadorComponent implements OnInit {

  @Input() inicio:number;
  @Input() idcontador:number;
  @Output() setIncreamentando = new EventEmitter();

  public numero:number; //EN QUE NUMERO ESTÁ EL CONTADDOR
  public mensaje:string;
  constructor() { }

  incrementarContador=(event)=>{
    this.numero=this.numero+1;
    this.mensaje="Contador en "+this.numero;
    this.setIncreamentando.emit(this.idcontador);
  }

  ngOnInit(): void {
    this.numero=this.inicio;
    this.mensaje="Contador id: "+this.idcontador+" Valor inicial: "+this.numero;
  }

}
