import { Injectable } from '@angular/core';
import { HttpService } from '.';
import { Tournament } from '../models';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TournamentService {
  constructor(private httpService: HttpService) {}

  get(id: number): Observable<Tournament> {
    return this.httpService.get<Tournament>('Tournament', { id: id.toString() });
  }

  getAll(): Observable<Tournament[]> {
    return this.httpService.get('Tournament/All');
  }

  post(model: Tournament): Observable<number> {
    return this.httpService.post<number>('Tournament/SaveTournament', model);
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
