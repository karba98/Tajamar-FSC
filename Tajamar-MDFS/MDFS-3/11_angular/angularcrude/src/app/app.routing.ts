import { DepartamentosUpdateComponent } from './../components/departamentos-update/departamentos-update.component';
import { DepartamentosInsertComponent } from './../components/departamentos-insert/departamentos-insert.component';
import {ModuleWithProviders} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';

import{DepartamentosComponent} from './../components/departamentos/departamentos.component';
const appRoutes:Routes =[
   {path:"",component:DepartamentosComponent},
   {path:"insert",component:DepartamentosInsertComponent},
   {path:"eliminar/:id",component:DepartamentosComponent},
   {path:"modificar/:id",component:DepartamentosUpdateComponent},
   {path:"**",component:DepartamentosComponent},
];

export const appRoutingProvider: any[]=[];
export const routing : ModuleWithProviders<any> = RouterModule.forRoot(appRoutes);