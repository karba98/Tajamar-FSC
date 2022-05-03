import React, { Component } from "react";
import axios from "axios";
import Global from "../../Global";
import Empleados from "./Empleados.js";

export default class Departamento extends Component {
  state = {
    selectDeps: [],
    departamentos: [],
    status: false,
    empleados: [],
  };
  departam = React.createRef();
  loadEmple = (e) => {
    this.setState({
      empleados: null,
    });
    e.preventDefault();
    let num = this.departam.current.value;
    let url = Global.urlEmple;
    let array = [];
    axios.get(url).then((res) => {
      res.data.map((emple, index) => {
        if (emple.departamento == num) {
          array.push(
            <Empleados
              key={emple.idEmpleado}
              empleN={emple.apellido}
              ide={emple.idEmpleado}
            />
          );
        }
      });
      this.setState({
        empleados: array,
        state: true,
      });
    });
  };
  componentWillMount = () => {
    let url = Global.urlDepartam;
    console.log(url);
    let array = [];
    let deps = [];
    axios.get(url).then((res) => {
      res.data.map((dep, i) => {
        array.push(
          <option key={dep.Numero} value={dep.Numero}>
            {dep.Nombre}
          </option>
        );
        deps.push(dep);
      });
      this.setState({
        status: true,
        departamentos: deps,
      });
    });
    this.setState({
      selectDeps: array,
    });
  };
  render() {
    return (
      <div>
        <h1>Empresa JSON</h1>
        <p style={{ fontSize: "10px" }}>
          *El unico fallo de este ejercico es que axios recupera los datos del
          json cada vez que seleccionamos un departamento
        </p>
        <p style={{ fontSize: "10px" }}>
          *en lugar de cargar todos los empleados en el componente Empleado
        </p>
        <form onSubmit={this.loadEmple}>
          <label>Departamento: </label>
          <select ref={this.departam}>
            {this.state.status == true && this.state.selectDeps}
          </select>
          <button>Muestra Empleados</button>
        </form>
        <hr />
        <ul>{this.state.status == true && this.state.empleados}</ul>
      </div>
    );
  }
}
