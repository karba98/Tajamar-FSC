import React, { Component } from 'react'

import{BrowserRouter,Route,Switch} from 'react-router-dom'
import Cine from './rutas/Cine'
import Musica from './rutas/Musica';
import Docs from './rutas/Docs'
import Home from './rutas/Home'
import Ejemploform from './Formularios/Ejemploform';
import Collatz from './07_react_ejer_collatz/Collatz';
import Comics from './Formularios/Comics/Comics';

export default class Router extends Component {
    render() {
        return (
            <BrowserRouter>
                <Switch>
                    <Route exact path="/" component={Home}/>
                    <Route exact path="/musica" component={Musica}/>
                    <Route exact path="/cine" component={Cine}/>
                    <Route exact path="/docs" component={Docs}/>
                    <Route exact path="/form" component={Ejemploform}/>
                    <Route exact path="/collatz" component={Collatz}/>
                    <Route exact path="/comics" component={Comics}/>
                </Switch>
            </BrowserRouter>
        )
    }
}
