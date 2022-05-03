import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PlantillaComponent } from '../components/plantilla/plantilla.component';
import { MenuComponent } from '../routes/menu/menu.component';
import {routing, appRoutingProvider} from './../routes/router';

@NgModule({
  declarations: [
    AppComponent,
    PlantillaComponent,
    MenuComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    routing
  ],
  providers: [appRoutingProvider],
  bootstrap: [AppComponent]
})
export class AppModule { }
