import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Frame } from './warframes/frame';
import { FRAMES, GUNS, MELEEWEAPONS } from './mocks';

@Injectable({
  providedIn: 'root',
})
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const frames = FRAMES;
    const guns = GUNS;
    const melee = MELEEWEAPONS;
    return { frames, guns, melee};
  }

  genId(frames: Frame[]): number {
    return 11 + frames.length;
  }
}