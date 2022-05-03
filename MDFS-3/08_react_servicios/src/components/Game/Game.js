import React, { Component } from 'react'
import './tablero.css';
import Barco from './Barco';
import Agua from './Agua';
export default class Game extends Component {
    /*
    Son en total 5 naves:
    1 de cinco casillas;
    1 de cuatro casillas;
    2 de tres casillas;
    1 de dos casillas.
    */ 
    state={
        matriz:[],
        cuadricula:15,
        tablero:[]
    }
    componentWillMount = ()=>{
        let array = [];
        for(let i=0;i<this.state.cuadricula;i++){
            let line =[];
            for(let j=0;j<this.state.cuadricula;j++){
                let val = 0;
                line.push(val);
            }
            array.push(line);
        }
        this.setState({
            matriz:array
        });
        
    }
    componentDidMount = ()=>{
        this.setBarcos();
    }
    setBarcos =()=>{
        let tablero = this.state.matriz;
        for(let i=0;i<5;i++){
            let x = parseInt(Math.random()*11);
            let y = parseInt(Math.random()*11);
            try{
                if(tablero[y][x]==0 &&tablero[y-1][x]==0 &&tablero[y-1][x+1]==0 &&
                tablero[y][x+1]==0 && tablero[y+1][x]==0 && tablero[y+1][x+1]==0 &&
                tablero[y+1][x-1]==0 &&tablero[y][x-1]==0 &&tablero[y-1][x-1]==0 ){
                    tablero[y][x]=1
                }else{i--;}
            }catch(e){ i--;}
        }
        console.log(this.state.matriz);
    }

    render() {
        return (
            <div>
                <div className="marcador">
                <img alt= ""style={{float:"left",marginTop:"7px"}} 
                id="TU"className="imagen"/>
                    <a>TU ---- {} - {} ---- CPU </a>
                    <img alt=""style={{float:"right",marginTop:"7px"}}  
                    id="IA"className="imagen"/>
                </div>
                <div className="marcador">RESET</div>
                <div 
                    style={{backgroundColor:"black", color:"white"}}
                    className="marcador">TURNO</div>
                <div>
                    <table  id="tablero">
                        <tbody>
                            {this.state.tablero}
                        </tbody>
                    </table>
                </div>
            </div>
        )
    }
}
