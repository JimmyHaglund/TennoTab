import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Frame } from './frame';
import { FRAMES } from './mocks/mock-frames';

@Injectable({
  providedIn: 'root',
})
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const frames = FRAMES;
    return { frames };
  }

  genId(frames: Frame[]): number {
    return 11 + frames.length;
  }
}