import React, {Component} from 'react';
import LogoDoc from './../../assets/imgs/docs.png';

export default class Doc extends Component{
    render(){
        return(
            <div>
                <h1>Soy Doc</h1>
                <img style={{width:"70px", height:"70px"}} src={LogoDoc}/>
            </div>
            
        );
    }
}