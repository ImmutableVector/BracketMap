import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TournamentComponent } from './tournament/tournament.component';
import { NewComponent } from './tournament/new/new.component';
import { PendingComponent } from './tournament/pending/pending.component';
import { FightVersusComponent } from './tournament-fight/fight-versus/fight-versus.component'
const routes: Routes = [
  { path: '', component: TournamentComponent, pathMatch: 'full' },
  { path: 'fight', component: FightVersusComponent },
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
