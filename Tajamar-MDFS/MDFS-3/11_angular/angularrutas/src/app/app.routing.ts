import { Routes ,RouterModule} from '@angular/router';
import {ModuleWithProviders} from '@angular/core';
import {HomeComponent} from './../components/rutas/home/home.component';
import {CineComponent} from './../components/rutas/cine/cine.component';
import {DocsComponent} from './../components/rutas/docus/docs.component';
import { TablaMultiComponent } from './../components/tabla-multi/tabla-multi.component';
import {ErrorComponent } from './../app/error/error.component';
import {NumerodobleComponent} from './../components/numerodoble/numerodoble.component';

const routes: Routes = [
    {path:"", component:HomeComponent},
    {path:"cine", component:CineComponent},
    {path:"docs", component:DocsComponent},
    {path:"multi", component:TablaMultiComponent},   
    {path:"numero/:numero", component:NumerodobleComponent},
    {path:"**", component:ErrorComponent}
]
export const approutingProviders : any []=[];
export const routing: ModuleWithProviders<any> = RouterModule.forRoot(routes);