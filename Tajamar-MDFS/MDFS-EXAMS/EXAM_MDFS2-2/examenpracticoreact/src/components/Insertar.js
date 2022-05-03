import React, { Component, ElementRef } from "react";
import axios from "axios";
import { Redirect } from "react-router-dom";
import Global from "../global";
export default class Insertar extends Component {
  nombre = React.createRef();
  imagen = React.createRef();
  serie = React.createRef();

  state = {
    status: false,
    series: [],
  };
  send = (e) => {
    e.preventDefault();
    console.log("INSERTANDO");
    let nom = this.nombre.current.value;
    let imag = this.imagen.current.value;
    let serie = this.serie.current.value;

    let personaje = {
      idpersonaje: 0,
      nombre: nom,
      imagen: imag,
      IdSerie: parseInt(serie),
    };
    console.log(personaje);
    let resquest = "api/Personajes";
    axios.post(Global.url + resquest, personaje).then((res) => {
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
  };
  render() {
    if (this.state.status == true) {
      <Redirect to="/" />;
    }
    return (
      <div>
        {this.state.series != [] && (
          <form onSubmit={this.send}>
            <input placeholder="Nombre" type="string" ref={this.nombre} />
            <br />
            <input placeholder="URL Imagen" type="string" ref={this.imagen} />
            <br />
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
            <button class="btn btn-danger">Crear Personaje</button>
          </form>
        )}
      </div>
    );
  }
}
