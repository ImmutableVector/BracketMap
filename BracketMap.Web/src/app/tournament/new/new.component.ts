import { Component } from '@angular/core';

import { Tournament } from '../../models';
import { TournamentService } from 'src/app/services';

@Component({
  selector: 'bm-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent {
  model = new Tournament();

  constructor(private tournamentService: TournamentService) { }

  create() {
    this.tournamentService.post(this.model).subscribe(id => {
      console.log(id);
    });
  }
}
