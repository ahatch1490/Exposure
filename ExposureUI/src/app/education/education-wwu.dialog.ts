import {Component, Inject} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
export interface DialogData {
  animal: string;
  name: string;
}
@Component({
    selector: 'education-wwu-dialog',
    templateUrl: 'education-wwu.dialog.html',
    styleUrls: ['./education-wwu.dialog.css']
  })
  export class EducationWWUDialog {
  
    constructor(@Inject(MAT_DIALOG_DATA) public data: DialogData) {}
  
  }