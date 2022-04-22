import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HairtransplantComponent } from './hairtransplant.component';

describe('HairtransplantComponent', () => {
  let component: HairtransplantComponent;
  let fixture: ComponentFixture<HairtransplantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HairtransplantComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HairtransplantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
