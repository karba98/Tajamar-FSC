import { SerieComponent } from './../app/serie/serie.component';
import {ModuleWithProviders} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import { HomeComponent } from 'src/components/home/home.component';
import { SeriesComponent } from '../components/series/series.component';
import { PersonajesComponent } from 'src/components/personajes/personajes.component';
import { InsertarComponent } from 'src/components/insertar/insertar.component';
import { ModificarComponent } from 'src/components/modificar/modificar.component';
const appRoutes:Routes =[
    {path :'', component:HomeComponent},
    {path :'serie/:id', component:SeriesComponent},
    {path :'personajes/:id', component:PersonajesComponent},
    {path :'insertar', component:InsertarComponent},
    {path :'modificar', component:ModificarComponent}
    
];

export const appRoutingProvider: any[]=[];
export const routing : ModuleWithProviders<any> = RouterModule.forRoot(appRoutes);
