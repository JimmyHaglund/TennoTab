import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrimaryWeaponsListComponent } from './primary-weapons-list.component';

describe('WeaponsListComponent', () => {
  let component: PrimaryWeaponsListComponent;
  let fixture: ComponentFixture<PrimaryWeaponsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PrimaryWeaponsListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PrimaryWeaponsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
