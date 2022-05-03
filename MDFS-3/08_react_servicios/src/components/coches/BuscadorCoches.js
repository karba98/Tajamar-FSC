import React, { Component } from 'react'
import axios from 'axios';
import Global from './../../Global';
import './coches.css';

export default class BuscadorCoches extends Component {

    state ={
        coches:[],
        muestraCoches:[],
        status :null,
    }
    cajaBuscar = React.createRef();
    componentWillMount =()=>{
        this.cargarCoches();
    }
    cargarCoches =()=>{
        let request ="coches";
        axios.get(Global.urlCoches+request).then((res)=>{
            let micoches = [];
            res.data.map((coche,index) =>{
                micoches.push(
                    <div className="midiv">
                        <a target="_blank">
                        <img src={coche.imagen} alt={coche.imagen} width="300" 
                        height="200"/>
                        </a>
                        <div class="desc">
                            <a>{coche.marca} {coche.modelo}</a><br></br>
                            <a>conductor: {coche.conductor}</a>
                        </div>
                    </div>
                
                );
            });
            console.log(micoches);
            this.setState({
                muestraCoches:micoches,
                coches:res.data,
                status:true
            })
        });
    }
    buscarCoches = (e)=>{
        e.preventDefault();
        let marca = this.cajaBuscar.current.value.toUpperCase();
        let newCoches =[];
        if(marca==""){
            this.cargarCoches();
        }else{

        }
        this.state.coches.map((coche,index)=>{
            //let filtro = this.state.coches.filter(car=>car.marca.toLowerCase()
            //.includes(marca));
            //this.setState({
            //muestracoches:filtro
            //});
            if(coche.marca==marca){
                newCoches.push( 
                    <div
                        className="midiv"
                        key={coche.idcoche}>
                        <a target="_blank">
                        <img src={coche.imagen} alt={coche.imagen} width="300" 
                        height="200"/>
                        </a>
                        <div class="desc">
                            <a>{coche.marca} {coche.modelo}</a><br></br>
                            <a>conductor: {coche.conductor}</a>
                        </div>
                    </div>
            
                );
            }
            
        });
        if(newCoches.length!=0){
            this.setState({
                muestraCoches:[]
            });
            this.setState({
                muestraCoches:newCoches
            });
        }
        

    }
    render() {
        return (
            <div>
                <h1>Coches JSON:</h1>
                <form onSubmit={this.buscarCoches}>
                    <label>Buscar Marca: </label>
                    <input type="text" ref={this.cajaBuscar}></input>
                    <button>Buscar</button>
                </form>
                <hr/>
                <div className="container">
                    {this.state.muestraCoches}
                    
                </div>
                
            </div>
        )
    }
}
