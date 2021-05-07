import { Component, OnInit, Input } from '@angular/core';
import { Frame } from '../frame';

@Component({
  selector: 'app-warframe-detail',
  templateUrl: './warframe-detail.component.html',
  styleUrls: ['./warframe-detail.component.scss']
})
export class WarframeDetailComponent implements OnInit {
  @Input() frame?: Frame;

  constructor() { }

  ngOnInit(): void {
  }

}
