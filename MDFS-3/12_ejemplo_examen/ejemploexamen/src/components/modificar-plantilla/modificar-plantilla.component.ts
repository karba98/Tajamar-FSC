import { Component, OnInit, ViewChild,ElementRef } from '@angular/core';
import { Router } from '@angular/router';
import { Empleado } from 'src/app/models/Empleado';
import { PlantillaService } from 'src/services/plantilla.service';

@Component({
  selector: 'app-modificar-plantilla',
  templateUrl: './modificar-plantilla.component.html',
  styleUrls: ['./modificar-plantilla.component.css']
})
export class ModificarPlantillaComponent implements OnInit {

  public status:string;
  @ViewChild('incremento') incremento:ElementRef;
  @ViewChild('funcion') funcion:ElementRef;
  public funciones:Array<string>;
  public empleados:Array<Empleado>;

  constructor(private _service:PlantillaService,
    public _route :Router) { 
    this.funciones=[];
    this.funcion=ElementRef.prototype;
    this.incremento=ElementRef.prototype;
    this.empleados=[];
    
  }

  setIncrement(){
    console.log("incrementando");
    let fun = this.funcion.nativeElement.value;
    let inc = this.incremento.nativeElement.value;
    console.log(fun+"  "+inc)
    if(fun!="" && inc>0){
      this._service.incrementarSalario(fun,inc).subscribe(response=>{
        this._service.getEmpleadosF(fun).subscribe(resp=>{
          this.empleados=resp;
          this.status='activo';
        })
      },error=>{
        console.log(error)
        this.status='no';
      })
    }
  }
  ngOnInit(): void {
    this._service.getFunciones().subscribe(response=>{
      this.funciones=response;
    });
  }

}
