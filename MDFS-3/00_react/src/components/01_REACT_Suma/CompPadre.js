import SumaEnHijo from './SumaEnHijo';
import SumaEnParent from './SumaEnParent';
/**
 * 
 * YO SOY PADRE
 * 
 */
function CompPadre(){
    
    const sumarPadre = (n1,n2) =>{
        console.log(n1);
        console.log(n2);
        var suma = parseInt(parseInt(n1)+parseInt(n2));
        console.log("Mi suma en Padre es: "+suma);
    }
    return(
        <div>
            <SumaEnHijo n1="4"n2="9"color="red"/>
            <SumaEnHijo n1="9"n2="1"color="blue"/>
            <SumaEnParent n1="2" n2="4" metodo={sumarPadre}/>
        </div>
    );
}
export default CompPadre;