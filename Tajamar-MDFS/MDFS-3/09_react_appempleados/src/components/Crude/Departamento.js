import React, { Component } from "react";
import axios from "axios";
import Global from "../../Global";

export default class Departamento extends Component {
  state = {
    departamentos: [],
    muestra: [],
    status: false,
  };
  cargarDeps = () => {
    let request = "/api/Departamentos";
    let url = Global.urlDep + request;
    console.log(url);
    let deps = [];
    let mues = [];
    axios.get(url).then((res) => {
      res.data.map((dep, i) => {
        deps.push(dep);
        mues.push(
          <tr key={i}>
            <td>{dep.Numero}</td>
            <td>{dep.Nombre}</td>
            <td>{dep.Localidad}</td>
          </tr>
        );
      });
      this.setState({
        departamentos: deps,
        muestra: mues,
        status: true,
      });
    });
  };

  componentDidMount = () => {
    this.cargarDeps();
    console.log(this.state.muestra);
  };

  render() {
    return (
      <div>
        <h1>Empresa</h1>
        <hr />
        {console.log(this.state.departamentos)}
        <table className="table">
          <thead className="thead-dark">
            <tr>
              <th>Numero</th>
              <th>Departamento</th>
              <th>localidad</th>
              <th>Accion</th>
            </tr>
          </thead>
          <tbody>
            {this.state.departamentos.map((td, index) => {
              return (
                <tr key={index}>
                  <td>{td.numero}</td>
                  <td>{td.nombre}</td>
                  <td>{td.localidad}</td>
                  <td>
                    <a href={"/details/" + td.numero}>Detalles</a>
                  </td>
                </tr>
              );
            })}
          </tbody>
        </table>
        {console.log(this.state.muestra)}
        <hr />
      </div>
    );
  }
}
