import { Component, OnInit } from '@angular/core';
import { Frame } from '../frame';
import { FrameService } from '../frame.service';
import { MessageService } from '../../message.service';

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

   delete(frame: Frame): void {
      this.frames = this.frames.filter(h => h !== frame);
      this.frameService.deleteFrame(frame.name).subscribe();
   }

   add(name: string): void {
      name = name.trim();
      if (!name) { return; }
      this.frameService.addFrame({ name } as Frame)
         .subscribe(frame => {
            this.frames.push(frame);
         });
   }
}