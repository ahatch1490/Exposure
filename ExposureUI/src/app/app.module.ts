import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {NoopAnimationsModule} from '@angular/platform-browser/animations';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { 
  MatGridListModule,
  MatListModule,
  MatCardModule, 
  MatIconModule,
  MatButtonModule,
  MatExpansionModule,
  MatDialogModule,
} from '@angular/material';
import { MainMenuComponent } from './main-menu/main-menu.component';
import { StackOverflowComponent } from './stack-overflow/stack-overflow.component';
import { RouterModule, Routes } from '@angular/router';
import { GithubComponent } from './github/github.component';
import { BioComponent } from './bio/bio.component';
import {EducationWWUDialog} from './education/education-wwu.dialog'
import { BooksComponent } from './books/books.component';
import { LinkedinComponent } from './linkedin/linkedin.component';
import {FlexLayoutModule} from '@angular/flex-layout';
import { EducationCodeSchoolDialog } from './education/education-cs.dialog';
import { EducationComponent } from './education/education.component'
import { EducationPSDialog } from './education/education-ps.dialog';
import { CodeSchoolComponent } from './code-school/code-school.component'
import {CodeSchoolService} from './code-school.service'
const appRoutes: Routes = [ 
  {path: '',   redirectTo: '/bio', pathMatch: 'full' },
  {path: 'stack-overflow', component: StackOverflowComponent},
  {path: 'bio', component: BioComponent },
  {path: 'education', component: EducationComponent },
  {path: 'github', component: GithubComponent },
  {path: 'books',  component: BooksComponent  },
  {path: 'linkedin',  component: LinkedinComponent  },
];



@NgModule({
  declarations: [
    AppComponent,
    MainMenuComponent,
    StackOverflowComponent,
    GithubComponent,
    BioComponent,
    EducationComponent,
    BooksComponent,
    LinkedinComponent,
    EducationWWUDialog,
    EducationCodeSchoolDialog,
    EducationPSDialog,
    CodeSchoolComponent    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FlexLayoutModule,
    NoopAnimationsModule,
    MatGridListModule,
    MatCardModule,
    MatIconModule,
    MatButtonModule,
    MatExpansionModule,
    MatDialogModule,
    MatListModule,
    AngularFontAwesomeModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
    
  ],
  entryComponents: [
    EducationWWUDialog,
    EducationCodeSchoolDialog,
    EducationPSDialog
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
