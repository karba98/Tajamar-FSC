import {ModuleWithProviders} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import { ModificarPlantillaComponent } from 'src/components/modificar-plantilla/modificar-plantilla.component';
import { DetallesPlantillaComponent } from 'src/components/detalles-plantilla/detalles-plantilla.component';

import {PlantillaComponent} from './../components/plantilla/plantilla.component';
const appRoutes:Routes =[
    {path:'', component:PlantillaComponent}, 
    {path:'detalles/:id', component:DetallesPlantillaComponent},
    {path:'modificar', component:ModificarPlantillaComponent}
];

export const appRoutingProvider: any[]=[];
export const routing : ModuleWithProviders<any> = RouterModule.forRoot(appRoutes);