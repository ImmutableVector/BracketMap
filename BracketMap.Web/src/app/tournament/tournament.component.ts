import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'bm-tournament',
  templateUrl: './tournament.component.html',
  styleUrls: ['./tournament.component.scss']
})
export class TournamentComponent {
  tournaments: Tournament[] = [];

  constructor(http: HttpClient) {
    http.get<Tournament[]>(`${environment.apiUrl}/tournament`)
      .subscribe({
        next: result => {
          this.tournaments = result;
        },
        error: error => {
          console.error(error);
        }
      });
  }
}

interface Tournament {
  id: string;
  name: number;
  playerCount: number;
}
