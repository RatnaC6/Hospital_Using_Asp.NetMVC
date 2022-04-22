import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CancercareComponent } from './cancercare.component';

describe('CancercareComponent', () => {
  let component: CancercareComponent;
  let fixture: ComponentFixture<CancercareComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CancercareComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CancercareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
