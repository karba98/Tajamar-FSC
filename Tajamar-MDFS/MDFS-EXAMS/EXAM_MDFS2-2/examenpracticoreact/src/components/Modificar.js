import React, { Component, ElementRef } from "react";
import axios from "axios";
import { Redirect } from "react-router-dom";
import Global from "../global";
export default class Modificar extends Component {
  personaje = React.createRef();
  serie = React.createRef();
  nombreP = "";
  imagenP = "";
  state = {
    status: false,
    series: [],
    personajes: [],
  };
  send = (e) => {
    e.preventDefault();
    console.log("INSERTANDO");
    let serie = this.serie.current.value;
    let personaje = this.personaje.current.value;
    let resquest = "api/Personajes";

    for (let p in this.state.personajes) {
      if (p.idPersonaje == personaje) {
        this.nombreP = p.nombre;
        this.imagenP = p.imagen;
      }
    }
    let newPersonaje = {
      idPersonaje: 0,
      nombre: this.nombreP,
      imagen: this.imagenP,
      IdSerie: parseInt(serie),
    };
    console.log(newPersonaje);
    axios.put(Global.url + resquest, newPersonaje).then((res) => {
      this.volver();
    });
  };
  volver = () => {
    this.setState({
      status: true,
    });
  };

  componentDidMount = () => {
    console.log("MONTANDOOOOO");
    let request = "api/Series";
    axios.get(Global.url + request).then((response) => {
      this.setState({
        series: response.data,
      });
      console.log(response.data);
    });

    let newrequest = "api/Personajes";
    axios.get(Global.url + newrequest).then((response) => {
      this.setState({
        personajes: response.data,
      });
      console.log(response.data);
    });
  };
  render() {
    if (this.state.status == true) {
      <Redirect to="/" />;
    }
    return (
      <div>
        {this.state.series != [] && (
          <form onSubmit={this.send}>
            <select ref={this.personaje}>
              {this.state.personajes.map((personaje, index) => {
                return (
                  <option key={index} value={personaje.idPersonaje}>
                    {personaje.nombre}
                  </option>
                );
              })}
            </select>
            <select ref={this.serie}>
              {this.state.series.map((serie, index) => {
                return (
                  <option key={index} value={serie.idSerie}>
                    {serie.nombre}
                  </option>
                );
              })}
            </select>
            <br />
            <button class="btn btn-danger">Mover Personaje</button>
          </form>
        )}
      </div>
    );
  }
}
