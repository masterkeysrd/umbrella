import { Component, OnInit } from '@angular/core';
import { LoginService } from '../../shared/services/login.service';
import { UserLogin } from '../../shared/models/user-login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers: [LoginService]
})
export class LoginComponent implements OnInit {

  loginData: UserLogin;

  constructor(private loginService: LoginService) { }

  ngOnInit() {
    this.loginData = new UserLogin(null, null); 
  }

  onLogin() {
    this.loginService.login(this.loginData)
      .subscribe(data => {
        let token = (<any>data).token;
        localStorage.setItem("Jwt", token);
      },
      err => {
        console.error(err);
      });
  }
}
