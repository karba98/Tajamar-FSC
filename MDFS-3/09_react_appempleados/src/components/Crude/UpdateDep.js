import React, { Component } from "react";
import axios from 'axios';
import Global from './../../Global';
import Axios from "axios";
import {Redirect} from 'react-router-dom';

export default class UpdateDep extends Component {

  cajaNumRef = React.createRef();
  cajaNomRef = React.createRef();
  cajaLocRef = React.createRef();

  state={
    status:false
  }
  modDep = (e)=>{
    e.preventDefault();
    let request = "/api/Departamentos";
    let url = Global.urlDep+request;

    let num = parseInt(this.cajaNumRef.current.value);
    let nom = this.cajaNomRef.current.value;
    let loc = this.cajaLocRef.current.value;

    let newDep ={
      numero:num,
      nombre:nom,
      localidad:loc
    }
    console.log(newDep);
    axios.put(url,newDep).then((res)=>{
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
      <div>
        <h1>Modificar departamento: {this.props.idu}</h1>
        <form onSubmit={this.modDep}>
          <label>Num</label>
          <input type="number" className="form-control"
           defaultValue={this.props.idu}ref={this.cajaNumRef}/>
          <br/>
          <label>Nombre</label>
          <input type="text" className="form-control"
           defaultValue={this.props.nombre}ref={this.cajaNomRef}/>
          <br/>
          <label>Localizacion</label>
          <input type="text" className="form-control"
           defaultValue={this.props.localidad}ref={this.cajaLocRef}/>
          <br/>
          <button className="btn btn-warning">Modificar</button>
        </form>
      </div>
    );
  }
}
