import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteCollectibleComponent } from './delete-collectible.component';

describe('DeleteCollectibleComponent', () => {
  let component: DeleteCollectibleComponent;
  let fixture: ComponentFixture<DeleteCollectibleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteCollectibleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DeleteCollectibleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
