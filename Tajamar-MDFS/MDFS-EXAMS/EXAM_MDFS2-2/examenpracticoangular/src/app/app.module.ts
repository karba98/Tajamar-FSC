import { PersonajesService } from './services/personajes.service';
import { SeriesService } from './services/series.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {routing, appRoutingProvider} from './../routes/routes';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import {HomeComponent} from './../components/home/home.component';
import { MenuComponent } from '../routes/menu/menu.component';
import { SeriesComponent } from '../components/series/series.component';
import { PersonajesComponent } from '../components/personajes/personajes.component';
import { InsertarComponent } from '../components/insertar/insertar.component';
import { ModificarComponent } from '../components/modificar/modificar.component';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MenuComponent,
    SeriesComponent,
    PersonajesComponent,
    InsertarComponent,
    ModificarComponent,
  ],
  imports: [
    BrowserModule,
    routing,
    HttpClientModule
  ],
  providers: [appRoutingProvider,SeriesService,PersonajesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
