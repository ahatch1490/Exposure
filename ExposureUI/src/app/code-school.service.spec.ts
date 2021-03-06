import { TestBed, inject } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';
import { CodeSchoolService } from './code-school.service';

describe('CodeSchoolService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CodeSchoolService],
      imports: [HttpClientModule]
    });
  });

  it('should be created', inject([CodeSchoolService], (service: CodeSchoolService) => {
    expect(service).toBeTruthy();
  }));

  it('should return stuff', inject([CodeSchoolService], (service: CodeSchoolService) => {
    expect(service.GetCompletedCourses().subscribe(resp => {console.log(resp)}))
  }));
});
