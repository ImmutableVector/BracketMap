import { Component, OnInit } from '@angular/core';
import { TournamentService } from '../services';
import { TournamentEnum, Tournament } from '../models';
import { map } from 'rxjs/operators';

@Component({
  selector: 'bm-tournament',
  templateUrl: './tournament.component.html',
  styleUrls: ['./tournament.component.scss']
})
export class TournamentComponent implements OnInit {
  activeTournaments: Tournament[] = [];
  pendingTournaments: Tournament[] = [];
  completedTournaments: Tournament[] = [];

  constructor(private tournamentService: TournamentService) { }

  ngOnInit(): void {
    this.tournamentService.getAll()
      .pipe(map(tournaments => {
        this.completedTournaments = tournaments.filter(tournament => tournament.status === TournamentEnum.Complete);
        this.pendingTournaments = tournaments.filter(tournament => tournament.status === TournamentEnum.Pending);
        this.activeTournaments = tournaments.filter(tournament => tournament.status === TournamentEnum.Active);
      }))
      .subscribe();
  }
}
