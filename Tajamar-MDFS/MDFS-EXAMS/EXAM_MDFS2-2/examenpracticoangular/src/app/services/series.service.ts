import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Global} from './../../global/global';

@Injectable()
export class SeriesService{

    private url: string;
    constructor(private _httpService:HttpClient){
        this.url=Global.url;
    }

    getSeries ():Observable <any>{
        let request = "api/Series";
        return this._httpService.get(this.url+request);
    }
    getSerie (id):Observable <any>{
        let request = "api/Series/"+id;
        return this._httpService.get(this.url+request);
    }
}