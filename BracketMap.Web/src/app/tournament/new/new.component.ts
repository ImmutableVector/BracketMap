import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { Tournament } from 'src/app/models';
import { TournamentService } from 'src/app/services';

@Component({
  selector: 'bm-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent {
  model = new Tournament();

  constructor(private router: Router, private tournamentService: TournamentService) { }

  create() {
    this.tournamentService.post(this.model)
      .subscribe(id => this.router.navigate(['tournament', id, 'pending']));
  }
}
