import { Component, OnInit } from '@angular/core';
import { Frame } from '../warframes/frame';
import { FrameService } from '../warframes/frame.service';

@Component({
   selector: 'app-dashboard',
   templateUrl: './dashboard.component.html',
   styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
   frames: Frame[] = [];
   weather!: Weather[];
   constructor(private frameService: FrameService) { }

   ngOnInit() {
      this.getWeather();
      this.getFrames();
   }

   getFrames(): void {
      this.frameService.getFrames()
         .subscribe(frames => {
            this.frames = frames.slice(0, this.min(frames.length, 5));
            console.log(frames);
            console.log(this.frames);
         });
   }

   getWeather(): void {
      this.frameService.getWeatherForecast()
         .subscribe(weather => {
            this.weather = weather.slice(0, weather.length);
         });
   }

   private min(a: number, b: number):number {
      return a < b ? a : b;
   }
}