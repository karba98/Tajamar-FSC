import React, { Component } from "react";
import axios from "axios";
import Global from "./../../Global";
import { Redirect } from "react-router-dom";

export default class InsertDepartamento extends Component {
  state = {
    status: false,
  };
  numeroR = React.createRef();
  nombreR = React.createRef();
  localidadR = React.createRef();
  crearDep = (e) => {
    e.preventDefault();
    let numero = parseInt(this.numeroR.current.value);
    let nombre = this.nombreR.current.value;
    let localidad = this.localidadR.current.value;

    let request = "/api/Departamentos";
    let departamento = {
      numero: numero,
      nombre: nombre,
      localidad: localidad,
    };
    let url = Global.urlDep + request;
    axios.post(url, departamento).then((res) => {
      this.setState({
        status: true,
      });
    });
  };

  render() {
    if (this.state.status == true) {
      return <Redirect to="/" />;
    }
    return (
      <div>
        <h1>Nuevo departamento</h1>
        <hr />
        <form onSubmit={this.crearDep}>
          <label>Numero: </label>
          <input type="number" name="numero" ref={this.numeroR} />
          <br />
          <label>Nombre: </label>
          <input type="text" name="nombre" ref={this.nombreR} />
          <br />
          <label>Localidad: </label>
          <input type="text" name="localidad" ref={this.localidadR} />
          <br />
          <button className="btn btn-warning">Crear</button>
        </form>
      </div>
    );
  }
}
