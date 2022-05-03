import React, { Component } from 'react'

export default class Collatz extends Component {
    
    numero = React.createRef();
    
    state={
        secuencia : null
    }
    recibirDatosForm = (e)=>{
        e.preventDefault();
        let nuevasecuencia = []
        let num =  parseInt(this.numero.current.value);
        while(num!=1){
            if(num%2==0){
                num = parseInt(num/2);
                nuevasecuencia.push(num);
            }else{
                num = parseInt((num*3)+1);
                nuevasecuencia.push(num);
            }
            console.log(num);     
        }
        this.setState({
           secuencia:nuevasecuencia
        });
        console.log(this.state.secuencia);
    }

    render() {
        return (
            <div>
                <h1>Collatz:</h1>
                <form
                style={{marginLeft:"20px"}}
                onSubmit={this.recibirDatosForm}>
                    <label>Nombre: </label>
                    <input 
                    onChange={this.recibirDatosForm}
                    type="number" ref={this.numero} name="numero"/>
                    <br/>
                </form>
                {this.state.numero &&
                (<div>
                    {this.listar}
                </div>)}
            </div>
        )
    }
}
