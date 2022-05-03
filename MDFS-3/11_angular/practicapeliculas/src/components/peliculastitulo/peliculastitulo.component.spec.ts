import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PeliculastituloComponent } from './peliculastitulo.component';

describe('PeliculastituloComponent', () => {
  let component: PeliculastituloComponent;
  let fixture: ComponentFixture<PeliculastituloComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PeliculastituloComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PeliculastituloComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
