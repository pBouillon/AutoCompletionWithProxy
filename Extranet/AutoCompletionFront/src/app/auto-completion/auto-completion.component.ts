import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { AutoCompletionService } from './auto-completion.service';

@Component({
  selector: 'app-auto-completion',
  templateUrl: './auto-completion.component.html',
  styleUrls: ['./auto-completion.component.css']
})
export class AutoCompletionComponent implements OnInit {

  form: FormControl;
  suggestions: string[];

  constructor(
    private autoCompletionService: AutoCompletionService,
  ) { }

  ngOnInit() {
    this.form = new FormControl();
    this.suggestions = [];
  }

  onFieldUpdate(element: HTMLInputElement) {
    this.autoCompletionService
      .getSuggestions(element.value)
      .subscribe(results => this.suggestions = results);
  }

}
