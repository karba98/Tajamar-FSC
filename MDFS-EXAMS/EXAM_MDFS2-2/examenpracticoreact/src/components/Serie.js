import React, { Component } from "react";
import axios from "axios";
import Global from "../global";
import { NavLink } from "react-router-dom";

export default class Serie extends Component {
  state = {
    status: false,
    serie: null,
  };

  componentDidMount = () => {
    let request = "api/Series/" + this.props.serie;
    axios.get(Global.url + request).then((response) => {
      this.setState({
        serie: response.data,
        status: true,
      });
    });
  };
  render() {
    return (
      <div>
        {this.state.status == true && (
          <div>
            <h1>{this.state.serie.nombre}</h1>
            <img
              style={{ width: "400px", height: "300px" }}
              src={this.state.serie.imagen}
              alt={this.state.serie.imagen}
            ></img>
            <h2>{this.state.serie.anyo}</h2>
            <NavLink
              className="btn btn-info"
              to={"/personajes/" + this.state.serie.idSerie}
            >
              Ver personajes
            </NavLink>
          </div>
        )}
      </div>
    );
  }
}
