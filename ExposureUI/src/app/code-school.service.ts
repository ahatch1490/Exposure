import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';


@Injectable()
export class CodeSchoolService {
  CodeCampUrl = 'http://localhost:4200/assets/education/ahatch1490.json'; 
  constructor(private http: HttpClient) { }
  GetCompletedCourses()     {
    return this.http.get<any>(this.CodeCampUrl,{ observe: 'response' });
  }
}




