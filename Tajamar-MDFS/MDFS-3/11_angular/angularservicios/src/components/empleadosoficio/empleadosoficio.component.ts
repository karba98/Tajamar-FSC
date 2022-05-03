
import { Component, OnInit, ViewChild,ElementRef } from '@angular/core';
import {EmpleadosService} from './../../app/services/Empleados.service';
import {Empleado} from './../../app/models/Empleado';
@Component({
  selector: 'app-empleadosoficio',
  templateUrl: './empleadosoficio.component.html',
  styleUrls: ['./empleadosoficio.component.css']
})
export class EmpleadosoficioComponent implements OnInit {

  public oficios :Array<string>
  public empleados:Array<Empleado>
  @ViewChild('oficio') oficio:ElementRef;
  constructor(private _service:EmpleadosService) { 
    this.oficios=[];
    this.empleados=[];
    this.oficio=ElementRef.prototype;
  }

  ngOnInit(): void {
    this._service.getOficios().subscribe(response=>{
      this.oficios=response;
    },error=>{
      console.log("Error");
    });
  }
  getEmpleados(){
    this._service.getEmpleadosOficio(this.oficio.nativeElement.value).subscribe(response=>{
      this.empleados=response;
    },error=>{

    });
  }

}
