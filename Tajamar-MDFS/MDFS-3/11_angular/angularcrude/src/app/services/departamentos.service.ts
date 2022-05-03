import { Departamento } from './../models/departamento';

import {Injectable} from '@angular/core';
import {HttpClient,HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Global} from './global';

@Injectable()
export class DepartamentosService {

    private url: string;
    constructor(private _httpService:HttpClient){
        this.url=Global.url;
    }

    getDepartamentos():Observable <any>{
        let request = "/api/departamentos";
        return this._httpService.get(this.url+request);
    }
    insertDep(departamento:Departamento):Observable<any>{
        let request = "api/departamentos";
        let depJSON = JSON.stringify(departamento);
        let headers = new HttpHeaders().set("Content-Type", "application/json");
        return this._httpService.post(this.url+request,depJSON,{headers:headers});
    }
    deleteDep(id:string):Observable<any>{
        let request = "api/departamentos/"+id;
        return this._httpService.delete(this.url+request);
    }
    updateDep(departamento:Departamento):Observable<any>{
        let request = "api/departamentos";
        let depJSON = JSON.stringify(departamento);
        let headers = new HttpHeaders().set("Content-Type", "application/json");
        return this._httpService.put(this.url+request,depJSON,{headers:headers});
    }
    buscarDep(id:string):Observable<any>{
        let request = "/api/departamentos/"+id;
        return this._httpService.get(this.url+request);
    }
}