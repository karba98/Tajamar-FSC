import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartamentosUpdateComponent } from './departamentos-update.component';

describe('DepartamentosUpdateComponent', () => {
  let component: DepartamentosUpdateComponent;
  let fixture: ComponentFixture<DepartamentosUpdateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DepartamentosUpdateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DepartamentosUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
