import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import {MatExpansionModule,MatGridListModule} from '@angular/material'
import { MainMenuComponent } from './main-menu.component';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

describe('MainMenuComponent', () => {
  let component: MainMenuComponent;
  let fixture: ComponentFixture<MainMenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [MatExpansionModule,
        BrowserAnimationsModule,
        MatGridListModule,
        AngularFontAwesomeModule],
      declarations: [ MainMenuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MainMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
