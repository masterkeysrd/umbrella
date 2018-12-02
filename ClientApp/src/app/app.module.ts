import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LoginComponent } from './security/login/login.component';
import { SignUpComponent } from './layout/sign-up/sign-up.component';
import { LoginService } from './shared/services/login.service';
import { UserService } from './shared/services/user.service';
import { PromotionComponent } from './layout/promotion/promotion.component';
import { FilterComponent } from './layout/filter/filter.component';
import { ProductComponent } from './layout/product/product.component';
import { ProductItemComponent } from './layout/product-item/product-item.component';
import { ProductViewComponent } from './layout/product-view/product-view.component';
import { ShopsComponent } from './layout/shops/shops.component';
import { ProductPublicationComponent } from './layout/product-publication/product-publication.component';
import { MiraEstoComponent } from './layout/mira-esto/mira-esto.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    SignUpComponent,
    PromotionComponent,
    FilterComponent,
    ProductComponent,
    ProductItemComponent,
    ProductViewComponent,
    ShopsComponent,
    ProductPublicationComponent,
    MiraEstoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'login', component: LoginComponent },
      { path: 'sign-up', component: SignUpComponent },
      { path: 'shops', component: ShopsComponent },
      { path: 'product/publication', component: ProductPublicationComponent },
      { path: 'test', component: MiraEstoComponent }
    ])
  ],
  providers: [
    LoginService,
    UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
