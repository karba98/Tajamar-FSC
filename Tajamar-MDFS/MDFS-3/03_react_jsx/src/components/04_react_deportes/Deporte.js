import React, {Component} from 'react';

export default class Deporte extends Component {
    seleccionarDep =()=>{
        //EJECUTAMOS EL METODO DEL PADRE QUE NOS HAN PASADO POR PROPS
        this.props.seleccionarfav(this.props.deporte);
    }
    render(){
        return(
            <React.Fragment>
                <li style={{"color":"blue"}}>
                    <button 
                        onClick={()=>this.seleccionarDep()}>
                            Seleccionar deporte
                    </button>
                    {this.props.deporte}  
                    
                </li>
               
            </React.Fragment>
            
        );
    }
}