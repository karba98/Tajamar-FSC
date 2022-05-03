import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpleadosoficioComponent } from './empleadosoficio.component';

describe('EmpleadosoficioComponent', () => {
  let component: EmpleadosoficioComponent;
  let fixture: ComponentFixture<EmpleadosoficioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmpleadosoficioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpleadosoficioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
