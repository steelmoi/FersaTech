import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportTrasactionComponent } from './report-trasaction.component';

describe('ReportTrasactionComponent', () => {
  let component: ReportTrasactionComponent;
  let fixture: ComponentFixture<ReportTrasactionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ReportTrasactionComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ReportTrasactionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
