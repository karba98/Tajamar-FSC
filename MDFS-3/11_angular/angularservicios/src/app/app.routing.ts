import {ModuleWithProviders} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';

import {EmpleadosTablaComponent} from './../components/empleadostabla/empleadostabla.component';
import {DetallesempleadoComponent} from './../components/detallesempleado/detallesempleado.component';

const appRoutes:Routes =[
    {path:'', component:EmpleadosTablaComponent},
    {path:'detalles/:empleado', component:DetallesempleadoComponent}
];

export const appRoutingProvider: any[]=[];
export const routing : ModuleWithProviders<any> = RouterModule.forRoot(appRoutes);