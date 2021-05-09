import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FrameSearchComponent } from './frame-search.component';

describe('FrameSearchComponent', () => {
  let component: FrameSearchComponent;
  let fixture: ComponentFixture<FrameSearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FrameSearchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FrameSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
