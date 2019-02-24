import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-auto-completion',
  templateUrl: './auto-completion.component.html',
  styleUrls: ['./auto-completion.component.css']
})
export class AutoCompletionComponent implements OnInit {

  // -- Angular Material tutorial
  options: string[] = ['salut', 'mon', 'flo'];
  // -- Angular Material tutorial

  form: FormControl;
  suggestions: string[];

  ngOnInit() {
    this.form = new FormControl();
    this.suggestions = [];
  }

}
