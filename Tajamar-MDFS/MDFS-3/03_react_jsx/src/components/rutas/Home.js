import React, { Component } from 'react'
import imag from './../../assets/imgs/home.jpg'

export default class Home extends Component {
    render() {
        return (
            <div>
                <img style={{
                    width:"97%",
                    height:"89%",
                    margin:"30px"
                }}
                src={imag}></img>
            </div>
        )
    }
}
