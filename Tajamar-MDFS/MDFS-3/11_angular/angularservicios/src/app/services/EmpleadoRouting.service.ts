import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Global} from './global';

@Injectable()
export class EmpleadosRoutingService {

    private url: string;
    constructor(private _httpService:HttpClient){
        this.url=Global.urlEmpleados;
    }

    getEmpleados():Observable<any>{
        var request ="/api/empleados";
        return this._httpService.get(this.url+request);
    }
    buscarEmpleado(idempleado:string):Observable<any>{
        var request ="/api/empleados/"+idempleado;
        return this._httpService.get(this.url+request);
    }
    
}