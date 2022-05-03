import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { PersonajesComponent } from './../components/personajes/personajes.component';

import { HttpClientModule} from '@angular/common/http';
import { PersonaComponent } from '../components/persona/persona.component';
import { CochesComponent } from '../components/coches/coches.component';
import { FormsModule} from  '@angular/forms';
import { EmpleadossalarioComponent } from '../components/empleadossalario/empleadossalario.component';

import {EmpleadosService} from './services/Empleados.service';
import { EmpleadosoficioComponent } from '../components/empleadosoficio/empleadosoficio.component';

import {routing, appRoutingProvider} from './app.routing';
import {EmpleadosRoutingService} from './services/EmpleadoRouting.service';
import { EmpleadosTablaComponent } from '../components/empleadostabla/empleadostabla.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonajesComponent,
    PersonaComponent,
    CochesComponent,
    EmpleadossalarioComponent,
    EmpleadosoficioComponent,
    
    EmpleadosTablaComponent,
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    routing,
    HttpClientModule
  ],
  providers: [EmpleadosService, EmpleadosRoutingService, appRoutingProvider],
  bootstrap: [AppComponent]
})
export class AppModule { }
