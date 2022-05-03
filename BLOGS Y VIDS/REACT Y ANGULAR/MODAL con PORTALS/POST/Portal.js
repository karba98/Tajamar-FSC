import React, { Component } from "react";
//importamos reactdom
import ReactDOM from "react-dom";

//cojemos el nuevo div creado en index.html
const portal = document.getElementById("portal");
export default class Portal extends Component {
  //en el constructor, creamos un nuevo div (que será el modal)
  constructor() {
    super();
    this.el = document.createElement("div");
  }
  //agragamos/quitamos el nuevo div modal segun
  //se monte o se desmonte nuestro componente
  componentDidMount = () => {
    portal.appendChild(this.el);
  };

  componentWillUnmount = () => {
    portal.removeChild(this.el);
  };
  render() {
    //Creamos el portal
    //Renderizaremos todo lo que haya en este componente
    //(lo que llamamos children)
    //dentro de el nuevo div creado
    const { children } = this.props;
    return ReactDOM.createPortal(children, this.el);
  }
}
