import { Component, OnInit } from '@angular/core';
import { Empleado } from 'src/app/models/Empleado';
import { PlantillaService } from 'src/services/plantilla.service';

@Component({
  selector: 'app-plantilla',
  templateUrl: './plantilla.component.html',
  styleUrls: ['./plantilla.component.css']
})
export class PlantillaComponent implements OnInit {

  public empleados : Array<Empleado>
  constructor(private _service:PlantillaService) { }

  ngOnInit(): void {
    this._service.getPlantilla().subscribe(response=>{
      this.empleados=response;
    },error=>{
      console.log(error);
    });
  }

}
