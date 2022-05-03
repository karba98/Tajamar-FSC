/**
 * YO SOY HIJO
 * 
 */

 //Desde padre llamar a 
function SumaEnHijo(props){
    const {n1,n2,color} = props;

    const sumar = (n1,n2) => {
        console.log(n1);
        console.log(n2);
        var suma = parseInt(parseInt(n1)+parseInt(n2));
        console.log("Mi suma en Hijo es: "+suma);
    };

    var estilo ={"backgroundColor":color,"padding":"15px"};
    return(
        <div style={estilo}>
            <h1>Ejercicio Suma Numeros desde Hijo: </h1>
           <button type="button" onClick={()=>sumar(n1,n2)}>Sumar</button>
        </div>
    );
}
export default SumaEnHijo;