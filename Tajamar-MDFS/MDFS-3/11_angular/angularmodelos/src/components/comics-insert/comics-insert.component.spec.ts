import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComicsInsertComponent } from './comics-insert.component';

describe('ComicsInsertComponent', () => {
  let component: ComicsInsertComponent;
  let fixture: ComponentFixture<ComicsInsertComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComicsInsertComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComicsInsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
