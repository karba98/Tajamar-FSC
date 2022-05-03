import React, {Component} from 'react';

export default class Numero extends Component{

    numero = this.props.numero;
    render(){
        return(
        <button onClick={()=>{
            this.props.propIncrementar(this.numero);
        }}>
            {this.numero}
            </button>
        );

    }
}