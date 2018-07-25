import {Component, Inject} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
export interface DialogData {
  animal: string;
  name: string;
}
@Component({
    selector: 'education-cs-dialog',
    templateUrl: 'education-cs.dialog.html',
    styleUrls: ['./education-cs.dialog.css']
  })
  export class EducationCodeSchoolDialog {
  
    constructor(@Inject(MAT_DIALOG_DATA) public data: DialogData) {}
        // public dialogRef: MatDialogRef<EducationWWUDialog>,
        // @Inject(MAT_DIALOG_DATA) public data: DialogData) {}
  
    // onNoClick(): void {
    //   this.dialogRef.close();
    // }
  
  }