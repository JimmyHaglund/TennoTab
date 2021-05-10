import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SecondaryWeaponsListComponent } from './secondary-weapons-list.component';

describe('SecondaryWeaponsListComponent', () => {
  let component: SecondaryWeaponsListComponent;
  let fixture: ComponentFixture<SecondaryWeaponsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SecondaryWeaponsListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SecondaryWeaponsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
