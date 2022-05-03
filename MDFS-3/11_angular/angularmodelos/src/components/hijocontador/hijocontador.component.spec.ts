import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HijocontadorComponent } from './hijocontador.component';

describe('HijocontadorComponent', () => {
  let component: HijocontadorComponent;
  let fixture: ComponentFixture<HijocontadorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HijocontadorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HijocontadorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
