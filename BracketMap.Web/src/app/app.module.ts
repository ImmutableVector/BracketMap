import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { TournamentComponent } from './tournament/tournament.component';
import { HttpService } from './services';
import { NewComponent } from './tournament/new/new.component';
import { FightComponent } from './fight/fight.component';
import { TextComponent, NumberComponent } from './form-controls';
import { PendingComponent } from './tournament/pending/pending.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    TournamentComponent,
    NewComponent,
    FightComponent,
    TextComponent,
    NumberComponent,
    PendingComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [HttpService],
  bootstrap: [AppComponent, NavComponent]
})
export class AppModule { }
