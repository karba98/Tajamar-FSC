import React, { Component } from 'react'
import {BrowserRouter,Route,Switch} from 'react-router-dom';
import Menu from './routes/Menu';
import TabHospitales from './Hospitales/TabHospitales';
import DetailsHospital from './Hospitales/DetailsHospital';
import InsertHospitales from './Hospitales/InsertHospitales';
import UpdateHospital from './Hospitales/UpdateHospital';
import DeleteHospital from './Hospitales/DeleteHospital';

export default class Router extends Component {
    render() {
        return (
            <BrowserRouter>
                <Menu/>
                <Switch>
                    <Route exact path="/" component={TabHospitales}></Route>
                    <Route exact path="/hospital/:id"
                    render={(props) => {
                        let id = props.match.params.id;
                        return <DetailsHospital id={id} />;
                      }}
                    ></Route>
                    <Route exact path="/modificar/:id/:nombre/:direccion/:tlf/:camas"
                    render={(props) => {
                        let id = props.match.params.id;
                        let nombre = props.match.params.nombre;
                        let direccion = props.match.params.direccion;
                        let tlf = props.match.params.tlf;
                        let camas = props.match.params.camas;
                        return <UpdateHospital id={id} nombre={nombre}
                         direccion={direccion} tlf={tlf}
                         camas={camas} />;
                      }}
                    ></Route>
                     <Route exact path="/eliminar/:id"
                    render={(props) => {
                        let id = props.match.params.id;
                        return <DeleteHospital id={id} />;
                      }}
                    ></Route>
                    <Route exact path="/insert" component={InsertHospitales}></Route>
                </Switch>
            </BrowserRouter>
        )
    }
}
