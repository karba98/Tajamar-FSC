import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpleadossalarioComponent } from './empleadossalario.component';

describe('EmpleadossalarioComponent', () => {
  let component: EmpleadossalarioComponent;
  let fixture: ComponentFixture<EmpleadossalarioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmpleadossalarioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpleadossalarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
