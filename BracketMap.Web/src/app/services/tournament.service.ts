import { Injectable } from '@angular/core';
import { HttpService } from '.';
import { Tournament } from '../models';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TournamentService {

  constructor(private httpService: HttpService) { }

  get(id: number): Observable<Tournament> {
    return this.httpService.get<Tournament>('Tournament', { id: id.toString() })
      .pipe(map(response => {
        if (response.body === null) {
          throw new Error(response.status.toString());
        }

        return response.body;
      }));
  }

  // post(model: Tournament): Observable<number> {
  //   return this.httpService.post<number>('Tournament', model)
  //     .pipe(map(response => response.body));
  // }

  // put(model: Tournament): Observable<null> {
  //   return this.httpService.put<null>('Tournament', model)
  //     .pipe(map(response => response.body));
  // }

  // delete(id: number): Observable<null> {
  //   return this.httpService.delete<null>('Tournament', { id: id.toString() })
  //     .pipe(map(response => response.body));
  // }
}
