import { Component, OnInit, Input } from '@angular/core';
import { Frame } from '../frame';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { FrameService } from '../frame.service';

@Component({
   selector: 'app-warframe-detail',
   templateUrl: './warframe-detail.component.html',
   styleUrls: ['./warframe-detail.component.scss']
})
export class WarframeDetailComponent implements OnInit {
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
      const name = String(this.route.snapshot.paramMap.get('name'));
      this.frameService.getFrame(name)
         .subscribe(frame => this.frame = frame);
   }

   goBack(): void {
      this.location.back();
   }
}
