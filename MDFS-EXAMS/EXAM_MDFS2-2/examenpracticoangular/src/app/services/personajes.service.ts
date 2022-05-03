import { Personaje } from './../models/Personaje';
import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Global} from './../../global/global';

@Injectable()
export class PersonajesService{

    private url: string;
    constructor(private _httpService:HttpClient){
        this.url=Global.url;
    }

    getPersonajes ():Observable <any>{
        let request = "api/Personajes";
        return this._httpService.get(this.url+request);
    }
    postPersonaje(personaje:Personaje):Observable<any>{
        let request = "api/Personajes";
        let perJSON = JSON.stringify(personaje);
        console.log(perJSON);
        let headers = new HttpHeaders().set("Content-Type", "application/json");
        console.log("URLEEEEE: "+this.url+request);
        return this._httpService.post(this.url+request,perJSON,{headers:headers});
    }
    putPersonaje(idpersonaje,idserie):Observable<any>{
        console.log("idserie: "+idserie+" idperson: "+idpersonaje);
        let request = "api/Personajes/"+idpersonaje+"/"+idserie;
        let headers = new HttpHeaders().set("Content-Type", "application/json");
        console.log("URLEEEEE: "+this.url+request);
        return this._httpService.put(this.url+request,{headers:headers});
    }
    
    
}