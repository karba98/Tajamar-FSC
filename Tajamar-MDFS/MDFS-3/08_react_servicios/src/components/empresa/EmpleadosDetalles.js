import React, { Component } from "react";
import Global from "./../../Global";
import axios from "axios";
export default class EmpleadosDetalles extends Component {
  constructor(props) {
    super(props);
    console.log("detalle: " + this.props.idemp);
  }
  state = {
    empleado: {},
    status: false,
  };
  mostrarEmpleado = () => {
    let url = Global.urlEmple + "/" + this.props.idemp;
    console.log(url);
    axios.get(url).then((res) => {
      this.setState({
        empleado: res.data,
        status: true,
      });
    });
  };
  componentWillMount = () => {
    this.mostrarEmpleado();
  };
  render() {
    return (
      <div>
        <h2>Detalles de empleado:</h2>
        {this.state.status == true && (
          <div>
            <p style={{ color: "green" }}>
              Apellido: {this.state.empleado.apellido}
            </p>
            <p style={{ color: "blue" }}>
              Oficio: {this.state.empleado.oficio}
            </p>
            <p>Salario: {this.state.empleado.salario}€</p>
          </div>
        )}
      </div>
    );
  }
}
