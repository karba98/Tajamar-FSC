import React,{Component} from 'react';

export default class Comics extends Component{
    
    render(){
        return(
            <div id="imagen">
                {//<h1 className="h1Comic">{this.props.comic.titulo}
                }
                <button style={{backgroundColor:"red"}}
                type="button" onClick={()=>this.props.eliminar(this.props.index)}>
                    Eliminar</button>
                <button style={{backgroundColor:"green"}}
                type="button" onClick={()=>this.props.modificar(this.props.index)}>
                    Modificar</button>
                <img 
                style={{width:"200px",height:"300px"}}
                src={this.props.comic.imagen} 
                onClick={()=>{
                    this.props.seleccionaComic(this.props.comic);
                    document.getElementById("titulo").value=this.props.comic.titulo;
                    document.getElementById("imag").value=this.props.comic.imagen;
                    document.getElementById("descripcion").value=this.props.comic.descripcion;
                }}/>
                {//<p>{this.props.comic.descripcion}</p>
                }

                
            </div>
        );
    }
}