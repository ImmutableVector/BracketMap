import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { TeamService } from 'src/app/services';
import { Team } from 'src/app/models';

@Component({
  selector: 'bm-pending',
  templateUrl: './pending.component.html',
  styleUrls: ['./pending.component.scss']
})
export class PendingComponent implements OnInit {
  model = new Team();
  teamName: string | null = null;
  name: string | null = null;
  id: number = +this.activatedRoute.snapshot.params.id;

  constructor(private activatedRoute: ActivatedRoute, private teamService: TeamService) { }

  ngOnInit() {
    this.model.teamName = this.randomName;
    this.teamService.get(this.id).subscribe(_data => {
      debugger;
    });
    // get some players have already signed up
    // after that generate a randomName
  }

  addPlayer() {
    this.model.tournamentId = this.id;
    this.teamService.post(this.model).subscribe(() => {
      debugger;
    });
    // tell the api that we have added a single player
  }

  private get randomName(): string {
    const nameParts1 = ['Fast', 'Strong', 'Tough', 'Big', 'Tenacious', 'Awesome', 'Great'];
    const nameParts2 = ['Tigers', 'Lions', 'Bears', 'Eagles', 'Dolphins', 'Horses', 'Ducks', 'Wolfs', 'Sharks'];
    const namePart1 = nameParts1[Math.floor(Math.random() * nameParts1.length)];
    const namePart2 = nameParts2[Math.floor(Math.random() * nameParts2.length)];
    const name = `${namePart1} ${namePart2}`;
    // check if name exists already
    return name;
  }
}
