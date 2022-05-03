import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetallesempleadoComponent } from './detallesempleado.component';

describe('DetallesempleadoComponent', () => {
  let component: DetallesempleadoComponent;
  let fixture: ComponentFixture<DetallesempleadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetallesempleadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetallesempleadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
