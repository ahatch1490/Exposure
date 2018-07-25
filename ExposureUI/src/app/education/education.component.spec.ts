import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import {MatCardModule,MatGridListModule,MatDialogModule} from '@angular/material'
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { EducationComponent } from './education.component';

describe('EducationComponent', () => {
  let component: EducationComponent;
  let fixture: ComponentFixture<EducationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports:      [ MatCardModule,MatGridListModule,AngularFontAwesomeModule,MatDialogModule],
      declarations: [EducationComponent, ]
    
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EducationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
