import { TestBed } from '@angular/core/testing';

import { TotalsalereturnService } from './totalsalereturn.service';

describe('TotalsalereturnService', () => {
  let service: TotalsalereturnService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TotalsalereturnService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
