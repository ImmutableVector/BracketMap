import { TournamentEnum } from './tournament.enum';
import { Fight } from './fight';
import { Team } from './team';

export class Tournament {
  id = 0;
  name: string | null = null;
  playersPerTeam: number | null = 1;
  teamsPerFight: number | null = 2;
  status = TournamentEnum.Pending;
  fights: Fight[] = [];
  teams: Team[] = [];
}
