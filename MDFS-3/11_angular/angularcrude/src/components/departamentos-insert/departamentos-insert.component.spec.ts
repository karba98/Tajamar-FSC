import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartamentosInsertComponent } from './departamentos-insert.component';

describe('DepartamentosInsertComponent', () => {
  let component: DepartamentosInsertComponent;
  let fixture: ComponentFixture<DepartamentosInsertComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DepartamentosInsertComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DepartamentosInsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
