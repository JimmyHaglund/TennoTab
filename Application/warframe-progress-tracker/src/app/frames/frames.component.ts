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
  selectedFrame?: Frame;

  constructor(private frameService: FrameService, private messageService: MessageService) { }

  getFrames(): void {
    this.frameService.getFrames()
    .subscribe(frames => this.frames = frames);
  }

  onSelect(frame: Frame): void {
    this.selectedFrame = frame;
    this.messageService.add(`FramesComponent: Selected frame: ${frame.name}`);
  }

  ngOnInit(): void { 
    this.getFrames();
  }
}