import React, { Component } from "react";
import axios from "axios";
import Global from "./../../Global";
import {NavLink} from 'react-router-dom';
export default class DetallesDep extends Component {
  constructor(props) {
    super(props);
    this.setState({
      iddepartamento: props.iddepartamento,
    });
  }
  state = {
    departamento: {},
    status: false,
    iddepartamento: 0,
  };
  buscarDep = () => {
    let request = "/api/Departamentos/" + this.props.iddepartamento;
    let url = Global.urlDep + request;

    axios.get(url).then((res) => {
      this.setState({
        departamento: res.data,
        status: true,
      });
    });
  };
  componentDidMount = () => {
    this.buscarDep();
  };
  render() {
    return (
      <div>
        <h1>Detalles:</h1>
        {this.state.status == true && (
          <React.Fragment>
            <h4>Numero: {this.state.departamento.numero}</h4>
            <h4>Nombre: {this.state.departamento.nombre}</h4>
            <h4>Localidad: {this.state.departamento.localidad}</h4>
            <hr/>
            <NavLink 
            className="btn btn-success" to={
                "/update/" +
                this.state.departamento.numero +
                "/" +
                this.state.departamento.nombre +
                "/" +
                this.state.departamento.localidad
              }>Modificar</NavLink>
            <NavLink to={"/delete/"+this.state.departamento.numero}
            className="btn btn-danger">
              Eliminar
            </NavLink>
          </React.Fragment>
        )}
      </div>
    );
  }
}
