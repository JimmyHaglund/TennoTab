import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Frame } from './warframes/frame';
import { FRAMES, GUNS, MELEEWEAPONS, USERS } from './mocks';
import { HttpInterceptor } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const frames = FRAMES;
    const guns = GUNS;
    const melee = MELEEWEAPONS;
    const users = USERS;
    return { frames, guns, melee, users };
  }

  genId(frames: Frame[]): number {
    return 11 + frames.length;
  }

  // authenticate(interceptorArgs: HttpInterceptor)

}