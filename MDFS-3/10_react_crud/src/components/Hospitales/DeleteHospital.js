import React, { Component } from 'react'
import axios from 'axios';
import {Redirect} from 'react-router-dom';
import Global from './../../global/Global';

export default class DeleteHospital extends Component {

    state={
        status:false
    }
    deleteHos=()=>{
        let request = "/webresources/hospitales/delete/"+this.props.id
        axios.delete(Global.url+request).then((res)=>{
            this.setState({
                status:true
            });
        });
    }
    return =()=>{
        this.setState({
            status:true
        })
    }
    render() {
        if(this.state.status==true){
            return <Redirect to="/"/>
        }
        return (
            <div style={{padding:"25px",marginTop:"35px"}}>
                <h1 style={{textAlign:"center"}}>¿Desea borrar Hospital {this.props.id}?</h1>
                <div style={{textAlign:"center",marginTop:"30px"}}>
                    <button type="button" className="btn btn-danger"
                    onClick={this.deleteHos}
                    >SI</button>
                    <button type="button" className="btn btn-success"
                    onClick={this.return}
                    >NO</button>
                </div>
            </div>
        )
    }
}
