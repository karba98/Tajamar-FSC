import React, { Component } from 'react'
import axios from 'axios';
import BuscarCustomers from './BuscarCustomers';
import Global from '../../Global';

export default class Customers extends Component {

    request ="customers.json";
    url = Global.urlNorthWind+this.request;
    state = {
        customers: [],
        status:null
    }
    cargarClientes = () => {
        axios.get(this.url).then(res => {
            console.log(res.data.customers);
            this.setState({
                customers: res.data.customers
            });
            this.setState({status:"success"});
        });
    }
    componentWillMount = () => {
        this.cargarClientes();
    }
    render() {
        if(this.state.customers.length>0){
            return (
                <div>
                    <BuscarCustomers/>
                    <h1>Customer JSON</h1>
                    {this.state.customers.map(cliente => {
                    return (<h2 key={cliente.id}>
                        {cliente.id}, {cliente.contactName}
                    </h2>);
                    })};
                </div>
            )
        }else if(this.state.customers==0){
            return(
                <h1>Cargando Datos...</h1>
            );
        }else if(this.state.status!="success"){
            alert("No hemos cargado clientes");
        }else{
            <h1>Algo salió mal</h1>
        }
        
    }
        
}
