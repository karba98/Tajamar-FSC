import React, { Component } from "react";
export default class Menu extends Component {
  render() {
    return (
      <div>
        <nav>
          <ul className="topnav">
            <li>
              <a style={{ color: "white", textDecoration: "none" }} href="/">
                Home
              </a>
            </li>
            <li>
              <a
                style={{ color: "white", textDecoration: "none" }}
                href="/game"
              >
                Game
              </a>
            </li>
            <li>
              <a
                style={{ color: "white", textDecoration: "none" }}
                href="/customers"
              >
                Customers JSON
              </a>
            </li>
            <li>
              <a
                style={{ color: "white", textDecoration: "none" }}
                href="/coches"
              >
                Coches JSON
              </a>
            </li>
            <li>
              <a
                style={{ color: "white", textDecoration: "none" }}
                href="/empresa"
              >
                Empresa JSON
              </a>
            </li>
          </ul>
        </nav>
      </div>
    );
  }
}
