import React, { Component } from "react";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import Menu from "./Menu";
import Home from "./Home";
import Delete from "./delete";
import Insert from "./Insert";
export default class Router extends Component {
  render() {
    return (
      <BrowserRouter>
        <Menu />
        <Switch>
                             
          <Route exact path="/" component={Home} />
          <Route exact path="/insertar" component={Insert} />
          <Route
            exact
            path="/eliminar/:id"
            render={(props) => {
              let id = props.match.params.id;
              return <Delete id={id} />;
            }}
          />
        </Switch>
      </BrowserRouter>
    );
  }
}
