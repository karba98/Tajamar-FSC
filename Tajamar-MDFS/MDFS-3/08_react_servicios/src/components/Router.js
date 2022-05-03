import React, { Component } from 'react'

import{BrowserRouter,Route,Switch} from 'react-router-dom'
import Home from './rutas/Home'
import Sink10 from '../../../08_react_servicios/src/components/Sink/Sink10';
import Game from './Game/Game';
import Customers from './customers/Customers';
import BuscadorCoches from './coches/BuscadorCoches';
import Departamento from './empresa/Departamento';
import EmpleadosDetalles from './empresa/EmpleadosDetalles';

export default class Router extends Component {
    render() {
        return (
            <div style={{padding:"25px"}}>
                <BrowserRouter>
                <Switch>
                    <Route exact path="/" component={Home}/>S
                    <Route exact path="/game" component={Game}/>
                    <Route exact path="/customers" component={Customers}/>
                    <Route exact path="/coches" component={BuscadorCoches}/>
                    <Route exact path="/empresa" component={Departamento}/>
                    <Route exact path="/empresa/empleado/:idemp"
                        render={props=>{
                            let idemp= props.match.params.idemp;
                            console.log("Id: "+idemp);
                            return <EmpleadosDetalles idemp={idemp}/>
                        }}
                    />
                </Switch>
            </BrowserRouter>
            </div>
            
        )
    }
}
