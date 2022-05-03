import logo from './logo.svg';
//SE IMPORTA AL COMPONENTE UN CSS
import './App.css';

import Saludo from './../Saludo/Saludo';

function App() {

  //En los () podemos cambiarlos por parametros en caso de que queramos pasarlos
  //const metodoDePadre = () =>{ ... }
  const metodoDePadre = (descripcion) => {
    console.log("Metodo del padre: "+descripcion);
    
  }

  //TIENE QUE DEVOLVER UN HTML
  return (
    <div className="App">

<h1>Primer Ejemplo REACT</h1>
      <div>
        <h1>Metodo De Padre:</h1>
        <Saludo name="Raul" edad="22" metodo ={metodoDePadre}/>

      </div>

{/**
 *  <div className="App">
        <Saludo name="Lucia" edad="21"  metodo ={metodoDePadre}/>
        <Saludo name="Maria" edad="25"  metodo ={metodoDePadre}/>
        <Saludo name="Pepe" edad="15"  metodo ={metodoDePadre}/>
        <Saludo name="Juan" edad="18"  metodo ={metodoDePadre}/>
      </div>
      <hr></hr>
 * 
 */}
     
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <h1>PRUEBA REACT</h1>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
      
    </div>
  );
}

export default App;
