import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MiraEstoComponent } from './mira-esto.component';

describe('MiraEstoComponent', () => {
  let component: MiraEstoComponent;
  let fixture: ComponentFixture<MiraEstoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MiraEstoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MiraEstoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
