import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import {Repo} from './github/repo';

@Injectable()
export class GitHubService {
  GitHubUrl = 'https://api.github.com/repos/'; 
  constructor(private http: HttpClient) { }
  GetRepos()     {
    return this.http.get<Repo>(this.GitHubUrl,{ observe: 'response' });
  }
  GetRepo(id: string) {
    return this.http.get<Repo>(this.GitHubUrl + id,{ observe: 'response' });

  }
}




