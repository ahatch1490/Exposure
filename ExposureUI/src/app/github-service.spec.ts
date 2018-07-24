import { TestBed, inject } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';
import { GitHubService } from './github-service';

describe('GitHubService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule] , 
      providers: [GitHubService]
    });
  });

  it('should be created', inject([GitHubService], (service: GitHubService) => {
    expect(service).toBeTruthy();
  }));

  it('should return stuff', inject([GitHubService], (service: GitHubService) => {

    expect(service.GetRepo('ahatch1490/moxiworks-dotnet').subscribe(resp => {console.log(resp)}))
  }));
});


