import { TestBed } from '@angular/core/testing';

import { SalesreturnService } from './salesreturn.service';

describe('SalesreturnService', () => {
  let service: SalesreturnService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SalesreturnService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
