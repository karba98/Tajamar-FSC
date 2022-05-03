import { Component, OnInit,ViewChild,ElementRef } from '@angular/core';
import {ActivatedRoute,Params,Router} from '@angular/router';

import {DepartamentosService} from './../../app/services/departamentos.service';
import{Departamento} from './../../app/models/departamento';

@Component({
  selector: 'app-departamentos-update',
  templateUrl: './departamentos-update.component.html',
  styleUrls: ['./departamentos-update.component.css']
})
export class DepartamentosUpdateComponent implements OnInit {

  @ViewChild('cnumero') numero:ElementRef
  @ViewChild('cnombre') nombre:ElementRef;
  @ViewChild('clocalidad') localidad:ElementRef;

  public departamento :Departamento;
  public id:string;
  constructor(private route:Router,
    private _activer:ActivatedRoute, 
    private _service:DepartamentosService) { 
    
  }

  buscarDep(id){
    this._service.buscarDep(id).subscribe(response=>{
      this.departamento=response;
    });
  }
  modDep(){
    let num = parseInt(this.numero.nativeElement.value);
    let nom = this.nombre.nativeElement.value;
    let loc = this.localidad.nativeElement.value;

    let dep = new Departamento(num,nom,loc);

    this._service.updateDep(dep).subscribe(response=>{
      this.route.navigate(['/'])
    },error=>{
        console.log(error);
    })
  }

  ngOnInit(): void {
    this._activer.params.subscribe((params:Params)=>{
      if(params.id!=null){
        this.buscarDep(params.id);
      }else{
        this.route.navigate(['/']);
      }
    });
  }
}
