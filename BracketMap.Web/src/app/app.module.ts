import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { TournamentComponent } from './tournament/tournament.component';
import { HttpClientModule } from '@angular/common/http';
import { HttpService } from './services';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    TournamentComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    HttpClientModule
  ],
  providers: [HttpService],
  bootstrap: [AppComponent, NavComponent]
})
export class AppModule { }
