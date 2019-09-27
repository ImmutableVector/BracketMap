import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TournamentComponent } from './tournament/tournament.component';
import { FightComponent } from './fight/fight.component';
import { NewComponent } from './tournament/new/new.component';


const routes: Routes = [
  { path: '', component: TournamentComponent, pathMatch: 'full' },
  { path: 'fight', component: FightComponent },
  { path: 'tournament', component: TournamentComponent },
  { path: 'tournament/new', component: NewComponent }
  // { path: 'tournament', component: TournamentComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
