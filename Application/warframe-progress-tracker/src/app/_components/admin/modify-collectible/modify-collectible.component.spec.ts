import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModifyCollectibleComponent } from './modify-collectible.component';

describe('ModifyCollectibleComponent', () => {
  let component: ModifyCollectibleComponent;
  let fixture: ComponentFixture<ModifyCollectibleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModifyCollectibleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ModifyCollectibleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
