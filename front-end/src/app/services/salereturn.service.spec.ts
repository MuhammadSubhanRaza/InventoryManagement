import { TestBed } from '@angular/core/testing';

import { SalereturnService } from './salereturn.service';

describe('SalereturnService', () => {
  let service: SalereturnService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SalereturnService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
