import React, { Component } from 'react'

export default class SeleccionSimple extends Component {

    seleccionado = React.createRef();
    state = {
        filas:[],
        opciones: []
    }
    generarOption = ()=>{
        var options =[];
        for(var i=0;i<10;i++){
            var aleat = parseInt((Math.random()*55)+1);
            options.push(
            <option value={aleat} key={i}>{aleat}</option>
            );
        }
        this.setState({
            opciones:options
        });
    }
    tablaMulti = (e)=>{
        e.preventDefault();
        let num = parseInt(this.seleccionado.current.value);
        let datos = [];
        for(let i=1;i<=10;i++){
            var operacion = num*i;
            datos.push(
            <tr key={i}>
                <td>{num+" x "+i}</td>
                <td>{operacion}</td>
            </tr>);
        }
        this.setState({
            filas:datos
        });
    }

    componentWillMount = () =>{
        this.generarOption();
    }
    render() {
        return (
            <div>
                <h1 style={{marginLeft:"15px"}}>Selector Simple:</h1>
                <form style={{marginLeft:"25px"}}
                 onSubmit={this.tablaMulti}>
                    <select name="numeros"
                    ref={this.seleccionado}>
                        {this.state.opciones}
                    </select>
                    <button>Generar Tabla</button>
                    <table>
                        <thead>
                            <tr>
                                <th>Operacion</th>
                                <th>Resultado</th>
                            </tr>
                           
                        </thead>
                        <tbody>
                            {this.state.filas}
                        </tbody>
                    </table>
                </form>
            </div>
        )
    }
}
