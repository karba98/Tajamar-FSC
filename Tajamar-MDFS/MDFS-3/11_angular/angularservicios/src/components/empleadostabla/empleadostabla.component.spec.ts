import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpleadostablaComponent } from './empleadostabla.component';

describe('EmpleadostablaComponent', () => {
  let component: EmpleadostablaComponent;
  let fixture: ComponentFixture<EmpleadostablaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmpleadostablaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpleadostablaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
