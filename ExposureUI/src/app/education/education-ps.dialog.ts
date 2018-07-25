import {Component, Inject} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
export interface DialogData {
  animal: string;
  name: string;
}
@Component({
    selector: 'education-ps-dialog',
    templateUrl: 'education-ps.dialog.html',
    styleUrls: ['./education-ps.dialog.css']
  })
  export class EducationPSDialog {
  
    constructor(@Inject(MAT_DIALOG_DATA) public data: DialogData) {}
        // public dialogRef: MatDialogRef<EducationWWUDialog>,
        // @Inject(MAT_DIALOG_DATA) public data: DialogData) {}
  
    // onNoClick(): void {
    //   this.dialogRef.close(); 
    // }
  
  }