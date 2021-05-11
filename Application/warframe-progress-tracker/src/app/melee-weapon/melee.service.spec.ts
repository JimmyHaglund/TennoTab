import { TestBed } from '@angular/core/testing';

import { MeleeService } from './melee.service';

describe('MeleeService', () => {
  let service: MeleeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MeleeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
