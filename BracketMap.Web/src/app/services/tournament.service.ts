import { Injectable } from '@angular/core';
import { HttpService } from '.';
import { Tournament } from '../models';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TournamentService {
  constructor(private httpService: HttpService) { }

  get(id: number): Observable<Tournament> {
    return this.httpService.get<Tournament>(`Tournament/${id}`);
  }

  getAll(): Observable<Tournament[]> {
    return this.httpService.get('Tournament');
  }

  post(model: Tournament): Observable<number> {
    return this.httpService.post<number>('Tournament', model);
  }
}
