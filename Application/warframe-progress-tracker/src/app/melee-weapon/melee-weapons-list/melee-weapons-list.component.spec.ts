import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MeleeWeaponsListComponent } from './melee-weapons-list.component';

describe('MeleeWeaponsListComponent', () => {
  let component: MeleeWeaponsListComponent;
  let fixture: ComponentFixture<MeleeWeaponsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MeleeWeaponsListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MeleeWeaponsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
