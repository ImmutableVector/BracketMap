import { Component, OnInit } from '@angular/core';

import { Tournament } from '../../models';

@Component({
  selector: 'bm-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent implements OnInit {
  model = new Tournament();

  constructor() { }

  ngOnInit() {
  }

  create() {
  }
}
