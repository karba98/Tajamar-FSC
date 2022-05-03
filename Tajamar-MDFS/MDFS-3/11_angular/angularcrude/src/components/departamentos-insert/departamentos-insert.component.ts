import { Component, OnInit,ViewChild,ElementRef } from '@angular/core';
import{Router} from '@angular/router';

import {DepartamentosService} from './../../app/services/departamentos.service';
import{Departamento} from './../../app/models/departamento';
@Component({
  selector: 'app-departamentos-insert',
  templateUrl: './departamentos-insert.component.html',
  styleUrls: ['./departamentos-insert.component.css']
})
export class DepartamentosInsertComponent implements OnInit {

  @ViewChild('cnumero') numero:ElementRef
  @ViewChild('cnombre') nombre:ElementRef;
  @ViewChild('clocalidad') localidad:ElementRef;
  constructor(private router:Router,private _service:DepartamentosService) { }

  ngOnInit(): void {
  }
  insertar(){
    let num = parseInt(this.numero.nativeElement.value);
    let nom = this.nombre.nativeElement.value;
    let loc = this.localidad.nativeElement.value;

    let dep = new Departamento(num,nom,loc);
    this._service.insertDep(dep).subscribe(response=>{
      this.router.navigate(['/']);
    },error=>{
      console.log(error);
    });    
  }

}
