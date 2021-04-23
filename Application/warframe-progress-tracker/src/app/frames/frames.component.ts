import { Component, OnInit } from '@angular/core';
import { Frame } from '../frame';
import { FRAMES } from '../mock-frames';

@Component({
  selector: 'app-frames',
  templateUrl: './frames.component.html',
  styleUrls: ['./frames.component.scss']
})
export class FramesComponent implements OnInit {
  frames = FRAMES;
  selectedFrame?: Frame;

  constructor() { }

  onSelect(frame: Frame): void {
    this.selectedFrame = frame;
  }

  ngOnInit(): void { }
}
