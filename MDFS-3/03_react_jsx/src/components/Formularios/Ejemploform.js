import React, { Component } from 'react'
import SeleccionSimple from './SeleccionSimple';
import SeleccionMultiple from './SeleccionMultiple';
import SelecccionComponent from './SeleccionComponent';
import Comics from './Comics/Comics';

export default class Ejemploform extends Component {

    state ={
        usuario: {}
    }
    nombre = React.createRef();
    apellidos = React.createRef();

    recibirDatosForm = (e)=>{
        e.preventDefault();
        console.log(
        "Nombre: "+this.nombre.current.value+
        " Apellidos:"+this.apellidos.current.value);
        this.setState({
            usuario:{
                nombre:this.nombre.current.value,
                apellido:this.apellidos.current.value,
            }
        });
    }
    render() {
        return (
            <div>
                <SeleccionMultiple/>
                <SeleccionSimple/>
                <div>
                    <h1
                    style={{marginLeft:"20px"}}>Ejemplo formulario:</h1>
                    {this.state.usuario.nombre &&
                    (<div>
                        <h2 style={{marginLeft:"30px"}}
                        >{this.state.usuario.nombre} 
                        , {this.state.usuario.apellido}</h2>
                    </div>)}
                    <form
                    style={{marginLeft:"30px"}}
                    onSubmit={this.recibirDatosForm}>
                        <label>Nombre: </label>
                        <input 
                        onChange={this.recibirDatosForm}
                        type="text" ref={this.nombre} name="nombre"/>
                        <br/>
                        <label>Apellido: </label>
                        <input 
                        onChange={this.recibirDatosForm}
                        type="text" ref={this.apellidos} name="apellidos"/>
                        <br/>
                        <button style={{marginTop:"15px"}}>Enviar </button>
                    </form>
                
                </div>
            </div>
        )
    }
}
