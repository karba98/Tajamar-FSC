import React, { Component } from "react";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import Home from "../components/Home";
import Insertar from "../components/Insertar";
import Personajes from "../components/Personajes";
import Serie from "../components/Serie";
import Modificar from "../components/Modificar";
export default class Router extends Component {
  render() {
    return (
      <BrowserRouter>
                        
        <Switch>
          <Route exact path="/" component={Home} />
          <Route exact path="/insertar" component={Insertar} />
          <Route exact path="/modificar" component={Modificar} />
          <Route
            exact
            path="/serie/:serie"
            render={(props) => {
              var serie = props.match.params.serie;
              console.log("serie " + serie);
              return <Serie serie={serie} />;
            }}
          />
          <Route
            exact
            path="/personajes/:serie"
            render={(props) => {
              var serie = props.match.params.serie;
              console.log("serie " + serie);
              return <Personajes serie={serie} />;
            }}
          />
             
        </Switch>
                    
      </BrowserRouter>
    );
  }
}
/*
<Route exact path="/" component={} />
          

<NavLink to={"/loquesea"}>Ir a esto</NavLink>  
*/
