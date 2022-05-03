export class Pelicula{
    constructor(
        public idPelicula: number,
        public idDistribuidor: number,
        public idGenero:number,
        public titulo:string,
        public idNacionalidad:number,
        public argumento:string,
        public foto:string,
        public fechaEstreno:Date,
        public actores:string,
        public director:string,
        public duracion:number,
        public precio:number,
        public youTube:string,
        public enlaceVideo:string

    ){}
}