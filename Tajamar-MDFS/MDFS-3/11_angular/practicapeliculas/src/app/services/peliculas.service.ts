
import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Global} from './global';

@Injectable()
export class PeliculasService {

    private url: string;
    constructor(private _httpService:HttpClient){
        this.url=Global.url;
    }

    getGeneros ():Observable <any>{
        let request = "/api/Generos";
        return this._httpService.get(this.url+request);
    }
    getPeliculas (genero:string):Observable <any>{
        let request = "api/peliculasgenero/"+genero;
        return this._httpService.get(this.url+request);
    }
    getPeli(id):Observable<any>{
        let request = "/api/Peliculas?idpeli="+id;
        return this._httpService.get(this.url+request);
    }
    getAllPelis():Observable<any>{
        let request = "/api/Peliculas";
        return this._httpService.get(this.url+request);
    }
    getPeliByTitle(title):Observable<any>{
        let request = "/api/Peliculastitulo/"+title;
        return this._httpService.get(this.url+request);
    }
}