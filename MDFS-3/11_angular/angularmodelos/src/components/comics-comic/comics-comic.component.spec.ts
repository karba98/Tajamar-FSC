import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComicsComicComponent } from './comics-comic.component';

describe('ComicsComicComponent', () => {
  let component: ComicsComicComponent;
  let fixture: ComponentFixture<ComicsComicComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComicsComicComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComicsComicComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
