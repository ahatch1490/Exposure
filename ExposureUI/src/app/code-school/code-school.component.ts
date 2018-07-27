import { Component, OnInit } from '@angular/core';
import { CodeSchoolService } from '../code-school.service';

@Component({
  selector: 'app-code-school',
  templateUrl: './code-school.component.html',
  styleUrls: ['./code-school.component.css'],
  providers: [ CodeSchoolService ]
  
})
export class CodeSchoolComponent implements OnInit {
  public courses: any 
  public error: any 
  constructor(private service: CodeSchoolService ) { }

  ngOnInit() {
    this.service.GetCompletedCourses().subscribe(
      (data: any) => {
        this.courses = data.body.courses.completed;
        //console.log(data.body.courses.completed);
      } , // success path
      error => this.error = error // error path
      );
    }
}
