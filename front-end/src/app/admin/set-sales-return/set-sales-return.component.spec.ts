import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SetSalesReturnComponent } from './set-sales-return.component';

describe('SetSalesReturnComponent', () => {
  let component: SetSalesReturnComponent;
  let fixture: ComponentFixture<SetSalesReturnComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SetSalesReturnComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SetSalesReturnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
