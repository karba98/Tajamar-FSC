import React, {Component} from 'react';
import LogoMusic from './../../assets/imgs/musica.png';

export default class Musica extends Component{
    render(){
        return(
            <div>
                <h1>Soy Music</h1>
                <img style={{width:"70px", height:"70px"}} src={LogoMusic}/>
            </div>
        );
    }
}