import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TournamentService } from 'src/app/services';
import { Tournament } from 'src/app/models';

@Component({
  selector: 'bm-pending',
  templateUrl: './pending.component.html',
  styleUrls: ['./pending.component.scss']
})
export class PendingComponent implements OnInit {
  teamName: string | null = null;
  name: string | null = null;
  id: number = +this.activatedRoute.snapshot.params.id;
  tournament?: Tournament;
  players: { name: string | null }[] = [];

  constructor(private activatedRoute: ActivatedRoute, private tournamentService: TournamentService) { }

  ngOnInit() {
    this.tournamentService.get(this.id).subscribe({
      next: data => {
        this.tournament = data;
        this.players = new Array(data.playersPerTeam).fill(null).map(() => ({ name: null }));
      },
      error: error => console.error(error)
    });
    this.teamName = this.randomName;
  }

  addPlayer() {
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
