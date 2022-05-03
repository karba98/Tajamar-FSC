import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {routing, appRoutingProvider} from './app.routing';
import { HttpClientModule } from '@angular/common/http';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import {DepartamentosService} from './services/departamentos.service';
import { MenuComponent } from '../components/menu/menu.component';
import { DepartamentosComponent } from '../components/departamentos/departamentos.component';
import { DepartamentosInsertComponent } from '../components/departamentos-insert/departamentos-insert.component';
import { DepartamentosUpdateComponent } from '../components/departamentos-update/departamentos-update.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    DepartamentosComponent,
    DepartamentosInsertComponent,
    DepartamentosUpdateComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    routing,
    HttpClientModule
  ],
  providers: [appRoutingProvider,DepartamentosService],
  bootstrap: [AppComponent]
})
export class AppModule { }
