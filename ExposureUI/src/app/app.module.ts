import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {NoopAnimationsModule} from '@angular/platform-browser/animations';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { 
  MatGridListModule,
  MatGridTile,
  MatCardModule, 
  MatIconModule,
  MatButtonModule,
  MatExpansionModule,
} from '@angular/material';
import { MainMenuComponent } from './main-menu/main-menu.component';
import { StackOverflowComponent } from './stack-overflow/stack-overflow.component';
import { RouterModule, Routes } from '@angular/router';
import { GithubComponent } from './github/github.component';
import { BioComponent } from './bio/bio.component';
import { EducationComponent } from './education/education.component';
import { BooksComponent } from './books/books.component';
import { LinkedinComponent } from './linkedin/linkedin.component';
import {FlexLayoutModule} from '@angular/flex-layout';
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
    AngularFontAwesomeModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
