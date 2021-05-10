import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Frame } from './warframes/frame';
import { FRAMES } from './mocks/mock-frames';
import { GUNS } from './mocks/mock-guns';

@Injectable({
  providedIn: 'root',
})
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const frames = FRAMES;
    const guns = GUNS;
    return { frames, guns };
  }

  genId(frames: Frame[]): number {
    return 11 + frames.length;
  }
}