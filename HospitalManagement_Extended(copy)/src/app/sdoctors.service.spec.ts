import { TestBed } from '@angular/core/testing';

import { SdoctorsService } from './sdoctors.service';

describe('SdoctorsService', () => {
  let service: SdoctorsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SdoctorsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
