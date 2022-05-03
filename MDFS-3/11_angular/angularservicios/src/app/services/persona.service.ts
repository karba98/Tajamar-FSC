import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Persona} from './../models/Persona';
import {Global} from './global';

@Injectable()
export class PersonaService{
    private request:string;
    private url:string;

    constructor(private _htppClient: HttpClient){
        this.request = '/api/personas';
        this.url = Global.url+this.request;
    }
    mostrarMensaje(){
        console.log(this.url);
    }
    getPersonas() :Observable<any> {
        return this._htppClient.get(this.url);
    }
}