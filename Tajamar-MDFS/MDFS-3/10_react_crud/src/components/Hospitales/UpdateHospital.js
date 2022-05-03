import React, { Component } from 'react'
import axios from 'axios';
import {Redirect} from 'react-router-dom';
import Global from './../../global/Global';

export default class UpdateHospital extends Component {
    
    state={
        status:false
    }
    idR = React.createRef();
    nombreR = React.createRef();
    direccionR = React.createRef();
    telefonoR = React.createRef();
    localidadR = React.createRef();
    camasR= React.createRef();

    newHospital = (e)=>{
        e.preventDefault();
        let numero = parseInt(this.idR.current.value);
        let nombre = this.nombreR.current.value;
        let direccion = this.direccionR.current.value;
        let telefono = this.telefonoR.current.value;
        let camas = parseInt(this.camasR.current.value);

        let request = "/webresources/hospitales/put";

        let hospital = 
        {
            "idhospital": numero,
            "nombre": nombre,
            "direccion": direccion,
            "telefono": telefono,
            "camas": camas
        }
        console.log(hospital);
        axios.put(Global.url+request,hospital).then((res)=>{
            this.setState({
                status:true
            });
        });
    }

    render() {
        if(this.state.status==true){
            return <Redirect to="/"/>
        }
        return (
            <div className="form-group" style={{padding:"25px"}}>
                <form onSubmit={this.newHospital}>
                    <label>ID:</label><input defaultValue={this.props.id} className="form-control" type="number" ref={this.idR}/><br/>
                    <label>Nombre: </label><input defaultValue={this.props.nombre} className="form-control" type="text" ref={this.nombreR}/><br/>
                    <label>Direccion:</label> <input defaultValue={this.props.direccion} className="form-control" type="text" ref={this.direccionR}/><br/>
                    <label>Tlf: </label><input defaultValue={this.props.tlf} className="form-control" type="text" ref={this.telefonoR}/><br/>
                    <label>Camas: </label><input defaultValue={this.props.camas} className="form-control" type="number" ref={this.camasR}/><br/>
                    <button className="btn btn-outline-success">Modificar</button>
                </form>
            </div>
        )
    }
}
