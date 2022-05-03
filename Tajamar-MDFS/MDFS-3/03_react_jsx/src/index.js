import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './components/App/App';
import reportWebVitals from './reportWebVitals';

import MiClase from './components/03_class_ES6/MiClase';
//<MiClase titulo="soy una prueba de props: " inicio="10"/>

import Deportes from './components/04_react_deportes/Deportes';
//<Deportes/>

import Numeros from './components/05_react_Ejer_numeros/Numeros';
//<Numeros/>

import Comics from './components/06_react_Ejer_comics/Comics';
//<Comics/>

import Router from './components/Router';
import Menu from './components/rutas/Menu';
import './components/rutas/NavStyle.css';
//<Router/>

//<Sink/> ---> EXTRA

ReactDOM.render(
  <React.StrictMode>
    <Menu/>
    <Router/>
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
