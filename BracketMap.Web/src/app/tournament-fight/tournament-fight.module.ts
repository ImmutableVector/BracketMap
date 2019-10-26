import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FightCellComponent } from './fight-cell/fight-cell.component';
import { FightVersusComponent } from './fight-versus/fight-versus.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [FightCellComponent, FightVersusComponent],
  entryComponents: [FightVersusComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: 'fight', component: FightVersusComponent },
    ])
  ]
})
export class TournamentFightModule { }
