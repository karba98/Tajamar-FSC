import logo from "./logo.svg";
import "./App.css";
import Modal from "./Modal";
import React, { useState } from "react";
function App() {
	//VARIBLE DE ESTADO
  const [active, setActive] = useState(false);

  const toggle = () => {
    setActive(!active);
  };
  return (
    <div className="App">
      <button onClick={toggle}> Abrir Modal</button>
      <Modal active={active} toggle={toggle}>
	  //{children}
        <h1>Modal funciona</h1>
      </Modal>
    </div>
  );
}

export default App;
