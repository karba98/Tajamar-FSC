import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComicsLibreriaComponent } from './comics-libreria.component';

describe('ComicsLibreriaComponent', () => {
  let component: ComicsLibreriaComponent;
  let fixture: ComponentFixture<ComicsLibreriaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComicsLibreriaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComicsLibreriaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
