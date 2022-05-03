import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Global} from './global';

@Injectable()
export class EmpleadosService {

    private url: string;
    constructor(private _httpService:HttpClient){
        this.url=Global.urlEmpleados;
    }

    getEmpleadosPorSalario (salario):Observable <any>{
        let request = "/api/empleados/empleadossalario/";
        return this._httpService.get(this.url+request+salario);
    }
    getEmpleadosOficio (oficio):Observable <any>{
        let request = "/api/empleados/empleadosoficio/";
        console.log(this.url+request+oficio);
        return this._httpService.get(this.url+request+oficio);
    }
    getOficios ():Observable <any>{
        let request = "/api/empleados/oficios";
        return this._httpService.get(this.url+request);
    }
}