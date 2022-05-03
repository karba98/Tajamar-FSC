import React,{Component} from 'react';
import Comic from './Comic'
import './comicestilo.css'

export default class Comics extends Component{
    state = {
        comics: [
            {
              titulo: "Spiderman",
              imagen:
                "https://3.bp.blogspot.com/-i70Zu_LAHwI/T290xxduu-I/AAAAAAAALq8/8bXDrdvW50o/s1600/spiderman1.jpg",
              descripcion: "Hombre araña"
            },
            {
              titulo: "Wolverine",
              imagen:
                "https://images-na.ssl-images-amazon.com/images/I/51c1Q1IdUBL._SX259_BO1,204,203,200_.jpg",
              descripcion: "Lobezno"
            },
            {
              titulo: "Guardianes de la Galaxia",
              imagen:
                "https://cdn.normacomics.com/media/catalog/product/cache/1/thumbnail/9df78eab33525d08d6e5fb8d27136e95/g/u/guardianes_galaxia_guadianes_infinito.jpg",
              descripcion: "Yo soy Groot"
            },
            {
              titulo: "Avengers",
              imagen:
                "https://d26lpennugtm8s.cloudfront.net/stores/057/977/products/ma_avengers_01_01-891178138c020318f315132687055371-640-0.jpg",
              descripcion: "Los Vengadores"
            },
            {
              titulo: "Spawn",
              imagen:
                "https://i.pinimg.com/originals/e1/d8/ff/e1d8ff4aeab5e567798635008fe98ee1.png",
              descripcion: "Al Simmons"
            },
            {
              titulo: "Batman",
              imagen:
                "https://www.comicverso.com/wp-content/uploads/2020/06/The-Killing-Joke-657x1024.jpg",
              descripcion: "Murcielago"
            }
      ],
      favorito:null
    };
    seleccionar=(comic)=>{
        this.setState({favorito:comic});
        console.log(comic.imagen);
    }
    eliminar =(index)=>{
      let comics = this.state.comics;
      comics.splice(index,1);
      this.setState({
        comics:comics
      });
    }
    modificar = (index)=>{
      var titulo =document.getElementById("titulo").value;
      var imagen =document.getElementById("imag").value;
      var descrip =document.getElementById("descripcion").value;
      let comics = this.state.comics;
      let comic = comics[index];
      comic.titulo=titulo;
      comic.imagen=imagen;
      comic.descripcion=descrip;
      this.setState({
        comcis:comics
      });
    }
    crearComic=()=> {
      var titulo =document.getElementById("titulo").value;
      var imagen =document.getElementById("imag").value;
      var descrip =document.getElementById("descripcion").value;
      var comic ={
        titulo:titulo,
        imagen:imagen,
        descripcion:descrip
      };
      var micomics = this.state.comics;
      micomics.push(comic);
      this.setState({
        comics:micomics
      });
    }
    render(){
        return(
            <div className="container-comics">
                <h1 className="titulo">Comics</h1>
                {this.state.favorito!=null && (
                    <div>
                        <h1>Favorito: </h1>
                        <img id="fav" src={this.state.favorito.imagen}/>
                        <h2>{this.state.favorito.titulo}</h2>
                        <h4>{this.state.favorito.descripcion}</h4>
                        <hr></hr>
                    </div>
                )}
               
                <div style={{display:"inline-block"}}>
                    {this.state.comics.map((comic,index)=>{
                    return(   
                        <Comic
                            key={index}
                            index={index}
                            comic={comic}
                            seleccionaComic={this.seleccionar}
                            eliminar={this.eliminar}
                            modificar={this.modificar
                            }/>
                            
                        );
                    })}
                </div>
                <div style={{marginTop:"30px"}}>
                <label>Titulo: </label>
                  <input type="text" id="titulo"/><br></br>
                  <label>imagen: </label>
                  <input type="text" id="imag"/><br></br>
                  <label>Descripcion: </label>
                  <input type="text" id="descripcion"/><br></br>
                  <button type="button" onClick={this.crearComic}>
                    Crear comic
                  </button>
                </div>
               
            </div>
        );
    }
}