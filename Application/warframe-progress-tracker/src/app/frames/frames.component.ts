import { Component, OnInit } from '@angular/core';
import { Frame } from '../frame';
import { FrameService } from '../frame.service';
import { MessageService} from '../message.service';

@Component({
  selector: 'app-frames',
  templateUrl: './frames.component.html',
  styleUrls: ['./frames.component.scss']
})
export class FramesComponent implements OnInit {
  frames: Frame[] = [];

  constructor(private frameService: FrameService) { }

  getFrames(): void {
    this.frameService.getFrames()
    .subscribe(frames => this.frames = frames);
  }

  ngOnInit(): void { 
    this.getFrames();
  }
}