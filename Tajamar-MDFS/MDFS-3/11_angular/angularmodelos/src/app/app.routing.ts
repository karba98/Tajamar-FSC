import {Routes, RouterModule} from '@angular/router';
import {Component, ModuleWithProviders} from '@angular/core';
import {NumerosComponent} from './../components/numeros/numeros.component';
import {CollatzComponent} from './collatz/collatz.component';

const routes:Routes =[
    {path:"collatz/:numero", component:CollatzComponent}
]
export const approutingProviders : any []=[];
export const routing: ModuleWithProviders<any> = RouterModule.forRoot(routes);