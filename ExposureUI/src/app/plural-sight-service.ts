import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable()
export class PluralSightService {
  PuralSightUrl = 'http://localhost:4200/assets/education/PluralSight.json';
  constructor(private http: HttpClient) { }
  GetCompletedCourses() {
    return this.http.get<any>(this.PuralSightUrl, { observe: 'response' });
  }
}