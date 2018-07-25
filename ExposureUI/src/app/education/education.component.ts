import { Component, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
import { EducationWWUDialog } from './education-wwu.dialog';
import { EducationCodeSchoolDialog} from './education-cs.dialog';
import {EducationPSDialog} from "./education-ps.dialog";

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css']
})
export class EducationComponent implements OnInit {

  constructor(public dialog: MatDialog) {}
  ngOnInit() {
  }
  openWWUDialog() : void {
     this.dialog.open(EducationWWUDialog, {});
  }

  openCodeSchoolDialog() : void {
    this.dialog.open(EducationCodeSchoolDialog, {});
 }

  openPSDialog() : void {
    this.dialog.open(EducationPSDialog, {});
  }
}
