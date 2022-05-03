import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PadrecontadorComponent } from './padrecontador.component';

describe('PadrecontadorComponent', () => {
  let component: PadrecontadorComponent;
  let fixture: ComponentFixture<PadrecontadorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PadrecontadorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PadrecontadorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
