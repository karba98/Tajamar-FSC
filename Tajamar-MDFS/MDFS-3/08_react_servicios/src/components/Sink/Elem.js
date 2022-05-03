import React, {Component} from 'react';

export default class Elem extends Component {
    imgA = "https://i.etsystatic.com/14647411/r/il/25c0e3/1605536757/il_570xN.1605536757_fhab.jpg";
    imgB="https://marypaint.com/custom_content/img/paleta/00035/th1_gris_topo_2.png";

    clickUsu=()=>{
        console.log("id: "+this.id+" Valor: "+this.valor);
        if(document.getElementById(this.id).
            style.cssText=="background-color: aqua;"
            || document.getElementById(this.id).
            style.cssText=="background-color: grey;"){
                return false;
        }else{
            
            if(this.valor==0){
                document.getElementById(this.id).
                style.cssText="background-color: aqua";
                document.getElementById("TU").src = this.imgA;
            }
            else{
                document.getElementById(this.id).
                style.cssText="background-color: grey";
                document.getElementById("TU").src = this.imgB;

                let puntos =1;

                let puntosextra = this.props.comprueba(this.props.y,this.props.x,-1)
                    puntosextra += this.props.comprueba(this.props.y,this.props.x,1)
                    puntosextra += this.props.comprueba(this.props.y-1,this.props.x,0)
                    puntosextra +=this.props.comprueba(this.props.y+1,this.props.x,0)          
                ;
                this.props.sumausu(puntos+puntosextra);
            }

            this.props.setTurnoIA();
            setTimeout(() => {   
                this.props.juegaIA();
                }, 1000);
        }
    }
    setBg =()=>{
        this.setState({
            bg:"grey"
        });
    }
    id=this.props.ident;
    valor = this.props.valor;
    bg = this.props.background;
   
    render(){    
        return(
            <td id={this.id}
                //style={{backgroundColor:bg}}
                style={{backgroundColor:this.props.background}}
                turno = {this.props.turno}
                y={this.props.y}
                x={this.props.x}
                valor={this.valor}
                data-id={this.id}
                data-valor={this.valor}
                key={this.id}
                // eslint-disable-next-line no-loop-func
                onClick={() => {
                    if(this.props.turno=="CPU"){
                        return false;
                    }else{
                        this.clickUsu();
                    }
                    
                   
                }}
                ></td>
            
        );
    }

}