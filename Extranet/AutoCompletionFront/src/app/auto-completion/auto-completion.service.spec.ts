import { TestBed } from '@angular/core/testing';

import { AutoCompletionService } from './auto-completion.service';

describe('AutoCompletionService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AutoCompletionService = TestBed.get(AutoCompletionService);
    expect(service).toBeTruthy();
  });
});
