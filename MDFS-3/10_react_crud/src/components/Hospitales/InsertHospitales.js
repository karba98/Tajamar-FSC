
import React, { Component } from 'react'
import axios from 'axios';
import {Redirect} from 'react-router-dom';
import Global from './../../global/Global';

export default class InsertHospitales extends Component {
    
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

        let request = "/webresources/hospitales/post";

        let hospital = 
        {
            "idhospital": numero,
            "nombre": nombre,
            "direccion": direccion,
            "telefono": telefono,
            "camas": camas
        }
        console.log(hospital);
        axios.post(Global.url+request,hospital).then((res)=>{
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
                    <label>ID:</label><input className="form-control" type="number" ref={this.idR}/><br/>
                    <label>Nombre: </label><input className="form-control" type="text" ref={this.nombreR}/><br/>
                    <label>Direccion:</label> <input className="form-control" type="text" ref={this.direccionR}/><br/>
                    <label>Tlf: </label><input className="form-control" type="text" ref={this.telefonoR}/><br/>
                    <label>Camas: </label><input className="form-control" type="number" ref={this.camasR}/><br/>
                    <button className="btn btn-outline-dark">Crear</button>
                </form>
            </div>
        )
    }
}
