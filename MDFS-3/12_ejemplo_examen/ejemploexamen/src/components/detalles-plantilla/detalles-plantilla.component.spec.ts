import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetallesPlantillaComponent } from './detalles-plantilla.component';

describe('DetallesPlantillaComponent', () => {
  let component: DetallesPlantillaComponent;
  let fixture: ComponentFixture<DetallesPlantillaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetallesPlantillaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetallesPlantillaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
