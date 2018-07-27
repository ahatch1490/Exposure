import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import {MatGridListModule,MatListModule} from '@angular/material'
import { CodeSchoolComponent } from './code-school.component';
import { HttpClientModule } from '@angular/common/http';


describe('CodeSchoolComponent', () => {
  let component: CodeSchoolComponent;
  let fixture: ComponentFixture<CodeSchoolComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CodeSchoolComponent ],
      imports:      [ MatGridListModule,MatListModule,HttpClientModule],

    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CodeSchoolComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
