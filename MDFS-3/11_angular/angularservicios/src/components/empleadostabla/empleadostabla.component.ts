import { Component, OnInit } from '@angular/core';
import {EmpleadosRoutingService} from './../../app/services/EmpleadoRouting.service';
import {Empleado} from './../../app/models/Empleado';

@Component({
  selector: 'app-tablaempleados',
  templateUrl: './empleadostabla.component.html',
  styleUrls: ['./empleadostabla.component.css']
})
export class EmpleadosTablaComponent implements OnInit {

  public empleados :Array<Empleado>
  constructor(private _service:EmpleadosRoutingService) { 
    this.empleados=[];
  }

  ngOnInit(): void {
    this._service.getEmpleados().subscribe(response=>{
      this.empleados=response;
      console.log(response);
    },error=>{
      console.log(error);
    })
  }
}
