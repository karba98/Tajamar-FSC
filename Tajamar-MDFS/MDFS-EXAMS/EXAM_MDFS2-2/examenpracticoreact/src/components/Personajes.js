import React, { Component } from "react";
import axios from "axios";
import Global from "../global";
import { NavLink } from "react-router-dom";
export default class Personajes extends Component {
  state = {
    personajes: [],
    status: true,
  };
  componentDidMount = () => {
    let request = "/api/Series/PersonajesSerie/" + this.props.serie;
    axios.get(Global.url + request).then((res) => {
      this.setState({
        personajes: res.data,
        status: true,
      });
    });
  };
  render() {
    return (
      <div style={{ padding: "15px" }}>
        {this.state.status == true && (
          <table>
            <thead>
              <tr>
                <th>Nombre</th>
                <th>Imagen</th>
              </tr>
            </thead>
            <tbody>
              {this.state.personajes.map((per, index) => {
                return (
                  <tr>
                    <td>{per.nombre}</td>
                    <td>
                      <img
                        style={{ width: "400px", height: "300px" }}
                        src={per.imagen}
                        alt={per.imagen}
                      />
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
