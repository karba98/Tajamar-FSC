import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TablaMultiComponent } from './tabla-multi.component';

describe('TablaMultiComponent', () => {
  let component: TablaMultiComponent;
  let fixture: ComponentFixture<TablaMultiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TablaMultiComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TablaMultiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
