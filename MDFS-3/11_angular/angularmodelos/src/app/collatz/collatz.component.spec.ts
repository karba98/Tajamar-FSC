import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CollatzComponent } from './collatz.component';

describe('CollatzComponent', () => {
  let component: CollatzComponent;
  let fixture: ComponentFixture<CollatzComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CollatzComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CollatzComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
