import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AutoCompletionService {

  readonly ApiUrl = 'https://localhost:44393/api/AutoCompletion/';

  constructor(
    private httpClient: HttpClient,
  ) { }

  getSuggestions(hint: string): Observable<Array<string>> {
    return this.httpClient.get(`${this.ApiUrl}${hint}`) as Observable<Array<string>>;
  }

}
