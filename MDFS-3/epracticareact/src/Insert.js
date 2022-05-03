import React, { Component, ElementRef } from "react";
import axios from "axios";
import { Redirect } from "react-router-dom";
export default class Insert extends Component {
  numero = React.createRef();
  nombre = React.createRef();
  localidad = React.createRef();

  state = {
    status: false,
  };
  return = () => {
    this.setState({
      status: true,
    });
  };
  send = (e) => {
    e.preventDefault();
    let num = this.numero.current.value;
    let nom = this.nombre.current.value;
    let loc = this.localidad.current.value;

    let departamento = {
      numero: num,
      nombre: nom,
      localidad: loc,
    };
    let url = "";
    axios.post(url, departamento).then((res) => {
      this.return();
    });
    console.log(departamento);
  };
  render() {
    if (this.state.status == true) {
      <Redirect to="/" />;
    }
    return (
      <div>
        <form onSubmit={this.send}>
          <input placeholder="Numero" type="number" ref={this.numero} />
          <input placeholder="Nombre" type="string" ref={this.nombre} />
          <input placeholder="Localidad" type="string" ref={this.localidad} />
          <button>Crear</button>
        </form>
      </div>
    );
  }
}
