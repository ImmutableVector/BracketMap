import { Injectable } from '@angular/core';
import { HttpService } from '.';
import { Observable } from 'rxjs';
import { Team } from '../models';

@Injectable({
  providedIn: 'root'
})
export class TeamService {

  constructor(private httpService: HttpService) { }

  get(tournamentId: number): Observable<Team> {
    return this.httpService.get<Team>('Team', { tournamentId: tournamentId.toString() });
  }

  // put(model: Tournament): Observable<null> {
  //   return this.httpService.put<null>('Tournament', model)
  //     .pipe(map(response => response.body));
  // }

  // delete(id: number): Observable<null> {
  //   return this.httpService.delete<null>('Tournament', { id: id.toString() })
  //     .pipe(map(response => response.body));
  // }
}
