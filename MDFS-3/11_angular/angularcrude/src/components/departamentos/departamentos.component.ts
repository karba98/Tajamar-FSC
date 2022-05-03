import { Component, OnInit,ViewChild,ElementRef } from '@angular/core';
import{Router} from '@angular/router';
import {ActivatedRoute,Params,Route} from '@angular/router';

import {DepartamentosService} from './../../app/services/departamentos.service';
import{Departamento} from './../../app/models/departamento';
@Component({
  selector: 'app-departamentos',
  templateUrl: './departamentos.component.html',
  styleUrls: ['./departamentos.component.css']
})
export class DepartamentosComponent implements OnInit {
  public departamentos:Array<Departamento>;
  constructor(private _service:DepartamentosService,
    private _activeRoute:ActivatedRoute) {
    this.departamentos=[];
   }
   eliminarDep(id){
    this._service.deleteDep(id).subscribe(response=>{
      this.cargarDeps();
    });
   }
   
   cargarDeps(){
    this._service.getDepartamentos().subscribe(response=>{
      this.departamentos=response;
    });
   }

  ngOnInit(): void {
    this._activeRoute.params.subscribe((params:Params)=>{
      if(params.id!=null){
        this.eliminarDep(params.id);
      }else{
        this.cargarDeps();
      }
    });
  }


}
