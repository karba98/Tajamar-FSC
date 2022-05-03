
import React, {useState} from 'react';

function Car (props){
    const{marca,modelo, vmax, acel}=props;
    //Objeto coche para que el parent pase solo un objeto coche
    var coche = {
        marca:props.marca,
        modelo:props.modelo,
        vmax : props.vmax,
        acel : props.acel

    }
    const [arrancado, setArrancado] = useState(false);
    const [velocidad, setVelocidad] = useState(0);
    const comprobarArrancado =() =>{
        if(arrancado==true){
            return(
                <h2>Motor arrancado</h2>
            );
        }
        else{
            return (
                <h2>Motor apagado</h2>
            );
        }
    }
    const acelerar =()=>{
        
        if(velocidad>=coche.vmax){
            alert("Reduce velocidad");
        }else{
            if(arrancado==true){setVelocidad(velocidad+parseInt(coche.acel))};
        }
    }
    const frenar = () =>{
        if(velocidad!=0 && arrancado==true){setVelocidad(velocidad-20);}    
        
    }
    //EL METODO COMPROBAR ARRANCADO SE ESTARÁ EJECUTANDO DESDE EL INICIO
    return(
       
        <div  style={{"padding-right": "30px",
            "padding-left": "30px"}} >
            <div  style={{"backgroundColor":"green","padding":"20px"}}>
            <h1>{coche.marca} {coche.modelo}</h1>
            </div>
            <div  style={{"backgroundColor":"red","padding":"20px"}}>
                {comprobarArrancado()}
                <button type="button" onClick={() =>{
                    setArrancado(!arrancado);
                    if(velocidad!=0){
                        setVelocidad(0);
                    }
                }}>Girar llave</button>
            </div>
            <div style={{"backgroundColor":"blue","padding":"20px"}}>
            <h2 id="ve">Velocidad: {velocidad} km/h</h2>
            <button type="button" onClick={()=>acelerar()}>Acelerar</button>
            <button type="button" onClick={()=>frenar()}>Frenar</button>
            </div>
           <br></br>
        </div>
    );
}
export default Car;