import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import {routing, approutingProviders} from './app.routing';
import { AppComponent } from './app.component';
import { NumerosComponent } from './../components/numeros/numeros.component';
import { CollatzComponent } from './collatz/collatz.component';
import { ListaproductosComponent } from '../components/listaproductos/listaproductos.component';
import { CochesComponent } from '../components/coches/coches.component';
import { ConcesionarioComponent } from '../components/concesionario/concesionario.component';
import { HijocontadorComponent } from '../components/hijocontador/hijocontador.component';
import { PadrecontadorComponent } from '../components/padrecontador/padrecontador.component';
import { ComicsLibreriaComponent } from '../components/comics-libreria/comics-libreria.component';
import { ComicsComicComponent } from '../components/comics-comic/comics-comic.component';
import { ComicsInsertComponent } from '../components/comics-insert/comics-insert.component';

import {FormsModule} from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NumerosComponent,
    CollatzComponent,
    ListaproductosComponent,
    CochesComponent,
    ConcesionarioComponent,
    HijocontadorComponent,
    PadrecontadorComponent,
    ComicsLibreriaComponent,
    ComicsComicComponent,
    ComicsInsertComponent
  ],
  imports: [
    BrowserModule,
    routing,
    FormsModule
  ],
  providers: [approutingProviders],
  bootstrap: [AppComponent]
})
export class AppModule { }
