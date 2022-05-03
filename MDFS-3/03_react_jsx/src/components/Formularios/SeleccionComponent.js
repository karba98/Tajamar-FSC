/*import React, { Component } from 'react'
import Select from 'react-select';
export default class SeleccionComponent extends Component {

    constructor(props){
        super(props);
        this.state ={
            ingredientes : ["Leche","Huevos", "Cacao", "Avellanas","Azucar", "Unicornio"],
            selectedOptions :null,
            opciones:[],
            seleccionados: "",
            multiselect :[]
        }
    }

    componentWillMount = () =>{
        this.generarOption();
    } 
    generarOption = ()=>{
        var datos =[];
        this.state.ingredientes.map((ingrediente, index)=>{
            datos.push(
                {
                    value:ingrediente,
                    label:ingrediente
                }
            );
        });
        this.setState({
            opciones:datos
        });
    }

    mostrarSeleccionado = (seleccionado) =>{
        let ops = this.state.multiselect;
        seleccionado.map((elem,i)=>{
            ops.push(
            <li>{elem.value}</li>
            );
        });
        this.setState({
            multiselect:ops
        });
    }
    render() {
        return (
            <div>
                <h1>Select como componente externo</h1>
                <Select  value = {this.state.selectedOptions}
                isMulti={false}
                onChange={this.mostrarSeleccionado}
                options={this.state.opciones}/>
                <h3>{this.state.ops}</h3>
            </div>
        )
    }
}*/
