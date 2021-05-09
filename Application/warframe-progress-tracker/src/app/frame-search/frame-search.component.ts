import { Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { debounceTime, distinctUntilChanged, switchMap } from 'rxjs/operators';

import { Frame } from '../frame';
import { FrameService } from '../frame.service';

@Component({
  selector: 'app-frame-search',
  templateUrl: './frame-search.component.html',
  styleUrls: [ './frame-search.component.css' ]
})
export class FrameSearchComponent implements OnInit {
  frames$?: Observable<Frame[]>;
  private searchTerms = new Subject<string>();

  constructor(private frameService: FrameService) {}
  
  search(term: string): void {
    this.searchTerms.next(term);
  }

  ngOnInit(): void {
    this.frames$ = this.searchTerms.pipe(
      debounceTime(300),
      distinctUntilChanged(),
      switchMap((term: string) => this.frameService.searchFrames(term)),
    );
  }
}