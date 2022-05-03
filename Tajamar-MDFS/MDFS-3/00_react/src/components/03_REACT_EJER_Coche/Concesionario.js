import Car from './Car';

function Concesionario (){
   
    return(
        <div>
        <Car marca="AUDI" modelo="R8" vmax="120" acel="30" />
        <Car marca="SEAT" modelo="IBIZA" vmax="250" acel="50" />
        <Car marca="CITROEN" modelo="C4 GP" vmax="180" acel="20" />
        </div>
       
    );

}
export default Concesionario;