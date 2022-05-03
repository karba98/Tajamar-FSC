import { Component, OnInit, ViewChild,ElementRef } from '@angular/core';
import {EmpleadosService} from './../../app/services/Empleados.service';
import {Empleado} from './../../app/models/Empleado';

@Component({
  selector: 'app-empleadossalario',
  templateUrl: './empleadossalario.component.html',
  styleUrls: ['./empleadossalario.component.css']
})
export class EmpleadossalarioComponent implements OnInit {

  public empleados:Array<Empleado>;
  @ViewChild('cajasalario') cajasalario: ElementRef;
  constructor(private _service:EmpleadosService) {
    this.empleados=[];
   }

  buscarEmpleados(){
    let salario = this.cajasalario.nativeElement.value;
    console.log(salario);
    if(salario!=""){
      this._service.getEmpleadosPorSalario(salario).subscribe(response=>{
        this.empleados=response;
      },error=>{
        console.log("Error")
      });
    }else{
      this.empleados=[];
    }
    
  }
  ngOnInit(): void {
     
  }

}
