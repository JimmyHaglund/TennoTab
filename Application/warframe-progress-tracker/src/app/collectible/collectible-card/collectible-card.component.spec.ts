import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CollectibleCardComponent } from './collectible-card.component';

describe('CollectibleCardComponent', () => {
  let component: CollectibleCardComponent;
  let fixture: ComponentFixture<CollectibleCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CollectibleCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CollectibleCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
