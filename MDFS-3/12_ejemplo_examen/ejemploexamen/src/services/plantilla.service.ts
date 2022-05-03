import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Global} from './../global/global';

@Injectable({
  providedIn: 'root'
})
export class PlantillaService {
  private url: string;
  constructor(private _httpService:HttpClient){
      this.url=Global.url;
  }

  getPlantilla ():Observable <any>{
      let request = "/api/Plantilla";
      return this._httpService.get(this.url+request);
  }
  getEmpleado (id:string):Observable <any>{
    let request = "/api/Plantilla/"+id;
    return this._httpService.get(this.url+request);
  }
  getFunciones():Observable<any>{
    let request = "/api/Plantilla/Funciones"
    return this._httpService.get(this.url+request);
  }
  incrementarSalario(funcion,incremento):Observable<any>{
    let request="/api/Plantilla/"+funcion+"/"+incremento;
    let headers = new HttpHeaders().set("Content-Type", "application/json");
    return this._httpService.put(this.url+request,headers);
  }
  getEmpleadosF(funcion):Observable<any>{
    let request = "/api/Plantilla/PlantillaFuncion/"+funcion;
    return this._httpService.get(this.url+request);
  }

  
}