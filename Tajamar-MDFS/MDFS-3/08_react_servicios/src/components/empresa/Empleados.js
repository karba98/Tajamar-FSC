import React, { Component } from "react";
import axios from "axios";
import Global from "../../Global";

export default class Empleados extends Component {
  render() {
    return (
      <li style={{ listStyle: "none" }}>
        <a href={"/empresa/empleado/" + this.props.ide}>{this.props.empleN}</a>
      </li>
    );
  }
}
