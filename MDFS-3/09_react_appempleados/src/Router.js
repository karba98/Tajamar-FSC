import React, { Component } from "react";

import { BrowserRouter, Route, Switch } from "react-router-dom";
import Departamento from "./components/Crude/Departamento";
import InsertDepartamento from "./components/Crude/InsertDepartamento";
import DetallesDep from "./components/Crude/DetallesDep";
import UpdateDep from "./components/Crude/UpdateDep";
import DeleteDep from "./components/Crude/DeleteDep";
import Menu from './routes/Menu';
export default class Router extends Component {
  render() {
    return (
      <div style={{ padding: "25px" }}>
        <BrowserRouter>
        <Menu />
          <Switch>
            <Route exact path="/" component={Departamento} />
            <Route exact path="/insert" component={InsertDepartamento} />
            <Route
              exact
              path="/details/:id"
              render={(props) => {
                let id = props.match.params.id;
                return <DetallesDep iddepartamento={id} />;
              }}
            />
            <Route
              exact
              path="/update/:idu/:nombre/:localidad"
              render={(props) => {
                let nombre = props.match.params.nombre;
                let localidad = props.match.params.localidad;
                let idu = props.match.params.idu;
                return (
                  <UpdateDep idu={idu} nombre={nombre} localidad={localidad} />
                );
              }}
            />
             <Route
              exact
              path="/delete/:idd"
              render={(props) => {
                let idd = props.match.params.idd;
                return (
                  <DeleteDep numero={idd} />
                );
              }}
            />
          </Switch>
        </BrowserRouter>
      </div>
    );
  }
}
