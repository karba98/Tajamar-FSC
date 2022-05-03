import { Component, OnInit } from '@angular/core';
import {EmpleadosRoutingService} from './../../app/services/EmpleadoRouting.service';
import { ActivatedRoute, Params } from '@angular/router';
import { Empleado } from 'src/app/models/Empleado';

@Component({
  selector: 'app-detallesempleado',
  templateUrl: './detallesempleado.component.html',
  styleUrls: ['./detallesempleado.component.css']
})
export class DetallesempleadoComponent implements OnInit {

  private empleado:Empleado;

  constructor(private _service:EmpleadosRoutingService,
    private _activeRoute: ActivatedRoute,
    ) { 
    this.empleado=null;
  }

  buscarEmpleado(id){
    this._service.buscarEmpleado(id).subscribe(response=>{
      this.empleado=response;
    });
  }
  ngOnInit(): void {

    this._activeRoute.params.subscribe(( params: Params ) => {
      var empno = params.empleado;
      this.buscarEmpleado(empno);
    });
      
  }

}
