import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FrameDetailComponent } from './frame-detail.component';

describe('WarframeDetailComponent', () => {
  let component: FrameDetailComponent;
  let fixture: ComponentFixture<FrameDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FrameDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FrameDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
