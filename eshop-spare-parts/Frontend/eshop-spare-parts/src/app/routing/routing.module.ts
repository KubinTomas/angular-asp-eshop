import { TemsAndConditionsComponent } from './../eshop/content/tems-and-conditions/tems-and-conditions.component';
import { QuestionFormComponent } from './../eshop/content/question-form/question-form.component';
import { OrderDetailComponent } from './../eshop/content/user-orders/order-detail/order-detail.component';
import { ProfilFormComponent } from './../eshop/content/user-profil/profil-form/profil-form.component';
import { UserProfilComponent } from './../eshop/content/user-profil/user-profil.component';
import { OrderComponent } from './../eshop/content/order/order.component';
import { AuthGuard } from './../services/guards/auth-guard.service';
import { AuthGuardIsLogged } from './../services/guards/auth-guard-is-logged.service';
import { AdmOrdersComponent } from './../administration/adm-main/adm-orders/adm-orders.component';
import { AdmArticleFormComponent } from './../administration/adm-main/adm-articles/adm-article-form/adm-article-form.component';
import { AdmArticlesComponent } from './../administration/adm-main/adm-articles/adm-articles.component';
import { AdmItemsComponent } from './../administration/adm-main/adm-items/adm-items.component';
import { AdmItemFormComponent } from './../administration/adm-main/adm-items/adm-item-form/adm-item-form.component';
import { AdmMainComponent } from './../administration/adm-main/adm-main.component';
import { AdministrationComponent } from './../administration/administration.component';
import { AboutComponent } from './../eshop/content/about/about.component';
import { ArticlesComponent } from './../eshop/content/articles/articles.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { EshopComponent } from '../eshop/eshop.component';
import { ItemsComponent } from '../eshop/content/items/items.component';
import { DefaultComponent } from '../eshop/content/default/default.component';
import { ItemDetailComponent } from '../eshop/content/items/item/item-detail/item-detail.component';
import { ArticleDetailComponent } from '../eshop/content/articles/article-detail/article-detail.component';
import { LoginFormComponent } from '../eshop/header/user-manage/login-form/login-form.component';
import { RegistrationFormComponent } from '../eshop/header/user-manage/registration-form/registration-form.component';
import { FaqComponent } from '../eshop/content/faq/faq.component';
import { ContactsComponent } from '../eshop/content/contacts/contacts.component';
import { UserOrdersComponent } from '../eshop/content/user-orders/user-orders.component';

const routes: Routes = [
  {
    path: '',
    component: EshopComponent,
    children: [
      { path: '', component: DefaultComponent },
      { path: 'articles', component: ArticlesComponent },
      { path: 'faq', component: FaqComponent },
      { path: 'contacts', component: ContactsComponent },
      { path: 'profil', component: UserProfilComponent, canActivate: [AuthGuardIsLogged] },
      { path: 'edit-profil', component: ProfilFormComponent, canActivate: [AuthGuardIsLogged] },
      { path: 'items', component: ItemsComponent },
      { path: 'items/:categoryId', component: ItemsComponent },
      { path: 'item-detail/:id', component: ItemDetailComponent },
      { path: 'articles', component: ArticlesComponent },
      { path: 'article-detail/:id', component: ArticleDetailComponent },
      { path: 'login', component: LoginFormComponent },
      { path: 'registration-form', component: RegistrationFormComponent },
      { path: 'about', component: AboutComponent },
      { path: 'order', component: OrderComponent },
      { path: 'user-orders', component: UserOrdersComponent },
      { path: 'order-detail/:code', component: OrderDetailComponent },
      { path: 'question-form', component: QuestionFormComponent },
      { path: 'terms-and-conditions', component: TemsAndConditionsComponent }
      
    ],
  },
  {
    path: 'administration', component: AdministrationComponent, canActivate: [AuthGuard], children: [
      { path: '', component: AdmMainComponent },
      { path: 'items', component: AdmItemsComponent },
      { path: 'item-form', component: AdmItemFormComponent },
      { path: 'edit-item/:id', component: AdmItemFormComponent },
      { path: 'articles', component: AdmArticlesComponent },
      { path: 'article-form', component: AdmArticleFormComponent },
      { path: 'edit-article/:id', component: AdmArticleFormComponent },
      { path: 'orders', component: AdmOrdersComponent },
      { path: 'orders/order-detail/:code', component: OrderDetailComponent }
    ]
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class RoutingModule { }
