import { Serie } from './../../app/models/Serie';
import { SeriesService } from './../../app/services/series.service';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  @ViewChild("serie") serie:ElementRef;
  public series:Array<Serie>;
  constructor(private _service:SeriesService, private _router:Router) { }

  verSerie(){
    let s = this.serie.nativeElement.value;
    console.log(s);
    this._router.navigate(['serie',s]);
  }
  ngOnInit(): void {
    this._service.getSeries().subscribe((res)=>{
      this.series=res;
      console.log(this.series)
    },error=>{
      console.log(error);
    });
  }

}
