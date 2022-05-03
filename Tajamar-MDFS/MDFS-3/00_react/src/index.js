import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import reportWebVitals from './reportWebVitals';

//IMPORTS MODULOS

//00_REACT_Ejemplos  <App />
import App from './components/00_REACT_Ejemplo/App/App';
import Saludo from './components/00_REACT_Ejemplo/Saludo/Saludo';

//01_REACT_Ejercicio_Suma  <CompPadre/>
import CompPadre from './components/01_REACT_Suma/CompPadre';

//02_REACT_Hook_var  <Container/>
import Container from './components/02_REACT_Hook_var/container';

//03_REACT_EJER_Coche <Car/>
import Concesionario from './components/03_REACT_EJER_Coche/Concesionario';

ReactDOM.render(
  <React.StrictMode>
   <Concesionario/>
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
