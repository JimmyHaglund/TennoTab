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
      console.log(this.weather);
      //this.getFrames();
   }

   getFrames(): void {
      this.frameService.getFrames()
         .subscribe(frames => this.frames = frames.slice(1, 5));
   }

   getWeather(): void {
      this.frameService.getWeatherForecast()
         .subscribe(weather => {
            this.weather = weather.slice(0, weather.length);
            console.log(weather);
         });
   }
}