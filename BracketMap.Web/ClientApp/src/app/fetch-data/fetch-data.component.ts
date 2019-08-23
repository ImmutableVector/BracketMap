import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public tournaments: Tournament[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Tournament[]>(baseUrl + 'tournament').subscribe((result: Tournament[]) => {
      this.tournaments = result;
    }, (error: any) => console.error(error));
  }
}

interface Tournament {
  id: string;
  name: number;
  playerCount: number;
}
