import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { TournamentComponent } from './tournament/tournament.component';
import { HttpClientModule } from '@angular/common/http';
import { HttpService } from './services';
import { NewComponent } from './tournament/new/new.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    TournamentComponent,
    NewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [HttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }
