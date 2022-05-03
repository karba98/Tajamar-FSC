import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TablaMultiComponent } from './../components/tabla-multi/tabla-multi.component';
import {HomeComponent} from './../components/rutas/home/home.component';
import {CineComponent} from './../components/rutas/cine/cine.component';
import {DocsComponent} from './../components/rutas/docus/docs.component';

import {routing, approutingProviders} from './app.routing';
import { ErrorComponent } from './error/error.component';
import { MenuComponent } from './menu/menu.component';
import { NumerodobleComponent } from '../components/numerodoble/numerodoble.component';


@NgModule({
  declarations: [
    AppComponent,
    TablaMultiComponent,
    HomeComponent,
    CineComponent,
    DocsComponent,
    ErrorComponent,
    MenuComponent,
    NumerodobleComponent,
  ],
  imports: [
    BrowserModule,
    routing
  ],
  providers: [approutingProviders],
  bootstrap: [AppComponent]
})
export class AppModule { }
