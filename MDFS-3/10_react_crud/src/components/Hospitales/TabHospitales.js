import React, { Component } from 'react'
import axios from 'axios';
import Global from '../../global/Global';
import {NavLink} from 'react-router-dom';
export default class TabHospitales extends Component {
    
    state={
        status:false,
        hospitales:[]
    }
    getHospitales = ()=>{
        let request = "/webresources/hospitales";
        let url = Global.url+request;
        console.log(url);
        axios.get(url).then((res)=>{
            console.log(res.data);
            this.setState({
                hospitales:res.data,
                status:true
            });
        });
    }
    componentDidMount = ()=>{
        this.getHospitales();
    }
    render() {
        return (
            <div style={{padding:"25px"}}>
                <hr/>
                {this.state.status==false &&(
                    <a>Cargando..</a>
                )}
                <h1>Hospitales disponibles</h1>
                <table className="table table-light">
                    <thead>
                        <tr>
                            <th></th>
                            <th scope="col">ID</th>
                            <th>Nombre</th>
                            <th>Direccion</th>
                            <th>Telefono</th>
                            <th>Camas</th>
                           

                        </tr>
                    </thead>
                    <tbody>
                        {this.state.status==true && (
                            this.state.hospitales.map((hos,index)=>{
                                return(
                                    <tr key={index}>
                                        <td><NavLink to={"/hospital/"+hos.idhospital} 
                                        className="btn btn-warning"
                                        >V</NavLink>
                                        <NavLink to={"/modificar/"+hos.idhospital+"/"
                                        +hos.nombre+"/"
                                        +hos.direccion+"/"
                                        +hos.telefono+"/"
                                        +hos.camas} 
                                        className="btn btn-success"
                                        >M</NavLink>
                                        <NavLink to={"/eliminar/"+hos.idhospital} 
                                        className="btn btn-danger"
                                        >X</NavLink>
                                        </td>
                                        <td>{hos.idhospital}</td>
                                        <td>{hos.nombre}</td>
                                        <td>{hos.direccion}</td>
                                        <td>+34 {hos.telefono}</td>
                                        <td>{hos.camas}</td>
                                        
                                    </tr>
                                )
                            })
                        )}
                    </tbody>
                </table>
            </div>
        )
    }
}
