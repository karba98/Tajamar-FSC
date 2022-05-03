import {Injectable} from '@angular/core';
import {Coche} from './../models/Coche';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Global} from './global';
@Injectable()
export class CocheService {
 
    private request:string;
    private url:string;

    constructor(private _htppClient: HttpClient){
        this.request = '/webresources/coches';
        this.url = Global.urlCoches+this.request;
    }
    getCoches() :Observable<any> {
        return this._htppClient.get(this.url);
    }
}