import { Component, OnInit } from '@angular/core';
import { TournamentService } from '../services';
import { Tournament } from '../models';

@Component({
  selector: 'bm-tournament',
  templateUrl: './tournament.component.html',
  styleUrls: ['./tournament.component.scss']
})
export class TournamentComponent implements OnInit {
  tournaments: Tournament[] = [];

  constructor(private tournamentService: TournamentService) { }

  ngOnInit(): void {
    this.tournamentService.getAll().subscribe(data => {
      console.log(data);
    });
  }
}
