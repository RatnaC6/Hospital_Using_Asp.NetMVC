import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SpecdocsComponent } from './specdocs.component';

describe('SpecdocsComponent', () => {
  let component: SpecdocsComponent;
  let fixture: ComponentFixture<SpecdocsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SpecdocsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SpecdocsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
