import { TestBed } from '@angular/core/testing';

import { SbookAptService } from './sbook-apt.service';

describe('SbookAptService', () => {
  let service: SbookAptService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SbookAptService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
