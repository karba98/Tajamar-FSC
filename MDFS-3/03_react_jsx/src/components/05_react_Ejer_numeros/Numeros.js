import React, {Component} from 'react';
import Numero from './Numero'

export default class Numeros extends Component{
    state ={
        numeros:[5,7,2,9,2,4,78,56,4],
        res:0
    }
    incrementar = (numero)=>{
        this.setState({
            res:this.state.res+numero
        });
    }
    crearNumero =()=>{
        if(this.state.numeros.length>=20){
            alert("Demasiados numeros");
        }else{
            var arrnumeros = this.state.numeros;
            arrnumeros.push(parseInt(Math.random()*99));
            this.setState({
                numeros:arrnumeros
            });
        }
        
    }
    render(){
        return(
            <div style={{backgroundColor:"aquamarine",padding:"10px"}}>
                <h1>Ejercicio Numeros:</h1>
                <div style={{"marginLeft":"10px"}}>
                <h3>Suma: {this.state.res}</h3>
                {
                this.state.numeros.map((numero,index) =>{
                    return(
                    <Numero 
                    key={index}
                    numero={numero}
                    propIncrementar={this.incrementar}/>
                    );
                })}
                <br></br>
                {//ESTO 
                //<button onClick={this.crearNumero}> Nuevo numero</button>
                //ES LO MISMO QUE ESTO:
                }
                <button onClick={this.crearNumero}> Nuevo numero</button>
                {//PERO SI LO PONEMOS ASI
                //<button onClick={this.crearNumero()}> Nuevo numero</button>
                //SE LLAMARÁ CUADNO SE CREE EL COMPONENTE
                }
                </div>
                
            </div>
        );

    }
}