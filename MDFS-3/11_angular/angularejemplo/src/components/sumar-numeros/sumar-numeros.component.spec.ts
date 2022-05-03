import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SumarNumerosComponent } from './sumar-numeros.component';

describe('SumarNumerosComponent', () => {
  let component: SumarNumerosComponent;
  let fixture: ComponentFixture<SumarNumerosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SumarNumerosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SumarNumerosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
