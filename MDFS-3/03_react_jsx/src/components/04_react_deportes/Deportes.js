import React,{Component} from 'react';
import Deporte from'./Deporte';

export default class Deportes extends Component{

    seleccionarfav = (deporte) =>{
        console.log("Favorito: "+deporte);
        this.setState({
            seleccionado:deporte
        });
    }
    state ={
        deportes:[
            "Padel","Futbol","Beisbol","Hockey","Petanca"
        ],
        nombre:"Alumno",
        seleccionado:""
        
    };
    contDepor =0;
    nuevodeporte =()=>{
        this.contDepor++;
        var arrdeportes = this.state.deportes;
        arrdeportes.push("Deporte "+this.contDepor);
        //HAY QQUE MODIFICARLO EN STATE, NO SOLO EL ARRAY
        this.setState({deportes:arrdeportes});
    }
    render(){
        return(
            <div>
                <h2>Deportes de {this.state.nombre} EN PADRE:</h2>
                <ul>
                    {
                        //BUCLE A ARRAY
                        this.state.deportes.map((deporte,index)=>{
                            return(<li key={index}>{deporte}</li>);
                        })
                    }
                </ul>
                <hr/>
                <h2>Deportes de {this.state.nombre} EN COMPONENT HIJO:</h2>
                <h3>Deporte favorito: {this.state.seleccionado}</h3>
                <ul>
                    {
                        //BUCLE A ARRAY PASANDO COMPONENTE DEPORTE
                        this.state.deportes.map((deporte,index)=>{
                            return(
                            <Deporte seleccionarfav={this.seleccionarfav}
                                key={index}
                                deporte={deporte}/>);
                        })
                    }
                </ul>
                <button onClick={()=>this.nuevodeporte()}>Crear nuevo deporte</button>
            </div>
        );
    }
}