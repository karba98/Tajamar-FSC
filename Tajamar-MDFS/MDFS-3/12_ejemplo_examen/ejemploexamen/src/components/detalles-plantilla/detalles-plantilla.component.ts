import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Empleado } from 'src/app/models/Empleado';
import { PlantillaService } from 'src/services/plantilla.service';

@Component({
  selector: 'app-detalles-plantilla',
  templateUrl: './detalles-plantilla.component.html',
  styleUrls: ['./detalles-plantilla.component.css']
})
export class DetallesPlantillaComponent implements OnInit {

  public id:string;
  public router:Router;

  public empleado:Empleado;
  constructor(private _arc:ActivatedRoute, private _service:PlantillaService) { }

  ngOnInit(): void {
    this._arc.params.subscribe((params:Params)=>{
      this.id=params.id;
    },error=>{
    });

    this._service.getEmpleado(this.id).subscribe(response=>{
      this.empleado=response;
    });
  }

}
