import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {CiclosVida} from '../components/ciclosvida/ciclosVida.component';
//importamos PrimerComponente
import {PrimerComponente} from '../components/primerComponente/primerComponente.component';
import {Deportes} from '../components/directivas/deportes.component';
import {Aleatorios} from'./../components/directivas/aleatorios.component';
import {Posneg} from './../components/12_angular_pos_neg/posneg.component';
import { FormulariosComponent } from './../components/formularios/formularios.component';
import {FormsModule} from '@angular/forms';
import { SumarNumerosComponent } from '../components/sumar-numeros/sumar-numeros.component';
@NgModule({
  declarations: [
    AppComponent
    //declaramos el componente
    ,PrimerComponente
    ,CiclosVida
    ,Deportes
    ,Aleatorios
    ,Posneg, FormulariosComponent, SumarNumerosComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
