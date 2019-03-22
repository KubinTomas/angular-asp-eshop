import { PriceFilterPipe } from './pipes/price-filter.pipe';
import { AuthGuardIsLogged } from './services/guards/auth-guard-is-logged.service';
import { SnackBarService } from './services/others/snack-bar.service';
import { ItemService } from './services/http/item.service';
import { AuthGuard } from './services/guards/auth-guard.service';
import { AuthenticationService } from './services/http/authentication.service';
import { ShoppingCartService } from './services/others/shopping-cart.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component';
import { EshopComponent } from './eshop/eshop.component';
import { AdministrationComponent } from './administration/administration.component';
import { HeaderComponent } from './eshop/header/header.component';
import { SidebarComponent } from './eshop/sidebar/sidebar.component';
import { ContentComponent } from './eshop/content/content.component';
import { ItemFilterComponent } from './eshop/content/item-filter/item-filter.component';
import { ItemsComponent } from './eshop/content/items/items.component';
import { ItemComponent } from './eshop/content/items/item/item.component';
import { ItemDetailComponent } from './eshop/content/items/item/item-detail/item-detail.component';
import { ItemFormComponent } from './eshop/content/items/item/item-form/item-form.component';
import { UserManageComponent } from './eshop/header/user-manage/user-manage.component';
import { LoginFormComponent } from './eshop/header/user-manage/login-form/login-form.component';
import { RegistrationFormComponent } from './eshop/header/user-manage/registration-form/registration-form.component';
import { ShoppingCartComponent } from './eshop/header/shopping-cart/shopping-cart.component';
import { ItemPreviewComponent } from './eshop/header/shopping-cart/item-preview/item-preview.component';
import { OrderComponent } from './eshop/content/order/order.component';
import { AboutComponent } from './eshop/content/about/about.component';
import { ArticlesComponent } from './eshop/content/articles/articles.component';
import { ArticlePreviewComponent } from './eshop/content/articles/article-preview/article-preview.component';
import { ArticleDetailComponent } from './eshop/content/articles/article-detail/article-detail.component';
import { ArticleFormComponent } from './eshop/content/articles/article-form/article-form.component';
import { MatComponentModule } from './mat-component.module';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { RoutingModule } from './routing/routing.module';
import { DefaultComponent } from './eshop/content/default/default.component';
import { AdmMainComponent } from './administration/adm-main/adm-main.component';
import { AdmItemsComponent } from './administration/adm-main/adm-items/adm-items.component';
import { AdmItemFormComponent } from './administration/adm-main/adm-items/adm-item-form/adm-item-form.component';
import { AdmItemsOutputComponent } from './administration/adm-main/adm-items/adm-items-output/adm-items-output.component';
import { AdmArticlesComponent } from './administration/adm-main/adm-articles/adm-articles.component';
import { AdmArticleFormComponent } from './administration/adm-main/adm-articles/adm-article-form/adm-article-form.component';
import { AdmArticlesOutputComponent } from './administration/adm-main/adm-articles/adm-articles-output/adm-articles-output.component';
import { AdmOrdersComponent } from './administration/adm-main/adm-orders/adm-orders.component';
import { AdmOrderDetailComponent } from './administration/adm-main/adm-orders/adm-order-detail/adm-order-detail.component';
import { AdmSidebarComponent } from './administration/adm-sidebar/adm-sidebar.component';
import { NewItemsComponent } from './eshop/sidebar/new-items/new-items.component';
import { FbLinkComponent } from './eshop/sidebar/fb-link/fb-link.component';
import { BestSellersComponent } from './eshop/sidebar/best-sellers/best-sellers.component';
import { FeaturedProductsComponent } from './eshop/sidebar/featured-products/featured-products.component';
import { NewArticlesComponent } from './eshop/content/default/new-articles/new-articles.component';
import { NewArtPreviewComponent } from './eshop/content/default/new-articles/new-art-preview/new-art-preview.component'
import { EditorModule } from '@tinymce/tinymce-angular';
import { CartSummaryComponent } from './eshop/content/order/cart-summary/cart-summary.component';
import { ShippingAndPaymentComponent } from './eshop/content/order/shipping-and-payment/shipping-and-payment.component';
import { DeliveryDataComponent } from './eshop/content/order/delivery-data/delivery-data.component';
import { IsLoadingComponent } from './others-components/is-loading/is-loading.component';
import { UserProfilComponent } from './eshop/content/user-profil/user-profil.component';
import { ProfilFormComponent } from './eshop/content/user-profil/profil-form/profil-form.component';
import { Ng5SliderModule } from 'ng5-slider';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ItemFilterPipe } from './pipes/item-filter.pipe';
import { FaqComponent } from './eshop/content/faq/faq.component';
import { ContactsComponent } from './eshop/content/contacts/contacts.component';
import { ScriptHackComponent } from './eshop/content/script-hack/script-hack.component';
import { NewSidebarArticlesComponent } from './eshop/sidebar/new-sidebar-articles/new-sidebar-articles.component';
import { FooterComponent } from './eshop/footer/footer.component';
import { UserOrdersComponent } from './eshop/content/user-orders/user-orders.component';
import { OrderDetailComponent } from './eshop/content/user-orders/order-detail/order-detail.component';
import { QuestionFormComponent } from './eshop/content/question-form/question-form.component';
import { TemsAndConditionsComponent } from './eshop/content/tems-and-conditions/tems-and-conditions.component';
import { CartService } from './services/http/cart.service';

@NgModule({
  declarations: [
    AppComponent,
    EshopComponent,
    AdministrationComponent,
    HeaderComponent,
    SidebarComponent,
    ContentComponent,
    ItemFilterComponent,
    ItemsComponent,
    ItemComponent,
    ItemDetailComponent,
    ItemFormComponent,
    UserManageComponent,
    LoginFormComponent,
    RegistrationFormComponent,
    ShoppingCartComponent,
    ItemPreviewComponent,
    OrderComponent,
    AboutComponent,
    ArticlesComponent,
    ArticlePreviewComponent,
    ArticleDetailComponent,
    ArticleFormComponent,
    DefaultComponent,
    AdmMainComponent,
    AdmItemsComponent,
    AdmItemFormComponent,
    AdmItemsOutputComponent,
    AdmArticlesComponent,
    AdmArticleFormComponent,
    AdmArticlesOutputComponent,
    AdmOrdersComponent,
    AdmOrderDetailComponent,
    AdmSidebarComponent,
    NewItemsComponent,
    FbLinkComponent,
    BestSellersComponent,
    FeaturedProductsComponent,
    NewArticlesComponent,
    NewArtPreviewComponent,
    CartSummaryComponent,
    ShippingAndPaymentComponent,
    DeliveryDataComponent,
    IsLoadingComponent,
    UserProfilComponent,
    ProfilFormComponent,
    ItemFilterPipe,
    PriceFilterPipe,
    FaqComponent,
    ContactsComponent,
    ScriptHackComponent,
    NewSidebarArticlesComponent,
    FooterComponent,
    UserOrdersComponent,
    OrderDetailComponent,
    QuestionFormComponent,
    TemsAndConditionsComponent
    
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatComponentModule,
    FormsModule,
    ReactiveFormsModule,
    RoutingModule,
    HttpModule,
    EditorModule,
    Ng5SliderModule,
    NgxDatatableModule
  ],
  providers: [
     AuthenticationService,
     AuthGuard,
     AuthGuardIsLogged,
     ItemService,
     ShoppingCartService,
     SnackBarService,
     ItemFilterPipe,
     PriceFilterPipe,
     CartService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
