import { Component, OnInit } from '@angular/core';
import { HttpService } from '../services';
import { map } from 'rxjs/operators';
import { Tournament } from '../models';

@Component({
  selector: 'bm-tournament',
  templateUrl: './tournament.component.html',
  styleUrls: ['./tournament.component.scss']
})
export class TournamentComponent implements OnInit {
  tournaments: Tournament[] = [];

  constructor(private httpService: HttpService) { }

  ngOnInit(): void {
    this.httpService.get<Tournament[]>(`Tournament/All`)
      .pipe(map(response => {
        if (response.body === null) {
          throw new Error(response.status.toString());
        }
        return response.body;
      }))
      .subscribe(data => {
        this.tournaments = data;
      });
  }
}
