import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LoginComponent } from './security/login/login.component';
import { SideBarComponent } from './side-bar/side-bar.component';
import { AdvertisingComponent } from './layout/advertising/advertising.component';
import { ItemComponent } from './layout/item/item.component';
import { SocialLoginModule, AuthServiceConfig, FacebookLoginProvider, AuthService } from 'angular-6-social-login';
import { LoginService } from './shared/services/login.service';

export function getAuthServiceConfigs() {
  const config = new AuthServiceConfig(
    [{
      id: FacebookLoginProvider.PROVIDER_ID,
      provider: new FacebookLoginProvider('706875369694240')
    }]
  );

  return config;
}

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    SideBarComponent,
    AdvertisingComponent,
    ItemComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    SocialLoginModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'login', component: LoginComponent },
    ])
  ],
  providers: [LoginService, { provide: AuthServiceConfig, useFactory: getAuthServiceConfigs }],
  bootstrap: [AppComponent]
})
export class AppModule { }
