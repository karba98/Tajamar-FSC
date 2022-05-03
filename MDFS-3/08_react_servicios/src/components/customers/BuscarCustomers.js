import React, { Component } from 'react'
import axios from 'axios';
import Global from './../../Global';
export default class BuscarCustomers extends Component {
    request  ="customers/";
    url = Global.urlNorthWind+this.request;

    cajacustomer =React.createRef();
    state = ({
        customer : {},
        status:null
    });
    buscar = (e)=>{
        this.setState({
            customer:{}
        });
        e.preventDefault();
        let idc = this.cajacustomer.current.value;
        let newurl = this.url+idc+".json";
        axios.get(newurl).then((res)=>{
            this.setState({
                customer:res.data.customer,
                status:true
            });
            
        });
    }
    render() {
        return (
            <div style={{backgroundColor:"black"
            ,color:"white",padding:"10px"}}>
                <form onSubmit={this.buscar}>
                    <label>Id customer: </label>
                    <input ref={this.cajacustomer} type="text" name="cajacustomer"></input>
                    <button>Buscar Customer</button>
                </form>
                {this.state.status==true &&
                (
                <div>
                    <h2>Company: {this.state.customer.companyName}</h2>
                <h2>Direccion: {this.state.customer.country}, {this.state.customer.address}</h2>
                    <h2>Oficio: {this.state.customer.contactTitle}</h2>
                    <h2>Nombre: {this.state.customer.contactName}</h2>
                </div>
                )}
            </div>
        )
    }
}
