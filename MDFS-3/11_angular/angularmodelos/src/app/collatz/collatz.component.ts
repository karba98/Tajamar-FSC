import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router,Params} from '@angular/router';
@Component({
  selector: 'app-collatz',
  templateUrl: './collatz.component.html',
  styleUrls: ['./collatz.component.css']
})
export class CollatzComponent implements OnInit {

  public cong : Array<number>;
  public numero :number;
  public currentNum:number;
  constructor(private _activateRoute:ActivatedRoute, 
    private _route:Router) {
      this.cong =[];
     }

  ngOnInit(): void {
    this._activateRoute.params.subscribe((params:Params)=>{
      this.currentNum = params.numero;
      this.cong=[];
      if(params.numero!=null){
        console.log(params.numero);
        this.numero=parseInt(params.numero);
        this.cong.push(this.numero);
        while(this.numero!=1){
          if(this.numero%2==0){
            this.numero=this.numero/2;
          }else{
            this.numero=(this.numero*3)+1
          }
          this.cong.push(this.numero);
        }
        console.log(this.cong);
        
      }
      else{
        this.numero=0;
      }
    });
  }
  

}
