import React, {Component} from 'react';
import Logocine from './../../assets/imgs/cine.png'

export default class Cine extends Component{
    render(){
        return(
            <div>
                <h1>Soy Cine</h1>
                <img style={{width:"70px", height:"70px"}} src={Logocine}/>
            </div>
            
        );
    }
}