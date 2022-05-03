import React , {Component} from 'react';
import './tablero.css';
import Elem from './Elem';

let cuad =10;

export default class Sink10 extends Component{
    imgA = "https://i.etsystatic.com/14647411/r/il/25c0e3/1605536757/il_570xN.1605536757_fhab.jpg";
    imgB="https://marypaint.com/custom_content/img/paleta/00035/th1_gris_topo_2.png";
    state ={
        backgroundPrim:"#222",
        //backgroundPrim:"aqua",
        barcos:0,
        ia:0, 
        turno: "Usuario"
    };
    areseted = false;
    sumaUsu =(num)=>{
        console.log("Suma el usuario");
        let b = this.state.barcos+num;
        this.setState({
            barcos:b
        });
    }
    sumaIA =(num)=>{
        console.log("Suma la IA");
        let a = this.state.ia+num;
        this.setState({
            ia:a
        });
    }
    iaPlay=()=>  {
        console.log("JUEGA LA IA");
        try{
            let tab = document.getElementById("tablero");
            let  lineas = tab.getElementsByTagName("tr");
            let fila=parseInt(Math.random()*cuad);
            let columna = parseInt(Math.random()*cuad);
            let elemento = lineas[fila]
                .getElementsByTagName("td")[columna];
            if(elemento.style.cssText=="background-color: aqua;"
                ||elemento.style.cssText=="background-color: grey;"){
                this.iaPlay();
            }else{
                if(elemento.dataset["valor"]==0){
                    elemento
                    .style.cssText="background-color: aqua";
                    document.getElementById("IA").src = this.imgA;
                }
                else{
                    elemento
                    .style.cssText="background-color: grey";
                    document.getElementById("IA").src = this.imgB;
                    let puntosextra = this.comprueba(fila,columna,-1);   
                    puntosextra += this.comprueba(fila,columna,1);   
                    puntosextra += this.comprueba(fila-1,columna,0);   
                    puntosextra += this.comprueba(fila+1,columna,0);          
                    
                    this.sumaIA(1+puntosextra);
                }
                this.setState({turno:"Usuario"});
            }
        }catch(e){

        }
        
    }
    setTurnoIA=()=>{
        this.setState({turno:"CPU"});
    }

    tablero = null;
    createTableOld = () => {
        let table = []
        let id=0;
        for (let i = 0; i < cuad; i++) {
            let children = []
            for (let j = 0; j < cuad; j++) {
                let fila =
                <Elem 
                readOnly={false}
                ident = {id}
                y={i}
                x={j}
                turno = {this.state.turno}
                key={id}
                valor = {parseInt(Math.random()*2)}
                background ={this.state.background}
                check={this.check}
                juegaIA={this.iaPlay}
                setTurnoIA={this.setTurnoIA}
                sumausu={this.sumaUsu}
                comprueba = {this.comprueba}/>;
                children.push(fila);
                id++;
            }
            table.push(<tr key={id+500}>{children}</tr>);
           
        }
        this.tablero=table;
        return table
    }
    createTable = () => {
        let table = []
        let id=0;
        for (let i = 0; i < cuad; i++) {
            let children = [];
            for (let j = 0; j < cuad; j++) {
                let val =0;
                let elem =
                <Elem ident = {id} y={i} x={j} turno = {this.state.turno} key={id}
                valor = {val}
                background ={this.state.backgroundPrim}
                juegaIA={this.iaPlay}setTurnoIA={this.setTurnoIA} sumausu={this.sumaUsu}
                comprueba = {this.comprueba}/>;
                children.push(elem);
                id++;
            }
            table.push(<tr key={id+500}>{children}</tr>);
           
        }
        this.tablero = table;
        return table;
    }
    setBarcos = ()=>{
        if(this.areseted == false){
             //ASIGNACION DE BARCOS
            let  barc1 = [1];
            let  barc2 = [1,1];
            let  barc3 = [1,1,1];
            let  barc4 = [1,1,1,1];
            let  barc5 = [1,1,1,1,1];
            let barcos = [
                barc1,barc2,barc3,barc4,barc5,
                barc1,barc2,barc3,barc4,
                barc1,barc2,barc1,barc2,barc1,];

            for(let barco of barcos){
                let HV = parseInt(Math.random()*2); //1 vertical 0 Horizontal

                let lineaaleat = parseInt(Math.random()*cuad);
                let colaleat = parseInt(Math.random()*cuad);
                this.tablero.map((line,index)=>{
                    if(index==lineaaleat){
                        let linea = line;
                        linea.props.children.map((elem,indexCol)=>{        
                            let td = document.getElementById(elem.props.ident);

                            if(indexCol==colaleat &&  td.style.backgroundColor!="grey"){
                                console.log(" Barco en: "+index+" "+indexCol);
        
                                td.dataset["valor"]=1;
                                //td.style.backgroundColor="grey";

                                let contV =0;
                                let contH=0;
                                for(let i=0;i<barco.length;i++){
                                    if(HV ==0){
                                        contH++;
                                        td = document.getElementById(elem.props.ident+contH);
                                        //td.style.backgroundColor="grey";
                                        td.dataset["valor"]=1;
                                    }
                                    else if(HV==1){
                                        contV--;
                                        this.tablero.map((lineaB,i)=>{
                                            if(i==index+contV){
                                                lineaB.props.children.map((eV,inV)=>{
                                                    if(inV==indexCol){
                                                        let tda = document.getElementById(eV.props.ident);
                                                        //tda.style.backgroundColor="grey";
                                                        tda.dataset["valor"]=1;
                                                    }
                                                });
                                            }
                                        });
                                    
                                    }
                                    
                                }
                            }
                        });   
                    }
                                
                });
            }
            this.areseted=true;
        }
    }
    comprueba = (y,x,num)=>{
        let puntosextra=0;
        try{
            console.log("y: "+y+" x: "+x);
            this.tablero.map((line,index)=>{
                if(index==y){
                    let linea = line;
                    linea.props.children.map((elem,index)=>{
                        try{
                            if(index==x+num){
                                let valor = elem.props.valor;
                                let ident = elem.props.ident;
                                let td = document.getElementById(ident);
                                console.log("bg: "+td.style.backgroundColor+" valor: "+valor+
                                " id: "+ident);
                                if(td.style.backgroundColor=="rgb(34, 34, 34)" && valor==1){
                                    td.style.backgroundColor="grey"
                                    puntosextra++;
                                }
                            }
                        }catch(e){
                            console.log("A SU IZQUIERDA NO HAY ELEMENTOS");
                        }
                        
                    });
                }
            });

        }catch(e){console.log("No hay elementos adyacentes " +e)}
        return puntosextra;
    }
    render() {
        return(
            <div>
                <div style={{backgroundColor:"black", color:"white"}}className="marcador">
                 Turno de de {this.state.turno}
                </div>
                <div className="marcador">
                    <a href="/sink10">RESET</a>
                </div>
                <div className="marcador">
                    <img alt= ""style={{float:"left",marginTop:"7px"}} id="TU"className="imagen"/>
                    <a>TU ---- {this.state.barcos} - {this.state.ia} ---- CPU </a>
                    <img alt=""style={{float:"right",marginTop:"7px"}}  id="IA"className="imagen"/>
                </div>
                <table id="tablero">
                    <tbody id="body">
                        {this.createTable()}
                        
                    </tbody>
                </table>
                {setTimeout(() => {   
                            this.setBarcos();
                            }, 100)
                        }
            </div>
          
        )
    }
}