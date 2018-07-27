import {Component, Inject} from '@angular/core';
import { PluralSightService } from "../plural-sight-service";
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';

@Component({
    selector: 'education-ps-dialog',
    templateUrl: 'education-ps.dialog.html',
    styleUrls: ['./education-ps.dialog.css'],
    providers: [ PluralSightService ]
  })
  export class EducationPSDialog {

    public courses: any 
    public error: any 
    constructor(private service: PluralSightService) { }

    ngOnInit() {
      this.service.GetCompletedCourses().subscribe(
        (data: any) => {
         this.courses = data.body.courses;
          //console.log(data.body.courses);
        } , 
        error => this.error = error // error path
        );
    }    
  
  }