/**
 * Nuevo componente saludo
 * 
 */
function Saludo(props){
    const botonPulsado = () => {
        console.log("Has pulsado el boton");
        ejemplo="Y mañana miercoles"
        console.log(ejemplo);
    };
    const sumar =(num1, num2) => {
        var suma = num1+num2;
        console.log("La suma es: "+suma);
    };

    const mostrarMensaje =() =>{
        return <h1>Nuevo mensaje</h1>
    };

    //variable string
    var saludo ="Hola";
    //SETEAMOS CON CONST LOS ATRIBUTOS PERSONALIZADOS QUE USAMOS EN EL MODULO QUE NOS LLAMA
    //const {name,edad} =props;

    //Añado metodo de padre
    const {name,edad, metodo} = props;
    //creo una variable
    var ejemplo = "Hoy es martes"
    
    //entre {} las variables

    var estilofeo = {color:"white",backgroundColor:"green"};
    return(
        <div>
            <h2 style={estilofeo}>{ejemplo}</h2>
            {sumar(7,8)}
            {mostrarMensaje()}
            <h1>{saludo} a {name} de edad {edad}</h1>
            <button onClick={()=>botonPulsado()}>Pulsar</button>
            {//SI se ejecuta con lamda, lo ejecuta al click, si llamo directamente, se ejecuta al inicio
            }
            <button onClick={()=> sumar(9,1)}>Pulsa con funcion lamda</button>
            <hr></hr>
            {//Ejecutamos metodo del padre
            }
            <button onClick={() => metodo(name+" "+edad)}>Metodo Padre</button>

        </div>
        
    );
}
export default Saludo;