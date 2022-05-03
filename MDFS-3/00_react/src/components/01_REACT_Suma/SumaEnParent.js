/**
 * YO SOY HIJO
 * 
 */

 //Desde padre llamar a 
 function SumaEnParent(props){

    const {n1,n2,metodo} = props;
    var estilo ={"backgroundColor":"green","padding":"15px"};
    return(
        <div style={estilo}>
            <h1>Ejercicio Suma Numeros desde Parent:</h1>
            <button type="button" onClick={()=> metodo(n1,n2)}>Sumar</button>
            
        </div>
    );
}
export default SumaEnParent;