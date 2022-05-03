import React, { Component } from 'react'
import axios from 'axios';
import Global from './../../Global';
import {Redirect} from 'react-router-dom';

export default class DeleteDep extends Component {
    state ={
        status:false
    }
    deleteDep =()=>{
        let request = "/api/Departamentos/"+this.props.numero
        axios.delete(Global.urlDep+request).then((res)=>{
            this.setState({
                status:true
            });
        });
    }
    goHome = ()=>{
        this.setState({
            status:true
        });
    }
    render() {
        if(this.state.status==true){
            return <Redirect to="/"/>
        }
        return (
            <div>
                <h1>¿Deseas eliminar departamento: {this.props.numero}?</h1>
                <button className="btn btn-danger" onClick={this.deleteDep}>SI</button>
                <button className="btn btn-warning" onClick={this.goHome}>NO</button>
            </div>
        )
    }
}
