import { TournamentEnum } from './tournament.enum';

export class Tournament {
  id = 0;
  name: string | null = null;
  playerCount: number | null = 1;
  teamCount: number | null = 2;
  status?: TournamentEnum;
}
