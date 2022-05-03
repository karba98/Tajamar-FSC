import {Injectable} from '@angular/core';
import {Personaje} from './../models/Personaje';
@Injectable()
export class PersonajeService {
    getMensaje(){
        console.log("Mensaje");
    }
    getPersonajes(){
        let personajes:Array<Personaje>;
        personajes = [
              new Personaje(
                "Dustin Henderson",
                "https://spoilertime.com/wp-content/uploads/2019/05/Gaten-Matarazzo-in-Stranger-Things-2016-780x1155.jpg",
                "Stranger Things"
              ),
              new Personaje(
                "Koothrappali",
                "https://i.pinimg.com/originals/cd/ec/06/cdec069e361d3e41b0259fe6991e48a2.png",
                "The Big Bang Theory"
              ),
              new Personaje(
                "Barney Stinson",
                "https://i.pinimg.com/originals/b9/e2/b3/b9e2b367ec3cdd3db683803f36e40b64.jpg",
                "Como conocí a vuestra madre"
              )
            ];
        return personajes;
    }
}