import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'bm-pending',
  templateUrl: './pending.component.html',
  styleUrls: ['./pending.component.scss']
})
export class PendingComponent implements OnInit {
  name?: string;
  id: number = +this.activatedRoute.snapshot.params.id;

  constructor(private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    // get some players have already signed up
  }

  addPlayer() {
    // tell the api that we have added a single player
  }
}
