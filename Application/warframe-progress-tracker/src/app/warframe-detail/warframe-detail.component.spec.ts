import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WarframeDetailComponent } from './warframe-detail.component';

describe('WarframeDetailComponent', () => {
  let component: WarframeDetailComponent;
  let fixture: ComponentFixture<WarframeDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WarframeDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WarframeDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
