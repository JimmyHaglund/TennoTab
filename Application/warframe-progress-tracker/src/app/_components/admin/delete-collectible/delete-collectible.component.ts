import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { CollectibleService } from 'src/app/_services';

@Component({
  selector: 'app-delete-collectible',
  templateUrl: './delete-collectible.component.html',
  styleUrls: ['./delete-collectible.component.scss']
})
export class DeleteCollectibleComponent implements OnInit {
  public nameControl = new FormControl('');
  constructor(private _collectibleService: CollectibleService) { }

  ngOnInit(): void { }

  public submit(): void {
    var name = this.nameControl.value;
    this._collectibleService.deleteCollectible(name);
  }

}
