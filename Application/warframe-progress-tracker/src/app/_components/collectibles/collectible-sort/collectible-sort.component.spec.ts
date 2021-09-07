import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CollectibleSortComponent } from './collectible-sort.component';

describe('CollectibleSortComponent', () => {
  let component: CollectibleSortComponent;
  let fixture: ComponentFixture<CollectibleSortComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CollectibleSortComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CollectibleSortComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
