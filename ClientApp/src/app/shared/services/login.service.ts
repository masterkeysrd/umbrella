import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { UserLogin } from '../models/user-login';

@Injectable()
export class LoginService {
  apiUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiUrl = baseUrl + "api/v1/auth/";
  }

  login(userLogin: UserLogin): Observable<any> {
    return this.http.post(this.apiUrl + "login", userLogin);
  }
}
