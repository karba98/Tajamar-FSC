import {ModuleWithProviders} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {PeliculasComponent} from './../components/peliculas/peliculas.component';
import {PeliculaDetalleComponent} from './../components/pelicula-detalle/pelicula-detalle.component'
import {HomeComponent} from './../components/home/home.component';
import {PeliculastituloComponent} from "./../components/peliculastitulo/peliculastitulo.component";

const appRoutes:Routes =[
    {path:"" ,component:HomeComponent},
    {path:":titulo" ,component:PeliculastituloComponent},
    {path:"genero/:genero" ,component:PeliculasComponent},
    {path:"pelicula/:id" ,component:PeliculaDetalleComponent}
];

export const appRoutingProvider: any[]=[];
export const routing : ModuleWithProviders<any> = RouterModule.forRoot(appRoutes);