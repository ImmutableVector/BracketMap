import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TournamentComponent } from './tournament/tournament.component';
// import { FightComponent } from './fight/fight.component';
import { NewComponent } from './tournament/new/new.component';
import { PendingComponent } from './tournament/pending/pending.component';
import { FightFlexComponent } from './fight-flex/fight-flex.component';

const routes: Routes = [
  { path: '', component: TournamentComponent, pathMatch: 'full' },
  // { path: 'fight', component: FightComponent },
  { path: 'fight', component: FightFlexComponent },
  { path: 'tournament', component: TournamentComponent },
  { path: 'tournament/new', component: NewComponent },
  { path: 'tournament/:id/pending', component: PendingComponent }
  // { path: 'tournament', component: TournamentComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
