import { Serie } from './../../app/models/Serie';
import { SeriesService } from './../../app/services/series.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-series',
  templateUrl: './series.component.html',
  styleUrls: ['./series.component.css']
})
export class SeriesComponent implements OnInit {

  public serie:Serie
  public ids:string;
  constructor(private _activeroute:ActivatedRoute, private _service:SeriesService) { }

  ngOnInit(): void {
    this._activeroute.params.subscribe((params:Params)=>{
      this.ids=params.id;
      console.log("id recibido: "+this.ids);

      this._service.getSerie(this.ids).subscribe(res=>{
        this.serie=res;
        console.log(this.serie);
      });
    })
  }

}
