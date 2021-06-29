import { Component, OnInit, Input } from '@angular/core';
import { Frame } from '../frame';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { FrameService } from '../frame.service';

@Component({
   selector: 'app-frame-detail',
   templateUrl: './frame-detail.component.html',
   styleUrls: ['./frame-detail.component.scss']
})
export class FrameDetailComponent implements OnInit {
   @Input() frame?: Frame;

   constructor(
      private route: ActivatedRoute,
      private frameService: FrameService,
      private location: Location
   ) { }

   ngOnInit(): void {
      this.getFrame();
   }

   getFrame(): void {
      const id = Number(this.route.snapshot.paramMap.get('id'));
      console.log(id);
      console.log(this.route);
      this.frameService.getFrame(id)
         .subscribe(frame => this.frame = frame);
   }

   goBack(): void {
      this.location.back();
   }

   save(): void {
      if (this.frame == null) return;
      this.frameService.updateFrame(this.frame)
         .subscribe(() => this.goBack());
   }
}
