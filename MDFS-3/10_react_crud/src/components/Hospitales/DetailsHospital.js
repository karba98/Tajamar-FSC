import Axios from 'axios';
import React, { Component } from 'react'
import Global from './../../global/Global';
export default class DetailsHospital extends Component {

    state={
        status:false,
        hospital:{}
    }
    getHospital=()=>{
        let request = "/webresources/hospitales/"+this.props.id;
        Axios.get(Global.url+request).then((res)=>{
            this.setState({
                status:true,
                hospital:res.data
            });
        });
    }
    componentDidMount = ()=>{
        this.getHospital();
    }
    render() {
        return (
            <div style={{padding:"25px"}}>
                {this.state.status==false &&(
                    <h1>Cargando datos...</h1>
                )}
                <table className="table table-striped table-dark">
                       {this.state.status==true &&(
                           <tbody>
                           <tr><td>ID: {this.state.hospital.idhospital}</td></tr>
                           <tr><td>Nombre: {this.state.hospital.nombre}</td></tr>
                           <tr><td>Direccion: {this.state.hospital.direccion}</td></tr>
                           <tr><td>Tlf: +34 {this.state.hospital.telefono}</td></tr>
                           <tr><td>Camas: {this.state.hospital.camas}</td></tr>
                           </tbody>
                       )}
                </table>
            </div>
        )
    }
}
