import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemCostCardComponent } from './item-cost-card.component';

describe('ItemCostCardComponent', () => {
  let component: ItemCostCardComponent;
  let fixture: ComponentFixture<ItemCostCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ItemCostCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ItemCostCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
