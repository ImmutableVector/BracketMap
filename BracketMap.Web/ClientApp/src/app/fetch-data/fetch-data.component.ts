import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public tournaments: Tournament[];

  constructor(http: HttpClient) {
    http.get<Tournament[]>(`${environment.apiUrl}/tournament`).subscribe((result: Tournament[]) => {
      this.tournaments = result;
    }, error => console.error(error));
  }
}

interface Tournament {
  id: string;
  name: number;
  playerCount: number;
}
