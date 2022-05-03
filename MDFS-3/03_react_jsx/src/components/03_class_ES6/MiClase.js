import React ,{Component} from 'react';
import './MiClase.css';

function funcion (){
    console.log("Soy funcion externa");
}
//NO ES LO MISMO ESTA VARIABLE DECLARADA FUERA QUE LO QUE USSAMOS EN EL RENDER
var numero =255;
export default class MiClase extends Component{
    //AQUI NO FUNCIONA VAR NI CONST NI FUNCTION....
    contador=1;
    
    metodo = () =>{
        this.contador++;
        console.log("contador"+ this.contador);

    }

    //SE PUEDEN DECLARAR AQUI VARIABLES STATE PARA DIBUJOS
    state ={numero:parseInt(this.props.inicio)};
    incrementarEstado =()=>{
        this.setState({
                numero: this.state.numero+1
        });
    }
    render(){
        //SE PUEDEN CREAR FUNCIONES COMO EN REACT EJERCICOS ANTERIORES
        //PERO FUERAD EL RENDER SE CREAN SIN FUNCTION O CONST ETC..

        //SOLO LOS METODOS DE LA CLASE SE LLAMAN EN EL RENDER CON THIS
        //LOS DEMAS, SIN EL
        const hacerAlgo = ()=>{
            console.log("Haciendo algo...");
            this.setState({
                numero: this.state.numero+1
        });
        }
        return(
            <React.Fragment>
                <h1>{
                //ACCEDEMOS DIRECTAMENTE A PROPS(NO HACE FALTA DECLARARLOS)
                this.props.titulo}</h1>
                <div className="container">
                    <h3>{
                    //NUMERO DE FUERA DE LA CLASE
                    numero}</h3>
                    <h3>valor: {
                    //NUMERO DEL STATE
                    this.state.numero}</h3>
                    <hr/>
                    <button type="button" onClick={() => 
                        //METODO DE LA CLASE, SE USA THIS
                        this.metodo()}>Subir contador</button>
                    <button type="button" onClick={() => 
                        //METODO FUERA DE LA CLASE
                        //NO SE USA THIS
                        funcion()}>Pulsa fuera de class</button>
                    <button type="button" onClick={() => 
                        //METODO CREADO EN RENDER
                        //NO SE USA THIS
                        //SE DECLARA COMO CONST
                        hacerAlgo()}>Metodo de render</button>
                    <button type="button" onClick={() => 
                    this.incrementarEstado()}>Cambiar el valor</button>
                </div>
                
            </React.Fragment>
            
        );
    }
}
