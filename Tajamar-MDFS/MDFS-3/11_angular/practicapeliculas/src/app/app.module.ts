import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {routing, appRoutingProvider} from './app.routing';
import {MenuComponent} from './../components/menu/menu.component'
import {PeliculasComponent} from './../components/peliculas/peliculas.component';
import { fromEventPattern } from 'rxjs';
import {PeliculasService} from './services/peliculas.service';
import { FormsModule} from  '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { PeliculaDetalleComponent } from '../components/pelicula-detalle/pelicula-detalle.component';
import { HomeComponent } from '../components/home/home.component';
import { PeliculastituloComponent } from '../components/peliculastitulo/peliculastitulo.component';
import { Global } from './services/global';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    PeliculasComponent,
    PeliculaDetalleComponent,
    HomeComponent,
    PeliculastituloComponent,
  ],
  imports: [
    BrowserModule,
    routing,
    FormsModule,
    HttpClientModule
  ],
  providers: [appRoutingProvider,PeliculasService],
  bootstrap: [AppComponent]
})
export class AppModule { }
