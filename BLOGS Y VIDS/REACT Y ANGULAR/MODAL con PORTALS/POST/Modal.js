import React, { Component } from "react";
//importamos el portal que creamos anteriormente
import Portal from "./Portal";

export default class Modal extends Component {
  render() {
    //Nos ayudará a controlar el estado del modal (abierto, cerrado)
    //PROPS QUE RECIBIMOS DEL COMPONENTE QUE CREA EL MODAL
    //(EN ESTE CASO APP.JS)
    const { children, toggle, active } = this.props;
    return (
      //EL CONTENDIO DE PORTAL SE RENDERIZARÁ EN EL NUEVO DIV EN INDEX.HTML
      <Portal>
        {active && (
          <div style={styles.wrapper}>
            <div style={styles.window}>
              <button style={styles.closeBtn} onClick={toggle}>
                X
              </button>
              {/* renderizamos children (el contenido del render del portal )*/}
              <div>{children}</div>
            </div>
            {/**FONDO NEGRO CON ONCLICK */}
            <div onClick={toggle} style={styles.background} />
          </div>
        )}
      </Portal>
    );
  }
}

const styles = {
  wrapper: {
    position: "absolute",
    top: 0,
    left: 0,
    width: "100%",
    height: "100%",
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
  },
  window: {
    position: "relative",
    background: "#fff",
    border: 5,
    padding: 15,
    boxShadow: "2px 2px 10px rgba(0,0,0,3)",
    zIndex: 10,
    minWidth: 320,
  },
  closeBtn: {
    top: 0,
    right: -1,
  },
  background: {
    position: "absolute",
    width: "100%",
    height: "100%",
    top: 0,
    left: 0,
    background: "black",
    opacity: 0.4,
  },
};
