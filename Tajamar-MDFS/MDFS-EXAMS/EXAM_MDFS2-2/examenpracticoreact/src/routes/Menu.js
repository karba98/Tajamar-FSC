import React, { Component } from "react";
import axios from "axios";
import Global from "../global";
import { NavLink } from "react-router-dom";

export default class Menu extends Component {
  state = {
    status: false,
    series: [],
  };

  selectserie = React.createRef();
  componentDidMount = () => {
    let request = "api/Series";
    axios.get(Global.url + request).then((response) => {
      this.setState({
        series: response.data,
        status: true,
      });
    });
  };

  render() {
    return (
      <div>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
          <a class="navbar-brand" href="#">
            Navbar
          </a>
          <button
            class="navbar-toggler"
            type="button"
            data-toggle="collapse"
            data-target="#navbarNavDropdown"
            aria-controls="navbarNavDropdown"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarNavDropdown">
            <ul class="navbar-nav">
              <li class="nav-item active">
                <a class="nav-link" href="/">
                  Home <span class="sr-only">(current)</span>
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="/insertar">
                  Insertar Personaje
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="/modificar">
                  Modificar Personaje
                </a>
              </li>
              <li class="nav-item dropdown">
                <a
                  class="nav-link dropdown-toggle"
                  href="#"
                  id="navbarDropdownMenuLink"
                  data-toggle="dropdown"
                  aria-haspopup="true"
                  aria-expanded="false"
                >
                  Series
                </a>
                <div
                  class="dropdown-menu"
                  aria-labelledby="navbarDropdownMenuLink"
                >
                  {this.state.series.map((serie, index) => {
                    return (
                      <a
                        key={index}
                        class="dropdown-item"
                        href={"/serie/" + serie.idSerie}
                      >
                        {serie.nombre}
                      </a>
                    );
                  })}
                </div>
              </li>
            </ul>
          </div>
        </nav>
      </div>
    );
  }
}
