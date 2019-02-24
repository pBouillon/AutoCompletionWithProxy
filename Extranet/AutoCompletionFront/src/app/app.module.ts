import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material';

import { AppComponent } from './app.component';
import { AutoCompletionComponent } from './auto-completion/auto-completion.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { AutoCompletionService } from './auto-completion/auto-completion.service';
import { HttpClientModule } from '@angular/common/http';

const materialModules = [
  MatAutocompleteModule,
  MatFormFieldModule,
  MatInputModule,
];

@NgModule({
  declarations: [
    AppComponent,
    AutoCompletionComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    FormsModule,
    ...materialModules,
    HttpClientModule,
  ],
  providers: [
    AutoCompletionService,
    HttpClientModule,
  ],
  bootstrap: [
    AppComponent,
  ],
})
export class AppModule { }
