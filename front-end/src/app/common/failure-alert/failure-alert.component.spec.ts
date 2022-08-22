import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FailureAlertComponent } from './failure-alert.component';

describe('FailureAlertComponent', () => {
  let component: FailureAlertComponent;
  let fixture: ComponentFixture<FailureAlertComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FailureAlertComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FailureAlertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
