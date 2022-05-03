import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModificarPlantillaComponent } from './modificar-plantilla.component';

describe('ModificarPlantillaComponent', () => {
  let component: ModificarPlantillaComponent;
  let fixture: ComponentFixture<ModificarPlantillaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModificarPlantillaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ModificarPlantillaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
