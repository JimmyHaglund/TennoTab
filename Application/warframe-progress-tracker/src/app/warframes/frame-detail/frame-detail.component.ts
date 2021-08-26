import { Component, OnInit, Input } from '@angular/core';
import { Frame } from '../frame';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { FrameService } from '../frame.service';
import { BlueprintService } from 'src/app/_services';

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
      private location: Location,
      private blueprintService: BlueprintService
   ) { }

   ngOnInit(): void {
      this.getFrame();
   }

   getFrame(): void {
      const id = Number(this.route.snapshot.paramMap.get('id'));
      console.log(id);
      console.log(this.route);
      this.frameService.getFrame(id)
         .subscribe(frame => {
            this.frame = frame;
            this.getBlueprints();
         });
   }

   getBlueprints(): void {
      if (this.frame == null)return;
      const name = this.frame.name;
      this.blueprintService.getBlueprintsWithResult(name)
         .subscribe(blueprints => console.log(blueprints));
      this.blueprintService.getTotalResourceCost(name)
         .subscribe(costs => console.log(costs));
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
