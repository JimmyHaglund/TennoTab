import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Frame } from './frame';
import { FRAMES } from './mock-frames';
import { MessageService } from './message.service';

/*
From: https://angular.io/tutorial/toh-pt4
When you provide the service at the root level, Angular creates a single, 
shared instance of HeroService and injects into any class that asks for it. 
Registering the provider in the @Injectable metadata also allows Angular to 
optimize an application by removing the service if it turns out not to be used after all.
/**/
@Injectable({
  providedIn: 'root'
})

export class FrameService {
  /*
  This is a typical "service-in-service" scenario: you inject the 
  MessageService into the HeroService which is injected into the HeroesComponent.
  /**/
  constructor(private messageService: MessageService) { }

  getFrames(): Observable<Frame[]> {
    const frames = of(FRAMES);
    this.messageService.add('FrameService: Fetched frames');
    return frames;
  }
}
