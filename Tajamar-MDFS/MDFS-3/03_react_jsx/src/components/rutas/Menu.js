import React, { Component } from 'react'

export default class Menu extends Component {
    render() {
        return (
            <nav>
                <ul className="topnav">
                    <li><a style={{color:"white"}}href="/">Home</a></li>
                    <li><a style={{color:"white"}}href="/cine">Cine</a></li>
                    <li><a style={{color:"white"}}href="/musica">Musica</a></li>
                    <li><a style={{color:"white"}}href="/docs">Docs</a></li>
                    <li><a style={{color:"white"}} href="/Comics">Comics</a></li>
                    <li><a style={{color:"white"}}href="/form">Form</a></li>
                    <li><a style={{color:"white"}}href="/collatz">Collatz</a></li>
                </ul>
            </nav>
        )
    }
}
