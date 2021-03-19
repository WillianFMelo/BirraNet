import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CervejasComponent } from './cervejas/cervejas.component';
import { CervejaComponent } from './cervejas/cerveja/cerveja.component';
import { CervejaServices } from './cervejas/cerveja.service';
import { ChatBotComponent } from './chat-bot/chat-bot.component';
import { MensagemComponent } from './mensagem/mensagem.component';
import { MensagemService } from './mensagem/mensagem.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CervejasComponent,
    CervejaComponent,
    ChatBotComponent,
    MensagemComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'cervejas', component: CervejasComponent },
      {path: 'chat-bot', component: ChatBotComponent}
    ])
  ],
  providers: [CervejaServices, MensagemService],
  bootstrap: [AppComponent]
})
export class AppModule { }
