import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CollectibleFilterComponent } from './collectible-filter.component';

describe('CollectibleSearchComponent', () => {
  let component: CollectibleFilterComponent;
  let fixture: ComponentFixture<CollectibleFilterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CollectibleFilterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CollectibleFilterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
