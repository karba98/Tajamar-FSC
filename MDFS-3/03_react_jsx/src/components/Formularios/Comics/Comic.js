import React,{Component} from 'react';

export default class Comics extends Component{
    
    render(){
        return(
            <div>
                <h3>{this.props.title}</h3>
                <p>{this.props.description}</p>
                <img 
                style={{width:"200px",height:"300px"}}
                src={this.props.imagen} 
                alt={this.props.imagen} 
                />
            </div>
        );
    }
}