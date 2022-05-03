import React, { Component } from "react";
import axios from "axios";
import Global from "./global";
import { NavLink } from "react-router-dom";
export default class Home extends Component {
  state = {
    departamentos: [],
    status: false,
  };
  getDepartamentos() {
    let req = "/api/Departamentos";
    axios.get(Global.url + req).then((res) => {
      this.setState({
        departamentos: res.data,
        status: true,
      });
    });
  }
  componentDidMount() {
    this.getDepartamentos();
  }
  render() {
    return (
      <div>
        {this.state.status == true && (
          <table>
            <thead>
              <tr>
                <th>Numero</th>
                <th>Nombre</th>
                <th>Localidad</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {this.state.departamentos.map((dep, index) => {
                return (
                  <tr key={index}>
                    <td>{dep.numero}</td>
                    <td>{dep.nombre}</td>
                    <td>{dep.localidad}</td>
                    <td>
                      <NavLink
                        to={"/eliminar/" + dep.numero}
                        className="btn btn-danger"
                      >
                        X
                      </NavLink>
                    </td>
                  </tr>
                );
              })}
            </tbody>
          </table>
        )}
      </div>
    );
  }
}
