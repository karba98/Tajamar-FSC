import React, {useState} from 'react';

function Container(){

    var style = {"padding":"10px","backgroundColor":"grey"};

    const [numero,setNumero] = useState(0);
    //useState por DEFAULT EN ESTE CASO 0
    //PARA AGREGARLO UN CAMBIO DE ESTADO
    //[NOMBRE DE VARIABLE, METODO DE CAMBIO]
    //LOS CORCHETES SON POR SER UNA VARIABLE "DE CAMBIO DE ESTADO"
    //YA QUE EN REACT var numero =99 POR EJEMPLO, ES SOLO DE LECTURA
    const reset =()=>{
        setNumero(0);

    }
    return(
        <div style={style}>
            <h1>Hooks en React:</h1>
            <p>Vamos a cambiar variables dinamicamente en REACT</p>
            <br></br>
            <h2>Numero ahora mismo: {numero}</h2>
            <button type="button" onClick={()=>{
                //BOTON CON FUNCION ANÓNIMA
                setNumero(numero+1);
            }}>Incrementar numero</button>
            {
            //IMPORTAMOS React {useState} from 'react'
            }
             <button type="button" onClick={()=>{reset()}}>Reset</button>
        </div>

    );
}
export default Container;