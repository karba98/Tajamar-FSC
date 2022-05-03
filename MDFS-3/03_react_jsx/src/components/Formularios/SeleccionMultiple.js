import React, { Component } from 'react'

export default class SeleccionMultiple extends Component {
    seleccionMultiple = React.createRef();
    state={
        ingredientes : ["Leche","Huevos", "Cacao", "Avellanas","Azucar", "Unicornio"],
        seleccionados :""
    }
    mostrarSeleccionados = (e)=>{
        e.preventDefault();
        let datos = "";
        let options = this.seleccionMultiple.current.options;
        for(let i=0;i<options.length;i++){
            if(options[i].selected == true){
                datos+= options[i].value +", ";
            }
        }
        this.setState({
            seleccionados: datos
        });
    }
    generarOption = ()=>{
        let options = [];
        this.state.ingredientes.map((ingrediente, index) =>{
            options.push(
            <option key={index} value={ingrediente} >{ingrediente}</option>
            );
        });
        return options;
    }
    render(){
        return (
            <div>
                <h1 style={{marginLeft:"15px"}}>Seleccion Multiple:</h1>
                <form onSubmit={this.mostrarSeleccionados}>
                    <select
                    style={{marginLeft:"25px"}}
                    name="selecmultiple" sizse="10" multiple
                    ref={this.seleccionMultiple}>
                        {this.generarOption()}
                    </select>
                <button style={{marginLeft:"25px"}}>Mostrar Seleccionados</button>
                <h3 style={{marginLeft:"15px"}}>{this.state.seleccionados}</h3>
                </form>
            </div>
        )
    }
}
